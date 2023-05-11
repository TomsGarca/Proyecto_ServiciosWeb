using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cliente
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void valUser(object sender, EventArgs e)
        {
            Button clicked = (Button)sender;
            bool auth = false;

            using (var ClienteUsuario = new FormUser())
            {
                //ClienteUsuario.Dato = clicked.Name;
                DialogResult result = ClienteUsuario.ShowDialog();
                auth = ClienteUsuario.ReturnValue;
                if (auth)
                {

                    MessageBox.Show("Bienvenido", "Status");
                    // Hacer algo con el valor de retorno
                    if (clicked.Name == "getList" || clicked.Name == "getDetalles" )
                    {
                        using (var ClienteGet = new Formget())
                        {
                            ClienteGet.Dato = clicked.Name;
                            ClienteGet.User = ClienteUsuario.User;
                            ClienteGet.Password = ClienteUsuario.Password;
                            DialogResult result1 = ClienteGet.ShowDialog();
                        }
                    }
                    else if (clicked.Name == "insertProd" || clicked.Name == "updateP")
                    {
                        using(var ClienteP = new FormP())
                        {
                            ClienteP.Dato = clicked.Name;
                            ClienteP.User = ClienteUsuario.User;
                            ClienteP.Password = ClienteUsuario.Password;
                            DialogResult result1 = ClienteP.ShowDialog();
                        }
                    }
                    else if (clicked.Name == "deleteP")
                    {
                        using (var ClienteP = new FormDel())
                        {
                            ClienteP.Dato = clicked.Name;
                            ClienteP.User = ClienteUsuario.User;
                            ClienteP.Password = ClienteUsuario.Password;
                            DialogResult result1 = ClienteP.ShowDialog();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrectos", "Status");
                    // Hacer algo con el valor de retorno
                }
            }

            //FormUser ClienteUsuario = new FormUser();

            //ClienteUsuario.Dato = clicked.Name;
            //ClienteUsuario.ShowDialog();
        }
    }
}
