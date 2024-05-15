using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyecto3
{
    public partial class sistema : Form
    {
        double primero; //Creasión las variables
        double segundo;
        double resultado;
        string operacion;
        double sueldo = 0;

        public sistema()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            lblFecha.Text = DateTime.Today.Date.ToString("d");
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void brnRegistrar_Click(object sender, EventArgs e)
        {
            //Capturamos los valores
            string empleado = txtEmpleado.Text;
            string categoria = cbCategoria.Text;

            //Calculos
            double descuento = 0;
            if (sueldo > 2000) descuento = sueldo * (12.5 / 100);

            double neto = sueldo = descuento;

            //Aqui implimimos los resultados que seran vistos en la interfas grafica al momento de ejecutarlo
            ListViewItem fila = new ListViewItem(empleado);
            fila.SubItems.Add(categoria);
            fila.SubItems.Add(sueldo.ToString("C"));
            fila.SubItems.Add(descuento.ToString("C"));
            fila.SubItems.Add(neto.ToString("C"));
            IvPagos.Items.Add(fila);

         
        }

        private void cbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Capturando la categoria 
            string categoria = cbCategoria.Text;

            //Asignamos el sueldo a cada categoria o departamento
            if (categoria == "jefe") sueldo = 3500;
            if(categoria == "Administrador") sueldo = 2500;
            if(categoria == "Tecnico") sueldo = 1700;
           
            if (categoria == "Contador") sueldo = 1000;

            //Enviando el suedo obtenido a implimirse en pantalla
            lblSueldo.Text = sueldo.ToString("C");
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            cbCategoria.Text = "(Seleccion)";
            txtEmpleado.Clear();
            txtEmpleado.Focus();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("ESTA SEGURO DE SALIR? :( ", "pago", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (r == DialogResult.Yes) this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("C:/Program Files/Microsoft Office/root/Office16/WINWORD.EXE", "");
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("C:/Program Files/Microsoft Office/root/Office16/EXCEL.EXE", "");
        }

        private void hora_Tick(object sender, EventArgs e)
        {
            lblhora.Text = DateTime.Now.ToLongTimeString();
        }

        private void brnEliminar_Click(object sender, EventArgs e)
        {
           
            
            
        }
        //Aqui comienza todo relacionado con la calculadora
        private void btncero_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + "0"; 
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + "9";
        }

        private void btnpunto_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + ".";
        }

        private void btnsuma_Click(object sender, EventArgs e)
        {
            operacion = "+";
            primero = double.Parse(Pantalla.Text);
            Pantalla.Clear();
        }

        private void btnresta_Click(object sender, EventArgs e)
        {
            operacion = "-";
            primero = double.Parse(Pantalla.Text);
            Pantalla.Clear();
        }

        private void btnmultiplicasion_Click(object sender, EventArgs e)
        {
            operacion = "*";
            primero = double.Parse(Pantalla.Text);
            Pantalla.Clear();
        }

        private void btndivision_Click(object sender, EventArgs e)
        {
            operacion = "/";
            primero = double.Parse(Pantalla.Text);
            Pantalla.Clear();
        }

        private void btnigual_Click(object sender, EventArgs e)
        {
            segundo = double.Parse(Pantalla.Text);
            //El switch evalua una variable y ase determinadas operaciones
            switch (operacion) {
                case "+":    //En estos case tenemos la posibilidad de poder calcular y que nos saque los resultados 
                    resultado = primero + segundo;
                    Pantalla.Text = resultado.ToString();
                    break;

                case "-":
                    resultado = primero - segundo;
                    Pantalla.Text = resultado.ToString();
                    break;

                case "*":
                    resultado = primero * segundo;
                    Pantalla.Text = resultado.ToString();
                    break;

                case "/":
                    resultado = primero / segundo;
                    Pantalla.Text = resultado.ToString();
                    break;
            }
             
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Pantalla.Clear();
        }

        private void btnRaiz_Click(object sender, EventArgs e)
        {
            operacion = "Raiz";
            primero = double.Parse(Pantalla.Text);
            resultado = primero;
            Pantalla.Text = Math.Sqrt(primero).ToString();
        }


        //Aqui asemos el pequeño bloc de notas
        private void button1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            sistema nuevo = new sistema();
            nuevo.Show();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            String ruta = "";
            openFileDialog1.Filter = "archivos de texto |*.txt";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                ruta = openFileDialog1.FileName;
                textBox1.Text = File.ReadAllText(ruta);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String ruta = "", contenido = "";
            saveFileDialog1.Filter = "TIPO TXT|*.txt";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                ruta = saveFileDialog1.FileName;
                contenido = textBox1.Text;
                File.WriteAllText(ruta, contenido); //Se crea un archivo de extención de .txt
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            Form formulario = new imprimirdatos();
            formulario.Show();
        }

        private void printDocument1_PrintPage_1(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            
        }
    }
}
