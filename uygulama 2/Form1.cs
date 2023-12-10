using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace uygulama_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Font = new Font(label1.Font.Name, 10); 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float p = label1.Font.Size;
            if(++p==26)
            {
                label1.Font = new Font(label1.Font.Name, 10);
            }
            else
            {
                label1.Font = new Font(label1.Font.Name, p);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            float p = label1.Font.Size;
            if (--p == 9)
            {
                label1.Font = new Font(label1.Font.Name, 10);
            }
            else
            {
                label1.Font = new Font(label1.Font.Name, p);
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            label1.Font=new Font(radioButton1.Text,label1.Font.Size);
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            label1.Font = new Font(radioButton2.Text, label1.Font.Size);
        }
    }
}
