using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.IO;

namespace RussianRoulette
{
    public partial class Form1 : Form
    {
        Gun gunObj = new Gun();
        bool win = false;
        ScoreBoard score = new ScoreBoard();
        SoundPlayer[] player = new SoundPlayer[4];
        public Form1()
        {
            
            InitializeComponent();
            InitializeSound();

        }
        public void InitializeSound()
        {

            string[] sounds = new string[]
            {
                "..\\..\\resources\\Gun+Shot.wav",
                "..\\..\\resources\\Gun+Empty.wav",
                "..\\..\\resources\\Gun+Load.wav",
                "..\\..\\resources\\Gun+Spin.wav"

            };
            for (int i = 0; i < sounds.Length; i++)
            {
                player[i] = new SoundPlayer();
                player[i].SoundLocation = sounds[i];
                player[i].Load();
            }
        }
        public void playSound(int type)
        {
            player[type].Play();

        }

        private void FireButton_Click(object sender, EventArgs e)
        {


            if (PointAwayRB.Checked)
            {
                int res = gunObj.FireAway();

            
                if (res == - 1 )
                {
                    bulletCount.Value = gunObj.ChamberPos;
                    playSound(1); //playing empty gun fire sound
                    LifelineTB.Text = "You have " + gunObj.get_chances() + " chances left!";
                    
                }
                else if(res == 0)
                {
                    bulletCount.Value = gunObj.ChamberPos;
                    playSound(0); //playing gun with bullet fire sound
                    MessageBox.Show("you Lived!");
                    win = true;
                    
                    FireButton.Enabled = false;
                    RestartButton.Enabled = true;
                }
                else
                {
                    PointHeadRB.Checked = true;
                    MessageBox.Show("you dont have any chances left, you are going to die");
                    RestartButton.Enabled = true;
                }

            }
            else
            {
                bool res = gunObj.Fire();
                if (res)
                {
                    playSound(0); //playing gun with bullet fire sound
                    bulletCount.Value = gunObj.ChamberPos;
                    MessageBox.Show("you Died!");
                    FireButton.Enabled = false;
                    RestartButton.Enabled = true;
                }
                else
                {
                    playSound(1); //playing empty gun fire sound
                    bulletCount.Value = gunObj.ChamberPos;
                }

            }

        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
            playSound(2);
            gunObj.loadBullet();
            LoadButton.Enabled = false;
            SpinButton.Enabled = true;

        }

        private void SpinButton_Click(object sender, EventArgs e)
        {
            playSound(3);
            gunObj.spinChambers();
            SpinButton.Enabled = false;
            FireButton.Enabled = true;
        }

        private void RestartButton_Click(object sender, EventArgs e)
        {
            gunObj.emptyChamber();
            bulletCount.Value = gunObj.ChamberPos;
            LifelineTB.Text = "You have " + gunObj.get_chances() + " chances left!";
            if (win)
            {
                winCount.Text = score.updateWins().ToString();
                win = false;
            }
            else
                lossCount.Text = score.updateLosses().ToString();

            LoadButton.Enabled = true;
            FireButton.Enabled = false;
            RestartButton.Enabled = false;


        }

        private void PointAwayRB_CheckedChanged(object sender, EventArgs e)
        {

            Image flipImage = sGun.Image;
            flipImage.RotateFlip(RotateFlipType.RotateNoneFlipX);
            sGun.Image = flipImage;
        }
    }
}
