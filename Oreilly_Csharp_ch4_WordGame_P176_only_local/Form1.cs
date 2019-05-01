using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Oreilly_Csharp_ch4_WordGame_P176_only_local
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Time1_Tick(object sender, EventArgs e)
        {
            //add a random key to the listbox
            listBox1.Items.Add((Keys)random.Next(65, 90));//12312313321321
            if (listBox1.Items.Count >7)
            {
                listBox1.Items.Clear();
                listBox1.Items.Add("Game over");
                Time1.Stop();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
