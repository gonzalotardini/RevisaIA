using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RevisaIA
{
    public partial class LoadingForm : Form
    {
        private Timer progressTimer;
        private int incremento = 5;
        private int progresoActual = 0;

        public Action Worker {  get; set; }
        public LoadingForm(Action worker)
        {
            InitializeComponent();
            InitializeProgressBar();
            if (worker == null) throw new ArgumentNullException();
            Worker = worker;
            materialProgressBar2.Value = 50;

        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            Task.Factory.StartNew(Worker).ContinueWith(t => { this.Close(); }, TaskScheduler.FromCurrentSynchronizationContext());
        }

        private void LoadingForm_Load(object sender, EventArgs e)
        {

        }

        private void InitializeProgressBar()
        {
            progressTimer = new Timer();
            progressTimer.Tick += ProgressTimer_Tick;
            progressTimer.Interval = 50; // Intervalo en milisegundos

            materialProgressBar2.Minimum = 0;
            materialProgressBar2.Maximum = 100;
            materialProgressBar2.Value = 0;

            // Iniciar el temporizador
            progressTimer.Start();
        }

        private void ProgressTimer_Tick(object sender, EventArgs e)
        {
            progresoActual += incremento;

            if (progresoActual >= materialProgressBar2.Maximum)
            {
                progresoActual = 0;
            }

            materialProgressBar2.Value = progresoActual;

            Application.DoEvents();

        }

        private void materialProgressBar2_Click(object sender, EventArgs e)
        {

        }
    }
}
