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

namespace Labwork_07._04._2023
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void start_Click(object sender, EventArgs e) {
            
        }

        private void accept_Click(object sender, EventArgs e) {
            FileStream fs = new FileStream(link.Text, FileMode.Open);
            StreamReader sr = new StreamReader(fs);
            MessageBox.Show("File has been found...", "File info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            textBox1.Text = sr.ReadToEnd();
        }
    }
}
