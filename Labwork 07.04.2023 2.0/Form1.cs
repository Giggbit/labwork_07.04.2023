using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Labwork_07._04._2023_2._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            List<string> info = new List<string> {
                textBox1.Text,
                textBox2.Text,
                textBox3.Text,
                maskedTextBox1.Text
            };

            int index = listBox1.FindStringExact(textBox1.Text, -1);
            if (index != -1) {
                MessageBox.Show("Ошибка");
            }
            else {
                 for (int i = 0; i < info.Count; i++) {
                    listBox1.Items.Add(info[i]);
                 }
            }
        }
    }
}
