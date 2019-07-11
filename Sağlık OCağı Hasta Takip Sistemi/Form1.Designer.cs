namespace Sağlık_OCağı_Hasta_Takip_Sistemi
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
            this.loginpanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.referanslarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.poliklinikTanıtmaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kullanıcıTanıtmaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hastaKabulToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hastaİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.raporlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rapor1geçiciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kullanıcıtanıtma1 = new Sağlık_OCağı_Hasta_Takip_Sistemi.kullanıcıtanıtma();
            this.polikliniktanıtma1 = new Sağlık_OCağı_Hasta_Takip_Sistemi.polikliniktanıtma();
            this.loginpanel.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // loginpanel
            // 
            this.loginpanel.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.loginpanel.Controls.Add(this.label1);
            this.loginpanel.Controls.Add(this.button3);
            this.loginpanel.Controls.Add(this.button2);
            this.loginpanel.Controls.Add(this.button1);
            this.loginpanel.Controls.Add(this.textBox2);
            this.loginpanel.Controls.Add(this.textBox1);
            this.loginpanel.Controls.Add(this.label3);
            this.loginpanel.Controls.Add(this.label2);
            this.loginpanel.Location = new System.Drawing.Point(255, 163);
            this.loginpanel.Name = "loginpanel";
            this.loginpanel.Size = new System.Drawing.Size(288, 163);
            this.loginpanel.TabIndex = 0;
            this.loginpanel.TabStop = true;
            this.loginpanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(-4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(338, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "LOGIN                                              ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button3.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.Location = new System.Drawing.Point(202, 101);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(60, 48);
            this.button3.TabIndex = 5;
            this.button3.Text = "Çıkış";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.ForeColor = System.Drawing.Color.Yellow;
            this.button2.Location = new System.Drawing.Point(87, 102);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(86, 48);
            this.button2.TabIndex = 4;
            this.button2.Text = "Temizle";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.Green;
            this.button1.Location = new System.Drawing.Point(7, 101);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(74, 49);
            this.button1.TabIndex = 3;
            this.button1.Text = "Giriş";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(87, 66);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(198, 20);
            this.textBox2.TabIndex = 2;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(87, 41);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(198, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Şifre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Kullanıcı Adı";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Enabled = false;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.referanslarToolStripMenuItem,
            this.hastaKabulToolStripMenuItem,
            this.raporlarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(859, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // referanslarToolStripMenuItem
            // 
            this.referanslarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logoutToolStripMenuItem,
            this.poliklinikTanıtmaToolStripMenuItem,
            this.kullanıcıTanıtmaToolStripMenuItem,
            this.çıkışToolStripMenuItem});
            this.referanslarToolStripMenuItem.Name = "referanslarToolStripMenuItem";
            this.referanslarToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.referanslarToolStripMenuItem.Text = "Referanslar";
            this.referanslarToolStripMenuItem.Click += new System.EventHandler(this.referanslarToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // poliklinikTanıtmaToolStripMenuItem
            // 
            this.poliklinikTanıtmaToolStripMenuItem.Name = "poliklinikTanıtmaToolStripMenuItem";
            this.poliklinikTanıtmaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.poliklinikTanıtmaToolStripMenuItem.Text = "Poliklinik Tanıtma";
            this.poliklinikTanıtmaToolStripMenuItem.Click += new System.EventHandler(this.poliklinikTanıtmaToolStripMenuItem_Click);
            // 
            // kullanıcıTanıtmaToolStripMenuItem
            // 
            this.kullanıcıTanıtmaToolStripMenuItem.Name = "kullanıcıTanıtmaToolStripMenuItem";
            this.kullanıcıTanıtmaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.kullanıcıTanıtmaToolStripMenuItem.Text = "Kullanıcı Tanıtma";
            this.kullanıcıTanıtmaToolStripMenuItem.Click += new System.EventHandler(this.kullanıcıTanıtmaToolStripMenuItem_Click);
            // 
            // çıkışToolStripMenuItem
            // 
            this.çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            this.çıkışToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.çıkışToolStripMenuItem.Text = "Çıkış";
            // 
            // hastaKabulToolStripMenuItem
            // 
            this.hastaKabulToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hastaİşlemleriToolStripMenuItem});
            this.hastaKabulToolStripMenuItem.Name = "hastaKabulToolStripMenuItem";
            this.hastaKabulToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.hastaKabulToolStripMenuItem.Text = "Hasta Kabul";
            this.hastaKabulToolStripMenuItem.Click += new System.EventHandler(this.hastaKabulToolStripMenuItem_Click);
            // 
            // hastaİşlemleriToolStripMenuItem
            // 
            this.hastaİşlemleriToolStripMenuItem.Name = "hastaİşlemleriToolStripMenuItem";
            this.hastaİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.hastaİşlemleriToolStripMenuItem.Text = "Hasta İşlemleri";
            this.hastaİşlemleriToolStripMenuItem.Click += new System.EventHandler(this.hastaİşlemleriToolStripMenuItem_Click);
            // 
            // raporlarToolStripMenuItem
            // 
            this.raporlarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rapor1geçiciToolStripMenuItem});
            this.raporlarToolStripMenuItem.Name = "raporlarToolStripMenuItem";
            this.raporlarToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.raporlarToolStripMenuItem.Text = "Raporlar";
            // 
            // rapor1geçiciToolStripMenuItem
            // 
            this.rapor1geçiciToolStripMenuItem.Name = "rapor1geçiciToolStripMenuItem";
            this.rapor1geçiciToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.rapor1geçiciToolStripMenuItem.Text = "Rapor 1(geçici)";
            // 
            // kullanıcıtanıtma1
            // 
            this.kullanıcıtanıtma1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.kullanıcıtanıtma1.Location = new System.Drawing.Point(12, 66);
            this.kullanıcıtanıtma1.Name = "kullanıcıtanıtma1";
            this.kullanıcıtanıtma1.Size = new System.Drawing.Size(271, 103);
            this.kullanıcıtanıtma1.TabIndex = 4;
            this.kullanıcıtanıtma1.Load += new System.EventHandler(this.kullanıcıtanıtma1_Load);
            // 
            // polikliniktanıtma1
            // 
            this.polikliniktanıtma1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.polikliniktanıtma1.Location = new System.Drawing.Point(258, 81);
            this.polikliniktanıtma1.Name = "polikliniktanıtma1";
            this.polikliniktanıtma1.Size = new System.Drawing.Size(278, 120);
            this.polikliniktanıtma1.TabIndex = 3;
            this.polikliniktanıtma1.Load += new System.EventHandler(this.polikliniktanıtma1_Load);
            // 
            // Form1
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(859, 652);
            this.Controls.Add(this.kullanıcıtanıtma1);
            this.Controls.Add(this.polikliniktanıtma1);
            this.Controls.Add(this.loginpanel);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.loginpanel.ResumeLayout(false);
            this.loginpanel.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel loginpanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem referanslarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem poliklinikTanıtmaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kullanıcıTanıtmaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çıkışToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hastaKabulToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem raporlarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hastaİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rapor1geçiciToolStripMenuItem;
        private polikliniktanıtma polikliniktanıtma1;
        private kullanıcıtanıtma kullanıcıtanıtma1;
    }
}

