using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Windows.Forms;

namespace EventManager
{
    public partial class Events : Form
    {        
        private string addE = "http://eventsmanager.ru/api/event/my?auth_key=" + Program.auth_key;

        public EventsList[] eventsList { get; private set; }

        public Events()
        {
            InitializeComponent();

        }

        public class EventsList
        {
            public string id { get; set; }
            public string datetimestart_event { get; set; }
            public string datetimestop_event { get; set; }
            public string name { get; set; }
            public string id_owner { get; set; }
        }

        private void Events_Load(object sender, System.EventArgs e)
        {
            addEv();
            dataGridView1.CurrentRow.Selected = false;
            datetimestarteventDataGridViewTextBoxColumn.HeaderText = "Дата начала";
            datetimestopeventDataGridViewTextBoxColumn.HeaderText = "Дата окончания";
            nameDataGridViewTextBoxColumn.HeaderText = "Название";
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 9F, FontStyle.Bold);
        }

        public void addEv()
        {
            dataGridView1.Rows.Clear();
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(addE);
            client.DefaultRequestHeaders.Accept.Add(
            new MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage response = client.GetAsync("").Result;
            if (response.IsSuccessStatusCode)
            {
                var dataObjects = response.Content.ReadAsAsync<IEnumerable<EventsList>>().Result;
                foreach (var a in dataObjects)
                {
                    eventsListBindingSource.Add(a);
                }
                eventsList = dataObjects.ToArray();
            }
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            using (Main main = new Main())
            {
                Hide();
                main.ShowDialog();                
            }           
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Program.event_id = dataGridView1.SelectedRows[0].Cells["id"].Value + string.Empty;
        }
    }       
}

