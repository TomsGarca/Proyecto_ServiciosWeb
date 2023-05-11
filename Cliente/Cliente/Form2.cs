using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Cliente
{
    public partial class FormUser : Form
    {
        public FormUser()
        {
            InitializeComponent();
        }

        public string Resultado { get; set; }
        public string Dato { get; internal set; }
        public string User { get; internal set; }
        public string Password { get; internal set; }
        public bool ReturnValue { get; internal set; }

        private async void valUser_ClickAsync(object sender, EventArgs e)
        {
            String user = textBoxUser.Text;
            String pass = textBoxPassword.Text;
            String url = "https://serviciosweb-d49c4-default-rtdb.firebaseio.com/usuarios/" + user + ".json";

            HttpClient client = new HttpClient();
            HttpResponseMessage response = await client.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                String responseBody = await response.Content.ReadAsStringAsync();
                if (responseBody == "null")
                {
                    String urlMessage = "https://serviciosweb-d49c4-default-rtdb.firebaseio.com/respuestas/" + 500 + ".json";
                    HttpResponseMessage responseMessage = await client.GetAsync(urlMessage);
                    String message = await responseMessage.Content.ReadAsStringAsync();

                    MessageBox.Show(message, "ERROR code: " + 500);
                    this.Resultado = "Error";
                }
                else
                {
                    String password = '"' + GetMd5Hash(pass) + '"';
                    if (responseBody == password)
                    {
                        this.Resultado = responseBody;
                        this.User = user;
                        this.Password = pass;
                        this.ReturnValue = true;
                        this.Close();
                    }
                    else
                    {
                        String urlMessage = "https://serviciosweb-d49c4-default-rtdb.firebaseio.com/respuestas/" + 501 + ".json";
                        HttpResponseMessage responseMessage = await client.GetAsync(urlMessage);
                        String message = await responseMessage.Content.ReadAsStringAsync();

                        MessageBox.Show(message, "ERROR code: " + 501);
                        this.Resultado = "Error";
                    }
                
                }
            }

        }

        public static string GetMd5Hash(string input)
        {
            using (MD5 md5 = MD5.Create())
            {
                byte[] inputBytes = Encoding.ASCII.GetBytes(input);
                byte[] hashBytes = md5.ComputeHash(inputBytes);

                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    sb.Append(hashBytes[i].ToString("x2"));
                }

                return sb.ToString();
            }
        }
    }
}

