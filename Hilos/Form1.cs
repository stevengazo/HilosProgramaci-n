namespace Hilos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region Propiedades


        /// <summary>
        /// Arreglo contenedor de los items que se van a usar
        /// </summary>
        short[] Numeros = new short[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
        /// <summary>
        /// Lista para Guardar los resultados 
        /// </summary>
        public List<double> ListaPares = new List<double>();
        /// <summary>
        /// Lista para guardar los resultados de los numeros impares
        /// </summary>
        public List<decimal> ListaImpares = new List<decimal>();
        /// <summary>
        /// Cuenta la cantidad de hilos usados
        /// </summary>
        int CantidadHilos = 0;
        private Thread HiloImpar;
        private Thread HiloPar;
        #endregion

        #region Metodos

        /// <summary>
        /// Calcula la potencia y pone a dormir el hilo 1000 miliseconds
        /// </summary>
        /// <param name="numero">Número a calcular</param>
        double Potencia(int numero)
        {
            double s = Math.Pow(numero, 2);
            return s;

        }
        /// <summary>
        /// Ejecución de logica basica cuando se ejecuta el boton Ejecutar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEjecutar_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridViewNumeros.Columns.Add("ColumnNumeros", "Numeros");
                for (int i = 0; i < Numeros.Length; i++)
                {
                    int NumeroAEvaluar = Numeros[i];
                    dataGridViewNumeros.Rows.Add(NumeroAEvaluar.ToString());
                    txtNumero.Text = NumeroAEvaluar.ToString();
                    if (NumeroAEvaluar % 2 == 0)
                    {
                        txtTipo.Text = "Par";
                        // Calcular Potencia

                        // Declaraci[on de hilo


                        Thread threadPar = new Thread(new ThreadStart(() =>
                        {
                            lock (this)
                            {
                                ListaPares.Add(Potencia(NumeroAEvaluar));
                            }
                        }));
                        threadPar.Start();
                    }
                    else
                    {
                        txtTipo.Text = "Impar";
                        // Calcular Factorial

                        // Declaraci[on de hilo
                        Thread threadImpar = new Thread(new ThreadStart(() =>
                        {
                            lock (this)
                            {
                                ListaImpares.Add(Factorial(NumeroAEvaluar));
                            }
                        }));
                        threadImpar.Start();
                    }
                }
            }
            catch (InvalidOperationException f)
            {
                MessageBox.Show(f.InnerException.ToString(), f.Message, MessageBoxButtons.OK);
            }
            catch (Exception f)
            {
                MessageBox.Show(f.InnerException.ToString(), f.Message, MessageBoxButtons.OK);
            }
            finally
            {
                CargaGridViewsPar();
                CargaGridViewsImpar();
            }

        }

        /// <summary>
        /// Carga la información de las listas en los dos GridViews para par e impar
        /// </summary>
        private void CargaGridViewsImpar()
        {
            dataGridViewImpares.Columns.Add("colPares", "Impares");
            foreach (var item in ListaImpares)
            {
                dataGridViewImpares.Rows.Add(item.ToString());
            }
        }
        /// <summary>
        /// Carga la información de las listas en los dos GridViews para par e impar
        /// </summary>
        private void CargaGridViewsPar()
        {
            dataGridViewPares.Columns.Add("colPares", "Pares");

            foreach (var item in ListaPares)
            {
                dataGridViewPares.Rows.Add(item);
            }
        }
        /// <summary>
        /// Limpia la pantalla
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        /// <summary>
        /// Cierra el programa
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// Calcula el numero factorial
        /// </summary>
        /// <param name="num">Numero a calcular</param>
        /// <returns>retorno del dato</returns>
        public decimal Factorial(int num)
        {
            decimal d = 1;
            for (int i = 1; i <= num; i++)
            {
                d = d * (i);
            }
            return d;
        }
        #endregion
    }

}