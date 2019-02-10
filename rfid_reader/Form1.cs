using System;
using System.Windows.Forms;
using engine;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace rfid_reader
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private async void run()
        {
            Start st = new Start();
            var task1 = Task<List<List<string>>>.Run(() => st.start_loop());
            var rfid_list = await task1;

            dataGridView1.Rows.Add(rfid_list[0][0]);
        }
    }
}
