namespace Hilos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void btnEjecutar_Click(object sender, EventArgs e)
        {
            // Arreglo de Numeros
            short[] Numeros = new short[] { 1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20};

            dataGridViewNumeros.Columns.Add("ColumnNumeros","Numeros");

           
            for (int i = 0; i < Numeros.Length; i++)
            {                
                int NumeroAEvaluar = Numeros[i];
                dataGridViewNumeros.Rows.Add(NumeroAEvaluar.ToString());
                txtNumero.Text = NumeroAEvaluar.ToString();
                if(NumeroAEvaluar % 2== 0 ) {
                    dataGridViewPares.Columns.Add("colPares", "Pares");
                    txtTipo.Text = "Par";
                    // Calcular Potencia

                    Thread Hilo = new Thread(new ThreadStart(() => {
                        var s = NumeroAEvaluar;
                        var Resultado = Math.Pow(s, 2).ToString();
                        
                        dataGridViewPares.Rows.Add(s);
                    }));
                    Thread.Sleep(100);
                    Hilo.Start();                    
                }
                else
                {
                    txtTipo.Text = "Impar";
                    // Calcular Factorial

                }

            }
        }
    }
}