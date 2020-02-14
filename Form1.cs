using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKreni_Click(object sender, EventArgs e)
        {
            label4.Text = "Igra: " + txtX.Text;
            Ocisti();
        }
        
        private void Ocisti()
        {
            foreach (Control c in this.Controls)
            {
                if (c.GetType() == typeof(TextBox) && c.Name != "txtX" && c.Name != "txtY")
                {
                    c.Text = "";
                }
            }
        }

        bool x = true;

        private void textBox1_Click(object sender, EventArgs e)
        {
            //if(((TextBox)sender).Text != "")
            //{
            //    MessageBox.Show("Polje je već odabrano!");
            //}
            //else
            //{
            //    if(x == true)
            //    {
            //        ((TextBox)sender).Text = "X";
            //        label4.Text = "Igra: " + txtY.Text;
            //    }
            //    else
            //    {
            //        ((TextBox)sender).Text = "O";
            //        label4.Text = "Igra: " + txtX.Text;
            //    }
            //}

            //x = !x;
            //Provjera();
        }

       private void Provjera()
        {
            if (textBox1.Text == "X" && textBox2.Text == "X" && textBox3.Text == "X")
            {
                MessageBox.Show("Pobjedio je: " + txtX.Text);
            }
            if (textBox4.Text == "X" && textBox5.Text == "X" && textBox6.Text == "X")
            {
                MessageBox.Show("Pobjedio je: " + txtX.Text);
            }
            if (textBox7.Text == "X" && textBox8.Text == "X" && textBox9.Text == "X")
            {
                MessageBox.Show("Pobjedio je: " + txtX.Text);
            }

            if (textBox1.Text == "O" && textBox2.Text == "O" && textBox2.Text == "O")
            {
                MessageBox.Show("Pobjedio je: " + txtY.Text);
            }
            if (textBox4.Text == "O" && textBox5.Text == "O" && textBox6.Text == "O")
            {
                MessageBox.Show("Pobjedio je: " + txtY.Text);
            }
            if (textBox7.Text == "O" && textBox8.Text == "O" && textBox9.Text == "O")
            {
                MessageBox.Show("Pobjedio je: " + txtY.Text);
            }

            if (textBox1.Text == "X" && textBox4.Text == "X" && textBox7.Text == "X")
            {
                MessageBox.Show("Pobjedio je: " + txtX.Text);
            }
            if (textBox2.Text == "X" && textBox5.Text == "X" && textBox8.Text == "X")
            {
                MessageBox.Show("Pobjedio je: " + txtX.Text);
            }
            if (textBox3.Text == "X" && textBox6.Text == "X" && textBox9.Text == "X")
            {
                MessageBox.Show("Pobjedio je: " + txtX.Text);
            }

            if (textBox1.Text == "O" && textBox4.Text == "O" && textBox7.Text == "O")
            {
                MessageBox.Show("Pobjedio je: " + txtY.Text);
            }
            if (textBox2.Text == "O" && textBox5.Text == "O" && textBox8.Text == "O")
            {
                MessageBox.Show("Pobjedio je: " + txtY.Text);
            }
            if (textBox3.Text == "O" && textBox6.Text == "O" && textBox9.Text == "O")
            {
                MessageBox.Show("Pobjedio je: " + txtY.Text);
            }

            if (textBox3.Text == "O" && textBox5.Text == "O" && textBox7.Text == "O")
            {
                MessageBox.Show("Pobjedio je: " + txtY.Text);
            }

            if (textBox1.Text == "O" && textBox5.Text == "O" && textBox9.Text == "O")
            {
                MessageBox.Show("Pobjedio je: " + txtY.Text);
            }

            if (textBox3.Text == "X" && textBox5.Text == "X" && textBox7.Text == "X")
            {
                MessageBox.Show("Pobjedio je: " + txtX.Text);
            }

            if (textBox1.Text == "X" && textBox5.Text == "X" && textBox9.Text == "X")
            {
                MessageBox.Show("Pobjedio je: " + txtX.Text);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (Control c in this.Controls)
            {
                if ((c as TextBox) != null)
                {
                    (c as TextBox).Click += Form1_Click;
                }
            }
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            if (((TextBox)sender).Text != "")
            {
                MessageBox.Show("Polje je već odabrano!");
            }
            else
            {
                if (x == true)
                {
                    ((TextBox)sender).Text = "X";
                    label4.Text = "Igra: " + txtY.Text;
                }
                else
                {
                    ((TextBox)sender).Text = "O";
                    label4.Text = "Igra: " + txtX.Text;
                }
            }

            x = !x;
            Provjera();
        }
    }
}
