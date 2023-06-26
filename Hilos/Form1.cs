using System.Diagnostics;

namespace Hilos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        short[] Numeros = new short[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
        public List<double> ListaPares = new List<double>();
        public List<double> ListaImpares = new List<double>();
        int CantidadHilos = 0;


        void Potencia(int numero)
        {
            double Resultado = Math.Pow(numero, 2);
            ListaPares.Add(Resultado);
            CantidadHilos = Process.GetCurrentProcess().Threads.Count;
            Thread.Sleep(1000);
        }




        private void btnEjecutar_Click(object sender, EventArgs e)
        {
            Thread HiloPar = new Thread(() => { });
            dataGridViewNumeros.Columns.Add("ColumnNumeros", "Numeros");

            for (int i = 0; i < Numeros.Length; i++)
            {
                int NumeroAEvaluar = Numeros[i];
                dataGridViewNumeros.Rows.Add(NumeroAEvaluar.ToString());
                txtNumero.Text = NumeroAEvaluar.ToString();
                if (NumeroAEvaluar % 2 == 0)
                {
                    txtTipo.Text = "Par";
                    txtNumeroHilo.Text = CantidadHilos.ToString();
                    // Calcular Potencia
                    HiloPar = new Thread(new ThreadStart(() =>
                    {
                        Potencia(i); 
                    }));
                    HiloPar.Start();
                }
                else
                {
                    txtTipo.Text = "Impar";
                    // Calcular Factorial
                    Thread hilo = new Thread(new ThreadStart(() =>
                    {
                        double Numero = NumeroAEvaluar!;
                        ListaImpares.Add(NumeroAEvaluar);
                        Thread.Sleep(100);
                    }));
                    hilo.Start();
                   // hilo.Join();

                }
            }
            HiloPar.Join();
            CargaGridViews();
        }


        private void CargaGridViews()
        {

            

            dataGridViewPares.Columns.Add("colPares", "Pares");
            dataGridViewImpares.Columns.Add("colImpares", "Impares");


            foreach (var item in ListaPares)
            {
                dataGridViewPares.Rows.Add(item);
            }
            foreach (var item in ListaPares)
            {
                dataGridViewImpares.Rows.Add(item);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            ListaImpares.Clear();
            ListaPares.Clear();
            txtNumero.Text = string.Empty;
            txtNumeroHilo.Text = string.Empty;
            dataGridViewImpares.Columns.Clear();
            dataGridViewPares.Columns.Clear();
            dataGridViewNumeros.Columns.Clear();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}