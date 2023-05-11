using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace Cliente
{
    public partial class FormP : Form
    {
        public FormP()
        {
            InitializeComponent();
        }
        public string Dato { get; internal set; }
        public string User { get; internal set; }
        public string Password { get; internal set; }

        private async void buttonAction_Click(object sender, EventArgs e)
        {
            String categoria = this.textBoxCat.Text;
            String producto = this.textBoxP.Text;
            String url = "";

            //this.richTextBox1.Text = "Cargando...\n\n";
            //this.richTextBox1.Text += "USUARIO: " + this.User + "\n";
            this.textBoxStatus2.Text = "Cargando...";
            if (this.Dato == "insertProd")
            {
                url = "http://localhost/ServiciosWeb/miniProyecto/producto";
                
                using (HttpClient client = new HttpClient())
                {
                    client.DefaultRequestHeaders.Add("user", this.User);
                    client.DefaultRequestHeaders.Add("password", this.Password);

                    var json = new
                    {
                        categoria = categoria,
                        producto = producto
                    };

                    string body = JsonConvert.SerializeObject(json);

                    var content = new StringContent(body, Encoding.UTF8, "application/json");
                    var response = await client.PostAsync(url, content);

                    response.EnsureSuccessStatusCode();

                    string message = await response.Content.ReadAsStringAsync();
                    JObject json2 = JObject.Parse(message);
                    int code = (int)json2["code"];
                    String status = (String)json2["status"];
                    String mess = (String)json2["message"];
                    String date = (String)json2["data"];
                    this.textBoxStatus2.Text = status;
                    this.textBoxCode2.Text = code.ToString();
                    this.textBoxMessage2.Text = mess;

                    this.textBoxData2.Text = date;
                }
            }
            else if (this.Dato == "updateP")
            {
                url = "http://localhost/ServiciosWeb/miniProyecto/producto/" + this.textBoxIsbn;

                using (HttpClient client = new HttpClient())
                {
                    HttpRequestMessage request = new HttpRequestMessage(new HttpMethod("PATCH"), url);
                    request.Headers.Add("user", this.User);
                    request.Headers.Add("password", this.Password);

                    var data = new
                    {
                        categoria = categoria,
                        producto = producto
                    };

                    var json = JsonConvert.SerializeObject(data);
                    request.Content = new StringContent(json, Encoding.UTF8, "application/json");

                    HttpResponseMessage response = await client.SendAsync(request);

                    String message = await response.Content.ReadAsStringAsync();
                    JObject json2 = JObject.Parse(message);
                    int code = (int)json2["code"];
                    String status = (String)json2["status"];
                    String mess = (String)json2["message"];
                    String date = (String)json2["data"];
                    this.textBoxStatus2.Text = status;
                    this.textBoxCode2.Text = code.ToString();
                    this.textBoxMessage2.Text = mess;

                    this.textBoxData2.Text = date;
                }

            }

        }

        private void FormP_Load(object sender, EventArgs e)
        {
            if (Dato == "updateP")
            {
                this.Text = "updateP";
                this.labelIsbn.Location = new System.Drawing.Point(26, 15);
                this.Controls.Add(this.textBoxIsbn);
                this.textBoxIsbn.Location = new System.Drawing.Point(100, 15);
                this.textBoxIsbn.Size = new System.Drawing.Size(200, 26);
                this.Controls.Add(this.labelIsbn);
                this.buttonAction.Text = "UPDATE";
            }
            else if (Dato == "insertProd")
            {
                this.Text = "insertProd";
                if (this.Controls.Contains(this.labelIsbn))
                {
                    this.Controls.Remove(this.labelIsbn);
                }
                if (this.Controls.Contains(this.textBoxIsbn))
                {
                    this.Controls.Remove(this.textBoxIsbn);
                }
                this.buttonAction.Text = "POST";
            }
            
            if (this.User == "pruebas1")
            {
                this.Text += " CLIENTE - Usuario: Ventas";
                this.FormBorderStyle = FormBorderStyle.FixedSingle;
                this.BackColor = Color.YellowGreen;

            }
            else if (this.User == "pruebas2")
            {
                this.Text += " CLIENTE - Usuario: Almacen";

                this.FormBorderStyle = FormBorderStyle.FixedSingle;
                this.BackColor = Color.MediumPurple;
            }
        }
    }
}
