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
using System.Xml.Linq;

namespace Voyager
{
    public partial class Form1 : Form
    {

        bool goUp, goDown, shot, gameOver;
        
        CoreData cd1 = new CoreData(0, 8, 10,7,0);

        Random random = new Random();

        //int playerSpeed = 7;
        //int index = 0;
        

        public Form1()
        {
            InitializeComponent();
            //HighScore();// mozda netreba
            lbl_value.Text = Properties.Settings.Default.h_score;
        }

        private void MainTimerEvent(object sender, EventArgs e)
        {
            txtScore.Text = "" + cd1.score; //obrisat mozda

            if (goUp == true && player.Top > 0)
            {
                player.Top -= cd1.playerSpeed;
            }
            if (goDown == true && player.Top + player.Height < this.ClientSize.Height)
            {
                player.Top += cd1.playerSpeed;
            }

            ufo.Left -= cd1.UFOspeed;

            if (ufo.Left + ufo.Width < 0)
            {
                ChangeUFO();
            }


            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "pillar")
                {
                    x.Left -= cd1.speed;
                    if (x.Left < -200)
                    {
                        x.Left = 1000; // ako je dvjesto nlaijeveo gura ga 100 naprijed
                    }
                    if (player.Bounds.IntersectsWith(x.Bounds))
                    {
                        GameOver();
                    }
                }
                if (x is PictureBox && (string)x.Tag == "bullet")
                {
                    x.Left += 25;//kad ga nadje gura ga desno
                    if (x.Left > 550) //koliko daleko ide bulet
                    {
                        RemoveBullet(((PictureBox)x));
                    }
                    if (ufo.Bounds.IntersectsWith(x.Bounds))
                    {
                        RemoveBullet(((PictureBox)x));
                        cd1.score += 1;
                        ChangeUFO();
                    }
                }
            }

            if (player.Bounds.IntersectsWith(ufo.Bounds))
            {
                GameOver();

            }
            if (cd1.score > 4)
            {
                cd1.speed = 12;
                cd1.UFOspeed = 18;
            }
            int a = Int32.Parse(lbl_value.Text);
            if (cd1.score >= a)
            {
                WriteHsEND();
                lbl_value.Text = cd1.score.ToString();

                Properties.Settings.Default.h_score = lbl_value.Text;
                Properties.Settings.Default.Save();
            }
        }

        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {

                goUp = true;
            }
            if (e.KeyCode == Keys.Down)
            {

                goDown = true;
            }

            if (e.KeyCode == Keys.Space && shot == false)//provjera booleana
            {

                MakeBullet();
                shot = true;
            }

        }


        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {

                goUp = false;
            }
            if (e.KeyCode == Keys.Down)
            {

                goDown = false;
            }

            if (shot == true)
            {

                shot = false;
            }

            if (e.KeyCode == Keys.Enter && gameOver == true)
            {   
                ///RestartGame();
                name window = new name();
                window.Show();
                this.Close();
            }
            if (e.KeyCode == Keys.Escape)
            {   if (gameOver == false)
                {
                    GameOver();
                }
                    
                this.Close();
            }
            if (e.KeyCode == Keys.L /*&& gameOver == true*/)
            {
                Properties.Settings.Default.h_score = "0";
                lbl_value.Text = "0";
                Properties.Settings.Default.Save();
            }

        }
        private void RestartGame()
        {
            goUp = false;
            goDown = false;
            shot = false;
            gameOver = false;
            cd1.score = 0;
            cd1.speed = 8;
            cd1.UFOspeed = 10;

            txtScore.Text = "" + cd1.score;

            ChangeUFO();
            player.Top = 200;
            pillar1.Left = 2033; // mijenja pocetne polzoaje pillara
            pillar2.Left = 332;

            GameTimer.Start();
           // HighScore(); // ne treba ako se ide preko systema
        }
        
        private void WriteHs()
        {
            string FilePath1 = @"C:\Users\AV\Desktop\rez\rez.txt";

            if (!File.Exists(FilePath1))
            {
                File.Create(FilePath1).Close();
                
                TextWriter pisiime = new StreamWriter(FilePath1);
                pisiime.WriteLine(txtScore.Text);
                pisiime.Close();
            }



            else if (File.Exists(FilePath1))
            {
                using (var writename = new StreamWriter(FilePath1, true))
                {
                    writename.WriteLine(txtScore.Text);
                }
            }
        }

        private void WriteHsEND()
        {
            string FilePath1 = @"C:\Users\AV\Desktop\rez\highscore.txt";

            if (!File.Exists(FilePath1))
            {
                File.Create(FilePath1).Close();

                TextWriter pisiime = new StreamWriter(FilePath1);
                pisiime.WriteLine(lbl_value.Text);
                pisiime.Close();
            }
            else if (File.Exists(FilePath1))
            {

                using (StreamWriter w = new StreamWriter((FilePath1), false))
                {
                        w.WriteLine(lbl_value.Text);
                        w.Close();
                }

            }
        }

        private void GameOver()
        {
            WriteHs();
            GameTimer.Stop();
            gameOver = true;
            lbl_try.Visible = true;
            
            
            int a = Int32.Parse(lbl_value.Text);
             if (cd1.score >= a)
             {
                
                 lbl_value.Text = cd1.score.ToString();

                 Properties.Settings.Default.h_score = lbl_value.Text;
                 Properties.Settings.Default.Save();
                 WriteHsEND();


            }
             
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {

        }



        private void RemoveBullet(PictureBox bullet)
        {
            this.Controls.Remove(bullet);
            bullet.Dispose();
        }

        private void MakeBullet()
        {
            PictureBox bullet = new PictureBox();
            bullet.BackColor = Color.Red;
            bullet.Height = 5;
            bullet.Width = 10;

            bullet.Left = player.Left + player.Width; // kombinira lijevu i desnu stranu da bude sdnesno na centru
            bullet.Top = player.Top + player.Height / 2; //da bude u centru, računa visinu i polozaj od topa

            bullet.Tag = "bullet"; // preko ovog identificiramo bukket u timeru

            this.Controls.Add(bullet); // ova funkcija stvara bullet
        }

        private void ChangeUFO()
        {
            if (cd1.index > 3)
            {
                cd1.index = 1;
            }
            else
            {
                cd1.index += 1;
            }

            switch(cd1.index)
            {
                case 1:
                    ufo.Image = Properties.Resources.pic1;
                        break;
                case 2:
                    ufo.Image = Properties.Resources.pic2;
                    break;
                case 3:
                    ufo.Image = Properties.Resources.pic3;
                    break;

            }
            ufo.Left = 1000;

            ufo.Top = random.Next(20, this.ClientSize.Height - ufo.Height);
        }
    }
}
