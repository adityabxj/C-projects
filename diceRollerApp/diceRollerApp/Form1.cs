using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace diceRollerApp
{
    public partial class Form1 : Form
    {
        Random dice = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int randomNum1 = dice.Next(1, 7);
            int randomNum2 = dice.Next(1, 7);

            switch (randomNum1)
            {
                case 1:
                    pictureBox1.ImageLocation = @"C:\Users\adity\Dropbox\PC\Downloads\Dice1.png"; //String Literal
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    break; 
                case 2:
                    pictureBox1.ImageLocation = @"C:\Users\adity\Dropbox\PC\Downloads\Dice2.png"; //String Literal
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 3:
                    pictureBox1.ImageLocation = @"C:\Users\adity\Dropbox\PC\Downloads\Dice3.png"; //String Literal
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 4:
                    pictureBox1.ImageLocation = @"C:\Users\adity\Dropbox\PC\Downloads\Dice4.png"; //String Literal
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 5:
                    pictureBox1.ImageLocation = @"C:\Users\adity\Dropbox\PC\Downloads\Dice5.png"; //String Literal
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 6:
                    pictureBox1.ImageLocation = @"C:\Users\adity\Dropbox\PC\Downloads\Dice6.png"; //String Literal
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                default:
                    pictureBox1.ImageLocation = @"C:\Users\adity\Dropbox\PC\Downloads\Dice1.png"; //String Literal
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
            }

            switch (randomNum2)
            {
                case 1:
                    pictureBox2.ImageLocation = @"C:\Users\adity\Dropbox\PC\Downloads\Dice1.png"; //String Literal
                    pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 2:
                    pictureBox2.ImageLocation = @"C:\Users\adity\Dropbox\PC\Downloads\Dice2.png"; //String Literal
                    pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 3:
                    pictureBox2.ImageLocation = @"C:\Users\adity\Dropbox\PC\Downloads\Dice3.png"; //String Literal
                    pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 4:
                    pictureBox2.ImageLocation = @"C:\Users\adity\Dropbox\PC\Downloads\Dice4.png"; //String Literal
                    pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 5:
                    pictureBox2.ImageLocation = @"C:\Users\adity\Dropbox\PC\Downloads\Dice5.png"; //String Literal
                    pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 6:
                    pictureBox2.ImageLocation = @"C:\Users\adity\Dropbox\PC\Downloads\Dice6.png"; //String Literal
                    pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                default:
                    pictureBox2.ImageLocation = @"C:\Users\adity\Dropbox\PC\Downloads\Dice1.png"; //String Literal
                    pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
            }
        }
    }

}
