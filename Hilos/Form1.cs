using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;
using System.Windows.Forms;

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
        short[] Numeros = new short[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        /// <summary>
        /// Hilos que se van a utilizar
        public  Thread HiloImpar;
        public Thread HiloPar;
        /// </summary>
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

        /// <summary>
        /// Ejecución de logica basica cuando se ejecuta el boton Ejecutar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEjecutar_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridViewNumeros.Columns.Add("ColumnNumeros", "Números");

                dataGridViewImpares.Columns.Add("colPares", "Impares");
                dataGridViewPares.Columns.Add("colPares", "Pares");
                // Inicializacion del los hilos y pasado como parametro los metos para procesar
                HiloImpar = new Thread(ProcesarImpares);
                HiloPar = new Thread(ProcesarPares);

                HiloPar.IsBackground = true;
                HiloImpar.IsBackground = true;

                /// Inicia los hilos
                HiloImpar.Start();
                HiloPar.Start();

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

            }
        }

        /// <summary>
        /// Carga la información de las listas en los dos GridViews para impar
        /// </summary>
        private void ProcesarImpares()
        {

            try
            {
                // Obtiene el Id del hilo actual (impares)
                string threadID = Thread.CurrentThread.ManagedThreadId.ToString();
                // Recorre la lista
                for (int i = 0; i < Numeros.Length; i++)
                {
                    // obtenemos el numero
                    int NumeroAEvaluar = Numeros[i];

                    if (NumeroAEvaluar % 2 != 0)
                    {
                        // Invocamos una nueva acción en el datagrid, y añadimos el numero
                        dataGridViewNumeros.Invoke(new Action(() => dataGridViewNumeros.Rows.Add(NumeroAEvaluar.ToString())));
                        /// Invocamos una nueva acción en el datagrid y mostramos el numero
                        txtNumero.Invoke(new Action(() => txtNumero.Text = NumeroAEvaluar.ToString()));
                        /// Invocamos una nueva acción en txtNumeroHilo y mostramos el ID del hilo
                        txtNumeroHilo.Invoke(new Action(() => txtNumeroHilo.Text = threadID));
                        /// invamos una acción en txttipo.tex y seteamos "impar"
                        txtTipo.Invoke(new Action(() => txtTipo.Text = "Impar"));
                        // Obtenemos el factorial del numero en cuestion
                        decimal resultado = Factorial(NumeroAEvaluar);
                        /// invocamos una acción en el datagrid y le añadimos a la fila el resultado
                        dataGridViewImpares.Invoke(new Action(() => dataGridViewImpares.Rows.Add(resultado.ToString())));
                    }
                    // Ponemos el hilo a dormir
                    Thread.Sleep(1000);
                }
            }
            catch (ThreadInterruptedException)
            {

            }
          
        }

        /// <summary>
        /// Carga la información de las listas en los dos GridViews para pares
        /// </summary>
        private void ProcesarPares()
        {
            try
            {
                // Obtiene el Id del hilo actual (impares)
                string threadID = Thread.CurrentThread.ManagedThreadId.ToString();
                /// Recorremos la lisa 
                for (int i = 0; i < Numeros.Length; i++)
                {
                    int NumeroAEvaluar = Numeros[i];
                    // si el numero es par ejecutar el codigo
                    if (NumeroAEvaluar % 2 == 0)
                    {
                        dataGridViewNumeros.Invoke(new Action(() => dataGridViewNumeros.Rows.Add(NumeroAEvaluar.ToString())));
                        txtNumero.Invoke(new Action(() => txtNumero.Text = NumeroAEvaluar.ToString()));
                        txtTipo.Invoke(new Action(() => txtTipo.Text = "Par"));
                        txtNumeroHilo.Invoke(new Action(() => txtNumeroHilo.Text = threadID));

                        double resultado = Potencia(NumeroAEvaluar);

                        dataGridViewPares.Invoke(new Action(() => dataGridViewPares.Rows.Add(resultado.ToString())));
                    }

                    Thread.Sleep(1000);
                }
            }
            catch (ThreadInterruptedException)
            {
                // hilo  interrumpido por salida
            }
          
        }
        /// <summary>
        /// Limpia la pantalla
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLimpiar_Click(object sender, EventArgs e)
        {

            /// Comprueba si el hilo esta inicializado
            if (HiloPar != null && HiloImpar != null)
            {
                // si el hilo esta vivo lo interrumpe
                if ((HiloPar.IsAlive == true))
                {
                    HiloPar.Interrupt();
                }
                if ((HiloImpar.IsAlive == true))
                {
                    HiloImpar.Interrupt();
                }
            }

            txtNumero.Text = string.Empty;
                txtNumeroHilo.Text = string.Empty;
                txtTipo.Text = string.Empty;
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

            /// Comprueba si el hilo esta inicializado
            if(HiloPar != null  && HiloImpar != null)
            {
                // si el hilo esta vivo lo interrumpe
                if ((HiloPar.IsAlive == true))
                {
                    HiloPar.Interrupt() ;
                }
                if ((HiloImpar.IsAlive == true))
                {
                    HiloImpar.Interrupt();
                }
            }            
            this.Close();       
        }
        #endregion

  
    }
}