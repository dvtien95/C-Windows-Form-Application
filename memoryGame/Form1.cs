// Tien Dinh - CSCI3037 - 001 - Simple Memory Game

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace memoryGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        byte times = 0;
        byte remains = 8;
        PictureBox prevPicture;

        // Flip back to default picture
        void resetPicture()
        {
            foreach (Control i in this.Controls)
            {
                if (i is PictureBox)
                {
                    (i as PictureBox).Image = Properties.Resources._0;
                }
            }
        }

        // Tag default picture
        void tagPicture()
        {
            foreach (Control i in this.Controls)
            {
                if (i is PictureBox)
                {
                    (i as PictureBox).Tag = "0";
                }
            }
        }

        // Tag different pictures
        void tagDigit()
        {
            int[] num = new int[16];
            Random randNum = new Random();

            byte i = 0;
            while (i < 16)
            {
                int k = randNum.Next(1, 17);
                if (Array.IndexOf(num, k)==-1)
                {
                    num[i] = k;
                    i++;
                }
            }

            for (byte a = 0; a < 16; a++)
            {
                if (num[a] > 8)
                    num[a] -= 8;
            }

            byte b = 0;

            foreach (Control j in this.Controls)
            {
                if (j is PictureBox)
                {
                    j.Tag = num[b].ToString();
                    b++;
                }
            }
        }

        // Compare 2 pictures
        void comparePicture (PictureBox prev, PictureBox cur)
        {
            // IF match, sleep a second, then set them to invisible
            if (prev.Tag.ToString() == cur.Tag.ToString())
            {
                Application.DoEvents();
                System.Threading.Thread.Sleep(800);
                prev.Visible = false;
                cur.Visible = false;
                
                remains--;
                if (remains == 0)
                    label1.Text = "Finished";
                else
                    label1.Text = "Pair left = " + remains;

            }
            // If not match, sleep a second, then reset to default picture
            else
            {
                Application.DoEvents();
                System.Threading.Thread.Sleep(800);
                prev.Image = Image.FromFile("0.png");
                cur.Image = Image.FromFile("0.png");                
            }
                
        }

        // Define for each time clicking the button
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            PictureBox curPicture = (sender as PictureBox);
            (sender as PictureBox).Image = Image.FromFile((sender as PictureBox).Tag.ToString() + ".png");

            if (times == 0)
            {
                prevPicture = curPicture;
                times++;
            }
            else
            {
                if(prevPicture == curPicture)
                {
                    MessageBox.Show("Please click other pictures");
                    times = 0;
                    prevPicture.Image = Image.FromFile("0.png");
                }
                else
                {
                    comparePicture(prevPicture, curPicture);
                    times = 0;

                }
            }
        }

        // Main
        private void Form1_Load(object sender, EventArgs e)
        {
            resetPicture();
            tagPicture();
            tagDigit();
        }

    }
}
