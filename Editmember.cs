using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Windows.Forms;

namespace EventManager
{
    public partial class Editmember : Form
    {
        public string firstname_rus
        {
            get { return textBox1.Text; }
            set { textBox1.Text = value; }
        }

        public string firstname_eng
        {
            get { return textBox2.Text; }
            set { textBox2.Text = value; }
        }

        public string lastname_rus
        {
            get { return textBox3.Text; }
            set { textBox3.Text = value; }
        }

        public string lastname_eng
        {
            get { return textBox4.Text; }
            set { textBox4.Text = value; }
        }

        public string company
        {
            get { return textBox5.Text; }
            set { textBox5.Text = value; }
        }

        public string country
        {
            get { return textBox6.Text; }
            set { textBox6.Text = value; }
        }

        public string city
        {
            get { return textBox7.Text; }
            set { textBox7.Text = value; }
        }

        public string mail
        {
            get { return textBox8.Text; }
            set { textBox8.Text = value; }
        }   
        
        public string id
        {
            get { return textBox9.Text; }
            set { textBox9.Text = value; }
        }

        public string username
        {
            get { return textBox10.Text; }
            set { textBox10.Text = value; }
        }

        /*public string password
        {
            get { return textBox11.Text; }
            set { textBox11.Text = value; }
        }*/

        /*public string badges
        {
            get { return textBox12.Text; }
            set { textBox12.Text = value; }
        }*/


        public Editmember()
        {
            InitializeComponent();
        }

        private void Editmember_Load(object sender, EventArgs e)
        {            
            
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://eventsmanager.ru");
                var content = new FormUrlEncodedContent(new[]
                {
                    new KeyValuePair<string, string>("username", textBox10.Text),
                    //new KeyValuePair<string, string>("password", textBox11.Text),
                    new KeyValuePair<string, string>("firstname_rus", textBox1.Text),
                    new KeyValuePair<string, string>("firstname_eng", textBox2.Text),
                    new KeyValuePair<string, string>("lastname_rus", textBox3.Text),
                    new KeyValuePair<string, string>("lastname_eng", textBox4.Text),
                    new KeyValuePair<string, string>("company", textBox5.Text),
                    new KeyValuePair<string, string>("country", textBox6.Text),
                    new KeyValuePair<string, string>("city", textBox7.Text),
                    new KeyValuePair<string, string>("mail", textBox8.Text),
                    //new KeyValuePair<string, string>("Badges", textBox12.Text)
                });
                var result = await client.PutAsync("/api/users/"+textBox9.Text, content);
                string resultContent = await result.Content.ReadAsStringAsync();
            }            
            Close();
            using (Main main = new Main())
            {
                main.xmlupd();
            }
        }
    }
}
