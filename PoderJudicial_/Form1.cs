using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Threading;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using OfficeOpenXml;
using Newtonsoft.Json.Linq;



namespace PoderJudicial_
{
    public partial class Form1 : MaterialForm
    {
        const string apiUrl = "https://eje.juscaba.gob.ar/iol-api/api/public/expedientes/bandejaActuaciones";

        public Form1()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            //materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);

        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            // Configurar el diálogo para seleccionar archivos
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Archivos de Excel (*.xlsx)|*.xlsx|Todos los archivos (*.*)|*.*";
            openFileDialog.Title = "Seleccionar archivo";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                Invoke((MethodInvoker)delegate
                {
                    ruta.Text = openFileDialog.FileName.ToString();
                });
            }
        }

        private async void LeerArchivo()
        {
            try
            {
                string _ruta = null;

                // Acceder al control 'ruta' en el hilo principal
                Invoke((MethodInvoker)delegate
                {
                    _ruta = ruta.Text;
                });

                FileInfo fileInfo = new FileInfo(_ruta);
                ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;
                using (var package = new ExcelPackage(fileInfo))
                {
                    // Obtener la hoja de trabajo
                    ExcelWorksheet worksheet = package.Workbook.Worksheets[0]; // Puedes cambiar el índice si tu hoja está en otro lugar

                    // Obtener el número de filas en la hoja de trabajo
                    int rowCount = worksheet.Dimension.Rows;

                    // Iterar a través de las filas y modificar los valores en la columna F
                    for (int row = 2; row <= rowCount; row++) // Comenzamos desde la segunda fila asumiendo que la primera fila son encabezados
                    {
                        string apiParam = worksheet.Cells[row, 3].Text + " " + worksheet.Cells[row, 4].Text;

                        bool estaFirmado = await getEstaFirmado(apiParam);

                        // Modificar el valor en la columna F
                        worksheet.Cells[row, 6].Value = estaFirmado ? "SI" : "NO"; // Columna F
                    }

                    // Guardar los cambios en el archivo Excel
                    package.Save();
                    MessageBox.Show("Se proceso el archivo correctamente", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error. " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        static async Task<bool> getEstaFirmado(String search)
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    // Construye los parámetros en formato JSON
                    string filtro = $"{{\"filter\":\"{{\\\"identificador\\\":\\\"{search}\\\"}}\",\"page\":0,\"size\":10}}";

                    // Codifica la cadena JSON
                    string filtroCodificado = Uri.EscapeDataString(filtro);

                    // Construye la URL con los parámetros codificados
                    string urlConParametros = $"{apiUrl}?filtros={filtroCodificado}";

                    // Realiza la solicitud GET con los parámetros en la URL
                    HttpResponseMessage response = await client.GetAsync(urlConParametros);

                    if (response.IsSuccessStatusCode)
                    {
                        string responseData = await response.Content.ReadAsStringAsync();
                        JObject json = JObject.Parse(responseData);
                        return ((JArray)json["content"]).Count > 0 ? true : false;
                    }
                    else
                    {
                        throw new Exception("La web eje.juscaba.gob.ar no se encuentra disponible");
                    }
                }
                catch (Exception ex)                {
                    throw new Exception("Se produjo un error al querer consultar eje.juscaba.gob.ar");
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void materialButton2_Click(object sender, EventArgs e)
        {
            using (LoadingForm frm = new LoadingForm(LeerArchivo))
            {
                frm.Owner = this;
                frm.ShowDialog(this);
            }
        }
    }
}
