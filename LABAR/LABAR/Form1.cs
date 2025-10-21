using LABAR.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LABAR
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        PictureBox[] p = new PictureBox[4];
        int[] randint = new int[4];

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
       
        
        private void Form1_Load(object sender, EventArgs e)
        {
            p[1] = pictureBox1;
            p[2] = pictureBox2;
            p[3] = pictureBox3;
            pictureBox4.Image = Resources.up;
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;

            for (int i = 1; i <= p.GetUpperBound(0); i++)
            {
                p[i].Image = Resources._0;
                p[i].SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            pictureBox4.Image= Resources.down;
            pictureBox4.SizeMode= PictureBoxSizeMode.StretchImage;
            label2.Text = (int.Parse(label2.Text) - numericUpDown1.Value ).ToString();
            timer1.Enabled = true;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int num = rnd.Next(0,4);
            for (int i = 1; i <= p.GetUpperBound(0); i++)
            {
                randint[i]=rnd.Next(0,4);
                p[i].Image = new Bitmap(randint[i] + ".jpg");
            }
            timer1.Enabled = false;

            if (randint[1] == 0 && randint[2] == 0 && randint[3] == 0)
            {
                MessageBox.Show("恭喜中獎，投注量*5");
                label2.Text = (int.Parse(label2.Text) + numericUpDown1.Value * 5).ToString();

            }
            else if (randint[1] == 1 && randint[2] == 1 && randint[3] == 1)
            {
                MessageBox.Show("恭喜中獎，投注量*10");
                label2.Text = (int.Parse(label2.Text) + numericUpDown1.Value * 10).ToString();

            }
            else if (randint[1] == 2 && randint[2] == 2 && randint[3] == 2)
            {
                MessageBox.Show("恭喜中獎，投注量*15");
                label2.Text = (int.Parse(label2.Text) + numericUpDown1.Value * 15).ToString();

            }
            else if (randint[1] == 3 && randint[2] == 3 && randint[3] == 3)
            {
                MessageBox.Show("恭喜中獎，投注量*20");
                label2.Text = (int.Parse(label2.Text) + numericUpDown1.Value * 20).ToString();

            }
            pictureBox4.Image = Resources.up;
            pictureBox4.SizeMode=PictureBoxSizeMode.StretchImage;
        }

        }
}


