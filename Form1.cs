using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;

namespace PEXECutioner
{

    public partial class PEXECutioner : Form
    {
        public PEXECutioner()
        {
            InitializeComponent();
        }

        private void PEXECutioner_Load(object sender, EventArgs e)
        {

            // kill wallpaperhost.exe all the time
            // this makes RunBar a better shell when hosting its own wallpaper
            // this also corrects file system and display refresh for all instances
            // could place back to first if statement below, but I like this better
            // just do the damn thing
            System.Diagnostics.Process[] localByName = System.Diagnostics.Process.GetProcessesByName("wallpaperhost");
            foreach (System.Diagnostics.Process p in localByName)
            {
                p.Kill();
            }

            // if this app.config key is "yes" we use a Fixed Tool Window that is Moveable with transparent background [DEFAULT]
            if ((@System.Configuration.ConfigurationManager.AppSettings["moveable"] == "yes"))
            {
                this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;

                // if this app.config key is "no" then the Fixed Tool Window is transparent [DEAULT]
                if ((@System.Configuration.ConfigurationManager.AppSettings["transparent"] == "no"))
                {
                    // if window is moveable but not transpaprent and there is a color set in the backcolor app.config key
                    // we have that color as our background
                    if ((System.Configuration.ConfigurationManager.AppSettings["backcolor"] != ""))
                    {
                        Color backColor = Color.FromName(@System.Configuration.ConfigurationManager.AppSettings["backcolor"]);
                        this.BackColor = backColor;
                    }
                    else
                    {
                        // otherwise we use the ControlDark Color as our [DEFAULT] background color
                        this.BackColor = System.Drawing.SystemColors.ControlDark;
                    }
                }
            }
            else
            {
                // otherwise buttons are floating and fixed in location
                // with a black non-existant background since wallpaperhost.exe has been killed when the form loaded
                this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            }
      
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (@System.Configuration.ConfigurationManager.AppSettings["button1"] != null)
            {
                System.Diagnostics.Process.Start(@System.Configuration.ConfigurationManager.AppSettings["button1"]);
            }
            else
            {
                ;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (@System.Configuration.ConfigurationManager.AppSettings["button2"] != null)
            {
                System.Diagnostics.Process.Start(@System.Configuration.ConfigurationManager.AppSettings["button2"]);
            }
            else
            {
                ;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (@System.Configuration.ConfigurationManager.AppSettings["button3"] != null)
            {
                System.Diagnostics.Process.Start(@System.Configuration.ConfigurationManager.AppSettings["button3"]);
            }
            else
            {
                ;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (@System.Configuration.ConfigurationManager.AppSettings["button4"] != null)
            {
                System.Diagnostics.Process.Start(@System.Configuration.ConfigurationManager.AppSettings["button4"]);
            }
            else
            {
                ;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (@System.Configuration.ConfigurationManager.AppSettings["button5"] != null)
            {
                System.Diagnostics.Process.Start(@System.Configuration.ConfigurationManager.AppSettings["button5"]);
            }
            else
            {
                ;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (@System.Configuration.ConfigurationManager.AppSettings["button6"] != null)
            {
                System.Diagnostics.Process.Start(@System.Configuration.ConfigurationManager.AppSettings["button6"]);
            }
            else
            {
                ;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (@System.Configuration.ConfigurationManager.AppSettings["button7"] != null)
            {
                System.Diagnostics.Process.Start(@System.Configuration.ConfigurationManager.AppSettings["button7"]);
            }
            else
            {
                ;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (@System.Configuration.ConfigurationManager.AppSettings["button8"] != null)
            {
                System.Diagnostics.Process.Start(@System.Configuration.ConfigurationManager.AppSettings["button8"]);
            }
            else
            {
                ;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (@System.Configuration.ConfigurationManager.AppSettings["button9"] != null)
            {
                System.Diagnostics.Process.Start(@System.Configuration.ConfigurationManager.AppSettings["button9"]);
            }
            else
            {
                ;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (@System.Configuration.ConfigurationManager.AppSettings["button10"] != null)
            {
                System.Diagnostics.Process.Start(@System.Configuration.ConfigurationManager.AppSettings["button10"]);
            }
            else
            {
                ;
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (@System.Configuration.ConfigurationManager.AppSettings["button11"] != null)
            {
                System.Diagnostics.Process.Start(@System.Configuration.ConfigurationManager.AppSettings["button11"]);
            }
            else
            {
                ;
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (@System.Configuration.ConfigurationManager.AppSettings["button12"] != null)
            {
                System.Diagnostics.Process.Start(@System.Configuration.ConfigurationManager.AppSettings["button12"]);
            }
            else
            {
                ;
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (@System.Configuration.ConfigurationManager.AppSettings["button13"] != null)
            {
                System.Diagnostics.Process.Start(@System.Configuration.ConfigurationManager.AppSettings["button13"]);
            }
            else
            {
                ;
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (@System.Configuration.ConfigurationManager.AppSettings["button14"] != null)
            {
                System.Diagnostics.Process.Start(@System.Configuration.ConfigurationManager.AppSettings["button14"]);
            }
            else
            {
                ;
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (@System.Configuration.ConfigurationManager.AppSettings["button15"] != null)
            {
                System.Diagnostics.Process.Start(@System.Configuration.ConfigurationManager.AppSettings["button15"]);
            }
            else
            {
                ;
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (@System.Configuration.ConfigurationManager.AppSettings["button16"] != null)
            {
                System.Diagnostics.Process.Start(@System.Configuration.ConfigurationManager.AppSettings["button16"]);
            }
            else
            {
                ;
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (@System.Configuration.ConfigurationManager.AppSettings["button17"] != null)
            {
                System.Diagnostics.Process.Start(@System.Configuration.ConfigurationManager.AppSettings["button17"]);
            }
            else
            {
                ;
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (@System.Configuration.ConfigurationManager.AppSettings["button18"] != null)
            {
                System.Diagnostics.Process.Start(@System.Configuration.ConfigurationManager.AppSettings["button18"]);
            }
            else
            {
                ;
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            System.Diagnostics.ProcessStartInfo rebootP = new System.Diagnostics.ProcessStartInfo();
            rebootP.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            rebootP.FileName = "wpeutil.exe";
            rebootP.Arguments = "Reboot";
            System.Diagnostics.Process.Start(rebootP);
        }

        private void button20_Click(object sender, EventArgs e)
        {
            System.Diagnostics.ProcessStartInfo shutdownP = new System.Diagnostics.ProcessStartInfo();
            shutdownP.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            shutdownP.FileName = "wpeutil.exe";
            shutdownP.Arguments = "Shutdown";
            System.Diagnostics.Process.Start(shutdownP);
        }

    }
}
