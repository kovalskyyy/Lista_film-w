using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lista_filmów
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

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void usuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach(ListViewItem item in listView1.SelectedItems)
            {
                listView1.Items.Remove(item);  
            }
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] row = { textBox1.Text, textBox2.Text, dateTimePicker1.Text, textBox3.Text };
            var listViewItem = new ListViewItem(row);
            listView1.Items.Add(listViewItem);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBoxButtons btns = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show("Czy zapisać dane?");
            if (result == DialogResult.Yes) 
            { 

            }
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string[] linie = new string[listView1.Items.Count];
            int i = 0;
            foreach(ListViewItem item in listView1.Items)
            {
                linie[i] = "";
                for(int k = 0; k < item.SubItems.Count; k++)
                    linie[i] += item.SubItems[k].Text + "*";
                i++;
            }
            string path = @"S:\Nowy folder\Lista_filmów\text.txt";
            File.WriteAllLines(path, linie);

        }
        
    }
}
