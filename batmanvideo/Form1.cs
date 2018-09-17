using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace batmanvideo
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
            axVLCPlugin21.playlist.play();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string s1 = "";
            foreach (object item in listBox1.Items) s1 += item.ToString() + "\r\n";
            Clipboard.SetText(s1);
        }
        string abc= "<div style=\"background-image:url(pages/";
        string bca = ".jpg)\"></div>" + "\r\n";
        int a=0;
        private void button3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 234;i++)
            {

                listBox1.Items.Add(abc + a.ToString() + bca);
                //textBox1.Text = abc+ a.ToString() +bca +Environment.NewLine;

                a++;
            }


}
    }
}
