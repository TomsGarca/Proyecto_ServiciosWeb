using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cliente
{
    public partial class Formget : Form
    {
        public Formget()
        {
            InitializeComponent();
        }

        public string Dato { get; internal set; }
        public string User { get; internal set; }
        public string Password { get; internal set; }
        public List<Control> dynamicControls = new List<Control>();


        private void Formget_Load(object sender, EventArgs e)
        {
            if (Dato == "getList")
            {
                this.label1.Text = "Categoria";
                this.Text = "getList";
            }
            else if (Dato == "getDetalles")
            {
                this.label1.Text = "ISBN";
                this.Text = "getDetalles";
            }

            if (this.User == "pruebas1")
            {
                this.Text += " CLIENTE - Usuario: Ventas";
                this.FormBorderStyle = FormBorderStyle.FixedSingle;
                Color miColorAzul = Color.FromArgb(0, 131, 212);
                this.BackColor = miColorAzul;

            }
            else if (this.User == "pruebas2")
            {
                this.Text += " CLIENTE - Usuario: Almacen";

                this.FormBorderStyle = FormBorderStyle.FixedSingle;
                this.BackColor = Color.MediumPurple;
            }
        }


        private async void action_ClickAsync(object sender, EventArgs e)
        {
            foreach(var control in dynamicControls)
            {
                this.Controls.Remove(control); // elimina el control de la ventana
            }
            dynamicControls.Clear();
            String item = this.textBox1.Text;
            String url = "";

            if (this.Dato == "getList")
            {
                url = "http://localhost/ServiciosWeb/miniProyecto/productos/" + item;
            }
            else if(this.Dato == "getDetalles")
            {
                url = "http://localhost/ServiciosWeb/miniProyecto/detalles/" + item;
            }

            //this.richTextBox1.Text = "Cargando...\n\n";
            this.textBoxStatus2.Text = "Cargando...";
            this.Controls.Add(this.labelStatus);
            //this.richTextBox1.Text += "USUARIO: " + this.User + "\n";
            using (HttpClient client = new HttpClient())
            {
                HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, url);
                request.Headers.Add("user", this.User);
                request.Headers.Add("password", this.Password);

                HttpResponseMessage response = await client.SendAsync(request);
                response.EnsureSuccessStatusCode();
                var message = await response.Content.ReadAsStringAsync();
                //string responseBody = await response.Content.ReadAsStringAsync();
                //this.richTextBox1.Text += message;
                JObject json = JObject.Parse(message);
                int code = (int)json["code"];
                String status = (String)json["status"];
                String mess = (String)json["message"];
                var data = "";
                try
                {
                    data = (String)json["data"];
                    if (data == null)
                    {
                        if (this.Dato == "getList")
                        {
                            status = "error";
                            code = 300;
                            mess = "Categoria no encontrada.";
                        }
                        else if (this.Dato == "getDetalles")
                        {
                            status = "error";
                            code = 301;
                            mess = "ISBN no encontrado.";

                        }
                    }
                }
                catch{                }
                this.textBoxStatus2.Text = status;
                this.textBoxCode2.Text = code.ToString();
                this.textBoxMessage2.Text = mess;

                if (code != 300 && code != 301 && mess != null)
                {
                    JObject jsonData = (JObject)json["data"];
                    //JObject jsonData = JObject.Parse(data);

                    int i = 0;
                    foreach (var index in jsonData)
                    {
                        TextBox txtIndice = new TextBox();
                        txtIndice.Location = new System.Drawing.Point(90, 220 +  i);
                        txtIndice.Size = new System.Drawing.Size(60, 26);
                        txtIndice.Text = index.Key;
                        txtIndice.ReadOnly = true;
                        this.Controls.Add(txtIndice);
                        dynamicControls.Add(txtIndice);

                        TextBox txtValor = new TextBox();   
                        txtValor.Location = new System.Drawing.Point(180, 220 + i);
                        txtValor.Size = new System.Drawing.Size(140, 26);
                        txtValor.Text = index.Value.ToString(); 
                        txtValor.ReadOnly = true;
                        this.Controls.Add(txtValor); i = i + 26;
                        dynamicControls.Add(txtValor);
                    }
                }
            }
        }

        private void Formget_FormClosing(object sender, FormClosingEventArgs e)
        {
            foreach(var control in dynamicControls)
            {
                this.Controls.Remove(control); // elimina el control de la ventana
            }
            dynamicControls.Clear(); // limpia la lista
        }
    }
}
