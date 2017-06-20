using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Windows.Forms;

namespace EventManager
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            textBox2.UseSystemPasswordChar = true;
            textBox2.PasswordChar = '.';
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://eventsmanager.ru");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                //setup login data
                var username = textBox1.Text;
                var password = textBox2.Text;
                var formContent = new FormUrlEncodedContent(new[]
                {
                     new KeyValuePair<string, string>("grant_type", "password"),
                     new KeyValuePair<string, string>("username", username),
                     new KeyValuePair<string, string>("password", password),
                });
                //send request
                HttpResponseMessage responseMessage = await client.PostAsync("/api/users/loginuser", formContent);

                //get access token from response body
                var responseJson = await responseMessage.Content.ReadAsStringAsync();
                var jObject = JObject.Parse(responseJson);
                Program.auth_key = jObject.GetValue("auth_key").ToString();
                if (Program.auth_key == "error")
                {
                    MessageBox.Show("Логин или пароль неверны");
                    textBox1.Text = "";
                    textBox2.Text = "";
                }
                else
                {
                    Hide();
                    using (Events events = new Events())
                    {
                        events.ShowDialog();
                    }
                    Close();
                }              
            }            
        }
    }
}
