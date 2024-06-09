namespace RunBarPE
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.cmd = new System.Windows.Forms.Button();
            this.taskmgr = new System.Windows.Forms.Button();
            this.regedit = new System.Windows.Forms.Button();
            this.notepad = new System.Windows.Forms.Button();
            this.bootice = new System.Windows.Forms.Button();
            this.gimagex = new System.Windows.Forms.Button();
            this.qdir = new System.Windows.Forms.Button();
            this.finder = new System.Windows.Forms.Button();
            this.fastcopy = new System.Windows.Forms.Button();
            this.zip = new System.Windows.Forms.Button();
            this.nsudo = new System.Windows.Forms.Button();
            this.shutdown = new System.Windows.Forms.Button();
            this.reboot = new System.Windows.Forms.Button();
            this.partassist = new System.Windows.Forms.Button();
            this.datarec = new System.Windows.Forms.Button();
            this.ghost = new System.Windows.Forms.Button();
            this.ghostexp = new System.Windows.Forms.Button();
            this.veracrypt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmd
            // 
            this.cmd.Location = new System.Drawing.Point(94, 19);
            this.cmd.Name = "cmd";
            this.cmd.Size = new System.Drawing.Size(75, 23);
            this.cmd.TabIndex = 0;
            this.cmd.Text = this.cmd.Text = System.Configuration.ConfigurationManager.AppSettings["button2_title"];
            this.cmd.UseVisualStyleBackColor = true;
            this.cmd.Click += new System.EventHandler(this.cmd_Click);
            this.cmd.Visible = (@System.Configuration.ConfigurationManager.AppSettings["button2"] != null);

            // 
            // taskmgr
            // 
            this.taskmgr.Location = new System.Drawing.Point(12, 19);
            this.taskmgr.Name = "taskmgr";
            this.taskmgr.Size = new System.Drawing.Size(75, 23);
            this.taskmgr.TabIndex = 1;
            this.taskmgr.Text = this.taskmgr.Text = System.Configuration.ConfigurationManager.AppSettings["button1_title"];
            this.taskmgr.UseVisualStyleBackColor = true;
            this.taskmgr.Click += new System.EventHandler(this.taskmgr_Click);
            this.taskmgr.Visible = (@System.Configuration.ConfigurationManager.AppSettings["button1"] != null);
            // 
            // regedit
            // 
            this.regedit.Location = new System.Drawing.Point(12, 48);
            this.regedit.Name = "regedit";
            this.regedit.Size = new System.Drawing.Size(75, 23);
            this.regedit.TabIndex = 2;
            this.regedit.Text = System.Configuration.ConfigurationManager.AppSettings["button3_title"];
            this.regedit.UseVisualStyleBackColor = true;
            this.regedit.Click += new System.EventHandler(this.regedit_Click);
            this.regedit.Visible = (@System.Configuration.ConfigurationManager.AppSettings["button3"] != null);
            // 
            // notepad
            // 
            this.notepad.Location = new System.Drawing.Point(94, 48);
            this.notepad.Name = "notepad";
            this.notepad.Size = new System.Drawing.Size(75, 23);
            this.notepad.TabIndex = 3;
            this.notepad.Text = System.Configuration.ConfigurationManager.AppSettings["button4_title"];
            this.notepad.UseVisualStyleBackColor = true;
            this.notepad.Click += new System.EventHandler(this.notepad_Click);
            this.notepad.Visible = (@System.Configuration.ConfigurationManager.AppSettings["button4"] != null);
            // 
            // bootice
            // 
            this.bootice.Location = new System.Drawing.Point(12, 106);
            this.bootice.Name = "bootice";
            this.bootice.Size = new System.Drawing.Size(75, 23);
            this.bootice.TabIndex = 4;
            this.bootice.Text = System.Configuration.ConfigurationManager.AppSettings["button7_title"];
            this.bootice.UseVisualStyleBackColor = true;
            this.bootice.Click += new System.EventHandler(this.bootice_Click);
            this.bootice.Visible = (@System.Configuration.ConfigurationManager.AppSettings["button7"] != null);
            // 
            // gimagex
            // 
            this.gimagex.Location = new System.Drawing.Point(12, 77);
            this.gimagex.Name = "gimagex";
            this.gimagex.Size = new System.Drawing.Size(75, 23);
            this.gimagex.TabIndex = 5;
            this.gimagex.Text = System.Configuration.ConfigurationManager.AppSettings["button5_title"];
            this.gimagex.UseVisualStyleBackColor = true;
            this.gimagex.Click += new System.EventHandler(this.gimagex_Click);
            this.gimagex.Visible = (@System.Configuration.ConfigurationManager.AppSettings["button5"] != null);
            // 
            // qdir
            // 
            this.qdir.Location = new System.Drawing.Point(12, 164);
            this.qdir.Name = "qdir";
            this.qdir.Size = new System.Drawing.Size(75, 23);
            this.qdir.TabIndex = 6;
            this.qdir.Text = System.Configuration.ConfigurationManager.AppSettings["button11_title"];
            this.qdir.UseVisualStyleBackColor = true;
            this.qdir.Click += new System.EventHandler(this.qdir_Click);
            this.qdir.Visible = (@System.Configuration.ConfigurationManager.AppSettings["button11"] != null);
            // 
            // finder
            // 
            this.finder.Location = new System.Drawing.Point(94, 193);
            this.finder.Name = "finder";
            this.finder.Size = new System.Drawing.Size(75, 23);
            this.finder.TabIndex = 7;
            this.finder.Text = System.Configuration.ConfigurationManager.AppSettings["button14_title"];
            this.finder.UseVisualStyleBackColor = true;
            this.finder.Click += new System.EventHandler(this.finder_Click);
            this.finder.Visible = (@System.Configuration.ConfigurationManager.AppSettings["button14"] != null);
            // 
            // fastcopy
            // 
            this.fastcopy.Location = new System.Drawing.Point(94, 164);
            this.fastcopy.Name = "fastcopy";
            this.fastcopy.Size = new System.Drawing.Size(75, 23);
            this.fastcopy.TabIndex = 8;
            this.fastcopy.Text = System.Configuration.ConfigurationManager.AppSettings["button12_title"];
            this.fastcopy.UseVisualStyleBackColor = true;
            this.fastcopy.Click += new System.EventHandler(this.fastcopy_Click);
            this.fastcopy.Visible = (@System.Configuration.ConfigurationManager.AppSettings["button12"] != null);
            // 
            // zip
            // 
            this.zip.Location = new System.Drawing.Point(94, 135);
            this.zip.Name = "zip";
            this.zip.Size = new System.Drawing.Size(75, 23);
            this.zip.TabIndex = 9;
            this.zip.Text = System.Configuration.ConfigurationManager.AppSettings["button10_title"];
            this.zip.UseVisualStyleBackColor = true;
            this.zip.Click += new System.EventHandler(this.zip_Click);
            this.zip.Visible = (@System.Configuration.ConfigurationManager.AppSettings["button10"] != null);
            // 
            // nsudo
            // 
            this.nsudo.Location = new System.Drawing.Point(12, 193);
            this.nsudo.Name = "nsudo";
            this.nsudo.Size = new System.Drawing.Size(75, 23);
            this.nsudo.TabIndex = 10;
            this.nsudo.Text = System.Configuration.ConfigurationManager.AppSettings["button13_title"];
            this.nsudo.UseVisualStyleBackColor = true;
            this.nsudo.Click += new System.EventHandler(this.nsudo_Click);
            this.nsudo.Visible = (@System.Configuration.ConfigurationManager.AppSettings["button13"] != null);
            // 
            // shutdown
            // 
            this.shutdown.Location = new System.Drawing.Point(94, 251);
            this.shutdown.Name = "shutdown";
            this.shutdown.Size = new System.Drawing.Size(75, 23);
            this.shutdown.TabIndex = 11;
            this.shutdown.Text = "HALT";
            this.shutdown.UseVisualStyleBackColor = true;
            this.shutdown.Click += new System.EventHandler(this.shutdown_Click);
            // 
            // reboot
            // 
            this.reboot.Location = new System.Drawing.Point(12, 251);
            this.reboot.Name = "reboot";
            this.reboot.Size = new System.Drawing.Size(75, 23);
            this.reboot.TabIndex = 12;
            this.reboot.Text = "REBOOT";
            this.reboot.UseVisualStyleBackColor = true;
            this.reboot.Click += new System.EventHandler(this.reboot_Click);
            // 
            // partassist
            // 
            this.partassist.Location = new System.Drawing.Point(12, 222);
            this.partassist.Name = "partassist";
            this.partassist.Size = new System.Drawing.Size(75, 23);
            this.partassist.TabIndex = 13;
            this.partassist.Text = System.Configuration.ConfigurationManager.AppSettings["button15_title"];
            this.partassist.UseVisualStyleBackColor = true;
            this.partassist.Click += new System.EventHandler(this.partassist_Click);
            this.partassist.Visible = (@System.Configuration.ConfigurationManager.AppSettings["button15"] != null);
            // 
            // datarec
            // 
            this.datarec.Location = new System.Drawing.Point(94, 222);
            this.datarec.Name = "datarec";
            this.datarec.Size = new System.Drawing.Size(75, 23);
            this.datarec.TabIndex = 14;
            this.datarec.Text = System.Configuration.ConfigurationManager.AppSettings["button16_title"];
            this.datarec.UseVisualStyleBackColor = true;
            this.datarec.Click += new System.EventHandler(this.datarec_Click);
            this.datarec.Visible = (@System.Configuration.ConfigurationManager.AppSettings["button16"] != null);
            // 
            // ghost
            // 
            this.ghost.Location = new System.Drawing.Point(94, 77);
            this.ghost.Name = "ghost";
            this.ghost.Size = new System.Drawing.Size(75, 23);
            this.ghost.TabIndex = 15;
            this.ghost.Text = System.Configuration.ConfigurationManager.AppSettings["button6_title"];
            this.ghost.UseVisualStyleBackColor = true;
            this.ghost.Click += new System.EventHandler(this.ghost_Click);
            this.ghost.Visible = (@System.Configuration.ConfigurationManager.AppSettings["button6"] != null);
            // 
            // ghostexp
            // 
            this.ghostexp.Location = new System.Drawing.Point(94, 106);
            this.ghostexp.Name = "ghostexp";
            this.ghostexp.Size = new System.Drawing.Size(75, 23);
            this.ghostexp.TabIndex = 16;
            this.ghostexp.Text = System.Configuration.ConfigurationManager.AppSettings["button8_title"];
            this.ghostexp.UseVisualStyleBackColor = true;
            this.ghostexp.Click += new System.EventHandler(this.ghostexp_Click);
            this.ghostexp.Visible = (@System.Configuration.ConfigurationManager.AppSettings["button8"] != null);
            // 
            // veracrypt
            // 
            this.veracrypt.Location = new System.Drawing.Point(12, 135);
            this.veracrypt.Name = "veracrypt";
            this.veracrypt.Size = new System.Drawing.Size(75, 23);
            this.veracrypt.TabIndex = 17;
            this.veracrypt.Text = System.Configuration.ConfigurationManager.AppSettings["button9_title"];
            this.veracrypt.UseVisualStyleBackColor = true;
            this.veracrypt.Click += new System.EventHandler(this.veracrypt_Click);
            this.veracrypt.Visible = (@System.Configuration.ConfigurationManager.AppSettings["button9"] != null);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(181, 292);
            this.Controls.Add(this.veracrypt);
            this.Controls.Add(this.ghostexp);
            this.Controls.Add(this.ghost);
            this.Controls.Add(this.datarec);
            this.Controls.Add(this.partassist);
            this.Controls.Add(this.reboot);
            this.Controls.Add(this.shutdown);
            this.Controls.Add(this.nsudo);
            this.Controls.Add(this.zip);
            this.Controls.Add(this.fastcopy);
            this.Controls.Add(this.finder);
            this.Controls.Add(this.qdir);
            this.Controls.Add(this.gimagex);
            this.Controls.Add(this.bootice);
            this.Controls.Add(this.notepad);
            this.Controls.Add(this.regedit);
            this.Controls.Add(this.taskmgr);
            this.Controls.Add(this.cmd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "RunBarPE by stayboogy";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmd;
        private System.Windows.Forms.Button taskmgr;
        private System.Windows.Forms.Button regedit;
        private System.Windows.Forms.Button notepad;
        private System.Windows.Forms.Button bootice;
        private System.Windows.Forms.Button gimagex;
        private System.Windows.Forms.Button qdir;
        private System.Windows.Forms.Button finder;
        private System.Windows.Forms.Button fastcopy;
        private System.Windows.Forms.Button zip;
        private System.Windows.Forms.Button nsudo;
        private System.Windows.Forms.Button shutdown;
        private System.Windows.Forms.Button reboot;
        private System.Windows.Forms.Button partassist;
        private System.Windows.Forms.Button datarec;
        private System.Windows.Forms.Button ghost;
        private System.Windows.Forms.Button ghostexp;
        private System.Windows.Forms.Button veracrypt;
    }
}

