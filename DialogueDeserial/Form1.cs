using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace DialogueDeserial
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var path = System.IO.Path.Combine(Environment.CurrentDirectory, "Dialogue.json");
            var data = File.ReadAllText(path);
            DialogueNode node = new DialogueNode();
            var dialogueTree = JsonConvert.DeserializeObject<DialogueTree>(data);
            dataGridView1.ScrollBars = ScrollBars.Both;
            //dataGridView1.Rows[0].Cells[0] = data[0]
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
