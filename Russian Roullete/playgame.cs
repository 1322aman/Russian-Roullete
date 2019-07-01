using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Russian_Roullete
{
    public partial class playgame : Form
    {
        public playgame()
        {
            InitializeComponent();
        }
        master masterobj = new master();
        Random random = new Random();

        private void button_load_Click(object sender, EventArgs e)
        {
            button_spin.Enabled = true;//enables the spin button
            button_load.Enabled = false;//enables the load button
            //gif player
            imagegifplayer.Image = Image.FromFile(@"C:\Users\sukhd\Desktop\Russian Roullete\media\load.gif");
        }

        private void button_spin_Click(object sender, EventArgs e)
        {
            masterobj.Gunspin = random.Next(1, 6);
            button_shoot.Enabled = true;// enables the shoot button
            button_spin.Enabled = false;// enables the load button
            //gifplayer

            
        }

        private void button_shoot_Click(object sender, EventArgs e)
        {
            imagegifplayer.Image = Image.FromFile(@"C:\Users\sukhd\Desktop\Russian Roullete\media\shoot.gif");
            //gifplayer
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"C:\Users\sukhd\Desktop\Russian Roullete\media\shoot.wav");
            player.Play();
            int shootaway = masterobj.Shootbullete();
            if (shootaway == 1)//it is a if statement runs only if 
            {
                MessageBox.Show("Shoot hits you loose");
                button_shoot.Enabled = false;
                button_shootaway.Enabled = false;
                button_spin.Enabled = false;
                button_load.Enabled = false;

            }
            if (shootaway == 2)//it is a if statement runs only if
            {
                

                masterobj.Totalbullets = masterobj.Totalbullets - 1;
                masterobj.Gunspin = masterobj.BulleteChange(masterobj.Gunspin);
                MessageBox.Show("Shoot missed");
            }

        }

        private void button_shootaway_Click(object sender, EventArgs e)
        {
            int winloss= masterobj.Shootaway();
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"C:\Users\sukhd\Desktop\Russian Roullete\media\shoot.wav");

            if (winloss == 10)//it is a if statement runs only if
            {
                
                MessageBox.Show("Shoot you win socre 100");
                button_shoot.Enabled = false;
                button_shootaway.Enabled = false;
                button_spin.Enabled = false;
                button_load.Enabled = false;

            }
            if (winloss == 5)//it is a if statement runs only if
            {
                MessageBox.Show("Shoot you win socre 100");
                button_shoot.Enabled = false;
                button_shootaway.Enabled = false;
                button_spin.Enabled = false;
                button_load.Enabled = false;
            }
            if (winloss == 0)//it is a if statement runs only if
            {

                MessageBox.Show("Shoot miss");
            }
            if (masterobj.Totalbullets == 0)//it is a if statement runs only if
            {

                MessageBox.Show("no chances left");
                button_shootaway.Enabled = false;


            }
        }


        private void button_playagain_Click(object sender, EventArgs e)
        {
            (new playgame()).Show();//relodes the form
            this.Hide();
        }
    }
}
