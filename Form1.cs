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

namespace passgen
{
    public partial class Gen : Form
    {
        public Gen()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        { }


        private void TextBox1_TextChanged(object sender, EventArgs e)
        { }

        /// <summary>
        /// displays the password and changes button text
        /// </summary>
        private void Button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = generator(Decimal.ToInt32(numericUpDown1.Value));
            Clipboard.SetText(textBox1.Text);
            label2.Text = "The password has been copied to your clipboard.";
            button1.Text = "Generate New";
        }

        /// <summary>
        /// generates a random string of a given length
        /// </summary>
        private String generator(int len)
        {
            Random rand = new Random();
            int letter;
            StringBuilder pass = new StringBuilder("", len);
            for (int i = 0; i < len; i++)
            {
                letter = 33 + rand.Next(94);
                pass.Append((char)letter);
            }
            return pass.ToString();
        }

        private void Label1_Click(object sender, EventArgs e)
        { }

        private void NumericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            label2.Text = "";
        }

        private void Label2_Click(object sender, EventArgs e)
        { }
    }
    
 
}
