using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyecto3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string USUARIO = "sistema";
        string CONTRASEÑA = "1234";

        private void btn_Aceptar_Click(object sender, EventArgs e)
        {


           

            string user = txt_Usuario.Text;
            string password = txt_Contraseña.Text;
            if (user.Equals(USUARIO))
            {
                if (password.Equals(CONTRASEÑA))
                {
                    sistema sistema = new sistema();
                    sistema.ShowDialog();
                    MessageBox.Show("ACCESO EXITOSO :3");

                }
                
                    
                        else
                        {
                            MessageBox.Show("LA CONTRASEÑA ES INCORECTA");
                        }
                    }
                    else 
                    {
                        MessageBox.Show("NOSE RECONOCE COMO EL USUARIO");
                    }

                    {

                    }
                }

        private void txt_Contraseña_TextChanged(object sender, EventArgs e)
        {

        }
    }
        }
    

