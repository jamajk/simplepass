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
        /// when the user clicks the magic button, not much to explain here tho
        /// displays the password and changes button text
        /// </summary>
        private void Button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = generator(Decimal.ToInt32(numericUpDown1.Value));
            Clipboard.SetText(textBox1.Text);
            label2.Text = "The password has been copied to your clipboard.";
            button1.Text = "Generate New";
            /*wait(3000);*/ // as below, definetely not worth it
            
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
            label2.Text = ""; //moved here from Button1_click for conveinience and bug-avoidance
        }

        private void Label2_Click(object sender, EventArgs e)
        { }



/* fuck it though
 * its creating a really bad bug where the app runs in the background forever if its closed before the timer runs out
 * definetely not worth it
 * keeping for future reference
 
        /// <summary>
        /// a timer, copied in its entirety off fucking stackoverflow lmao (works though)
        /// </summary>
        public void wait(int milliseconds)
        {
            System.Windows.Forms.Timer timer1 = new System.Windows.Forms.Timer();
            if (milliseconds == 0 || milliseconds < 0) return;
            timer1.Interval = milliseconds;
            timer1.Enabled = true;
            timer1.Start();
            timer1.Tick += (s, e) =>
            {
                timer1.Enabled = false;
                timer1.Stop();
            };
            while (timer1.Enabled)
            {
                Application.DoEvents(); //i read that this is bad practice (as probably most of this program) but works for this simple cause
            }
        } */
    }
    
 
}
