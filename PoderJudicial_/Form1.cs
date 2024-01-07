using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using OfficeOpenXml;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OfficeOpenXml.Style;
using System.Drawing;

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
            openFileDialog.Filter = "Archivos de Excel|*.xlsx;*.xls;*.xlsm";
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

                // Acceder al control 'ruta' en el hilo principal por error q mostraba
                Invoke((MethodInvoker)delegate
                {
                    _ruta = ruta.Text;
                });

                validarRuta(_ruta);

                FileInfo fileInfo = new FileInfo(_ruta);
                ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;
                using (var package = new ExcelPackage(fileInfo))
                {
                    foreach (var hoja in package.Workbook.Worksheets)
                    {
                        //validarEstructuraDocumento(hoja);
                        // Obtiene cantidad de filas
                        int cantidadFilas = hoja.Dimension.Rows;

                        for (int fila = 2; fila <= cantidadFilas; fila++) //Comienza desde la segunda fila
                        {
                            string expediente = hoja.Cells[fila, 3].Text;
                            string actuacion = hoja.Cells[fila, 4].Text;

                            validarParametros(hoja.Name, fila, expediente, actuacion);
                            string apiParam = expediente + " " + actuacion;

                            bool estaFirmado = await getEstaFirmado(apiParam);

                            ExcelRangeBase celdaFirmado = hoja.Cells[fila, 6];

                            //Marca como firmado
                            if (estaFirmado)
                            {
                                celdaFirmado.Value = "SI";
                                celdaFirmado.Style.Fill.PatternType = ExcelFillStyle.Solid; ;
                                celdaFirmado.Style.Fill.BackgroundColor.SetColor(System.Drawing.Color.Green);
                            }
                            else {
                                celdaFirmado.Value = "NO";
                            }
                        }
                    }

                    try
                    {
                        // Guardar los cambios en el archivo Excel
                        await package.SaveAsync(); //await para q espere a q finalice para mostrar el msje
                    }
                    catch (InvalidOperationException ex)
                    {
                        throw new Exception("Error al guardar el archivo, verificar que no esta abierto.");
                    }

                    MessageBox.Show("Se proceso el archivo correctamente.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (ValidationException vex)
            {
                MessageBox.Show(vex.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
                    string filtro = $"{{\"filter\":\"{{\\\"identificador\\\":\\\"{search}\\\"}}\",\"page\":0,\"size\":50}}";

                    // Codifica la cadena JSON
                    string filtroCodificado = Uri.EscapeDataString(filtro);

                    // Construye la URL con los parámetros codificados
                    string urlConParametros = $"{apiUrl}?filtros={filtroCodificado}";

                    // Realiza la solicitud GET con los parámetros en la URL
                    HttpResponseMessage response = await client.GetAsync(urlConParametros);

                    if (!response.IsSuccessStatusCode) throw new Exception("La web eje.juscaba.gob.ar no se encuentra disponible.");

                    string responseData = await response.Content.ReadAsStringAsync();
                    JObject json = JObject.Parse(responseData);
                    return ((JArray)json["content"]).Count > 0 ? true : false;
                }
                catch (Exception ex)
                {
                    throw new Exception("Se produjo un error al querer consultar eje.juscaba.gob.ar.");
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Font = new Font("Arial", 8, FontStyle.Regular);
        }

        private void validarRuta(string ruta)
        {
            if (string.IsNullOrEmpty(ruta)) throw new ValidationException("Debes seleccionar un archivo.");
        }

        private void validarParametros(string hoja, int fila, string expediente, string actuacion)
        {
            if (expediente.Length <= 5) throw new Exception("'Número de exp' contiene un valor incorrecto en la hoja:  " + hoja + "', fila:  " + fila + "'.");
            if (actuacion.Length <= 5) throw new Exception("'Número de actuación' contiene un valor incorrecto en la hoja: '" + hoja + "', fila: '" + fila + "'.");
        }

        //todo agregar esta validación para corroborar q la cantidad de columnas del doc es correcta
        private void validarEstructuraDocumento(ExcelWorksheet hoja)
        {
            if (hoja.Dimension.Columns != 9) throw new Exception("El documento posee una cantidad de columnas incorrectas en la hoja: " + hoja.Name + ". La aplicación espera 9 columnas.");

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
