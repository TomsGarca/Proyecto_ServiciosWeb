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
    public partial class FormDel : Form
    {
        public FormDel()
        {
            InitializeComponent();
        }
        public string Dato { get; internal set; }
        public string User { get; internal set; }
        public string Password { get; internal set; }

        private async void buttonDel_ClickAsync(object sender, EventArgs e)
        {
            var isbn = this.textBoxDel.Text;

            String url = "";
            this.textBoxStatus3.Text = "Cargando...";

            url = "http://localhost/ServiciosWeb/miniProyecto/product/" + isbn;

            using (HttpClient client = new HttpClient())
            {
                HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Delete, url);

                request.Headers.Add("user", this.User);
                request.Headers.Add("password", this.Password);

                HttpResponseMessage response = await client.SendAsync(request);

                string message = await response.Content.ReadAsStringAsync();
                JObject json2 = JObject.Parse(message);
                int code = (int)json2["code"];
                String status = (String)json2["status"];
                String mess = (String)json2["message"];
                String date = (String)json2["data"];
                this.textBoxStatus3.Text = status;
                this.textBoxCode3.Text = code.ToString();
                this.textBoxMessage3.Text = mess;

                this.textBoxData3.Text = date;
            }
        }

        private void FormDel_Load(object sender, EventArgs e)
        {
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
