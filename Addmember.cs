using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Windows.Forms;

namespace EventManager
{
    public partial class Addmember : Form
    {
        public Addmember()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {            
            using (var client = new HttpClient())
            {                
                client.BaseAddress = new Uri("http://eventsmanager.ru");
                var content = new FormUrlEncodedContent(new[]
                {
                    new KeyValuePair<string, string>("username", textBox9.Text),
                    new KeyValuePair<string, string>("password", textBox10.Text),
                    new KeyValuePair<string, string>("firstname_rus", textBox1.Text),
                    new KeyValuePair<string, string>("firstname_eng", textBox2.Text),
                    new KeyValuePair<string, string>("lastname_rus", textBox3.Text),
                    new KeyValuePair<string, string>("lastname_eng", textBox4.Text),
                    new KeyValuePair<string, string>("company", textBox5.Text),
                    new KeyValuePair<string, string>("country", textBox6.Text),
                    new KeyValuePair<string, string>("city", textBox7.Text),
                    new KeyValuePair<string, string>("mail", textBox8.Text)
                });
                var result = await client.PostAsync("/apiusers", content);
                string resultContent = await result.Content.ReadAsStringAsync();
               //  MessageBox.Show(resultContent);
            }
            Close();
        }
    }
}
