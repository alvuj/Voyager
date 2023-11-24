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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Voyager
{
    public partial class name : Form
    {
        public name()
        {
            InitializeComponent();
        }

        private void confname_Click(object sender, EventArgs e)
        {
            if (txt_ime.Text.Length > 0)
            {
                string FilePath1 = @"path";

                if (!File.Exists(FilePath1))
                {
                    File.Create(FilePath1).Close();
                    TextWriter pisiime = new StreamWriter(FilePath1);
                    pisiime.WriteLine(txt_ime.Text);
                    pisiime.Close();
                }



                else if (File.Exists(FilePath1))
                {
                    using (var writename = new StreamWriter(FilePath1, true))
                    {
                        writename.WriteLine(txt_ime.Text);
                    }
                }


                Login.Visible = true;
                confname.Visible = false;
                label1.Visible = false;
            }
            else
            {
                label1.Visible = true;
            }

            
        }   
        

    private void Login_Click(object sender, EventArgs e)
        {
            
            this.Close();
            Form1 gameWindow = new Form1();
            gameWindow.Show();
            
        }

        private void btnGoBack_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        
        System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
        private void name_Load(object sender, EventArgs e)
        {
            timer.Interval = 30000;
            timer.Tick += new EventHandler(timer_tick);
            timer.Start();
        }

        void timer_tick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_ime_TextChanged(object sender, EventArgs e)
        {

        }
    }
    
}
