namespace CalculadoraIPN
{
    public partial class Form1 : Form
    {
        Operaciones operacion = new Operaciones();
        string datoA, datoB, resultado, salida;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btlimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void btab2n_Click(object sender, EventArgs e)
        {
            entradaDatos();
            try {
                salida = operacion.binomioCuadradoNegativo(datoA, datoB, ref resultado);
                
                if(salida != ""){
                    lbResultados.Items.Add(salida);
                }
                else
                {
                    lbResultados.Items.Add("Las entradas son incorrectas");
                }
            }
            catch
            {
                MessageBox.Show("Ocurrio un error inesperado");
            }
        }

        private void btab3P_Click(object sender, EventArgs e)
        {
            entradaDatos();
            try
            {
                salida = operacion.binomioAlCuboPositivo(datoA, datoB, ref resultado);

                if (salida != "")
                {
                    lbResultados.Items.Add(salida);
                }
                else
                {
                    lbResultados.Items.Add("Las entradas son incorrectas");
                }
            }
            catch
            {
                MessageBox.Show("Ocurrio un error inesperado");
            }
        }

        private void btab3N_Click(object sender, EventArgs e)
        {
            entradaDatos();
            try
            {
                salida = operacion.binomioAlCuboNegativo(datoA, datoB, ref resultado);

                if (salida != "")
                {
                    lbResultados.Items.Add(salida);
                }
                else
                {
                    lbResultados.Items.Add("Las entradas son incorrectas");
                }
            }
            catch
            {
                MessageBox.Show("Ocurrio un error inesperado");
            }
        }

        private void bta2b2_Click(object sender, EventArgs e)
        {
            entradaDatos();
            try
            {
                salida = operacion.diferenciaCuadrados(datoA, datoB, ref resultado);

                if (salida != "")
                {
                    lbResultados.Items.Add(salida);
                }
                else
                {
                    lbResultados.Items.Add("Las entradas son incorrectas");
                }
            }
            catch
            {
                MessageBox.Show("Ocurrio un error inesperado");
            }
        }

        private void btab2p_Click(object sender, EventArgs e)
        {
            try
            {
                entradaDatos();
                salida = operacion.binomioCuadradoPositivo(datoA, datoB, ref resultado);
                if (salida != "")
                {
                    lbResultados.Items.Add(salida);
                }
                else
                {
                    lbResultados.Items.Add("Las entradas son incorrectas");
                }
            }
            catch
            {
                MessageBox.Show("Ocurrio un error inesperado");
            }
        }

        public void entradaDatos()
        {
            datoA = tbA.Text;
            datoB = tbB.Text;
        }
        public void limpiar()
        {
            tbA.Clear();
            tbB.Clear();
            //lbResultados.Items.Clear();
        }
    }
}