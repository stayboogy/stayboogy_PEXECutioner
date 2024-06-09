using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RunBarPE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmd_Click(object sender, EventArgs e)
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

        private void taskmgr_Click(object sender, EventArgs e)
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

        private void regedit_Click(object sender, EventArgs e)
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

        private void notepad_Click(object sender, EventArgs e)
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

        private void bootice_Click(object sender, EventArgs e)
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

        private void gimagex_Click(object sender, EventArgs e)
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

        private void ghost_Click(object sender, EventArgs e)
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

        private void ghostexp_Click(object sender, EventArgs e)
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

        private void qdir_Click(object sender, EventArgs e)
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

        private void finder_Click(object sender, EventArgs e)
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

        private void fastcopy_Click(object sender, EventArgs e)
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

        private void zip_Click(object sender, EventArgs e)
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

        private void nsudo_Click(object sender, EventArgs e)
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

        private void reboot_Click(object sender, EventArgs e)
        {
            System.Diagnostics.ProcessStartInfo rebootP = new System.Diagnostics.ProcessStartInfo();
            rebootP.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            rebootP.FileName = "wpeutil.exe";
            rebootP.Arguments = "Reboot";
            System.Diagnostics.Process.Start(rebootP);
        }

        private void shutdown_Click(object sender, EventArgs e)
        {
            System.Diagnostics.ProcessStartInfo shutdownP = new System.Diagnostics.ProcessStartInfo();
            shutdownP.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            shutdownP.FileName = "wpeutil.exe";
            shutdownP.Arguments = "Shutdown";
            System.Diagnostics.Process.Start(shutdownP);
        }

        private void partassist_Click(object sender, EventArgs e)
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

        private void datarec_Click(object sender, EventArgs e)
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

        private void veracrypt_Click(object sender, EventArgs e)
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

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
