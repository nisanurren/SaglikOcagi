namespace Sağlık_OCağı_Hasta_Takip_Sistemi
{
    partial class kullanıcıtanıtma
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tableAdapterManager1 = new Sağlık_OCağı_Hasta_Takip_Sistemi.saglikocakDataSetTableAdapters.TableAdapterManager();
            this.hastaTableAdapter1 = new Sağlık_OCağı_Hasta_Takip_Sistemi.saglikocakDataSetTableAdapters.hastaTableAdapter();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(-4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(412, 19);
            this.label4.TabIndex = 1;
            this.label4.Text = "Kullanıcı Tanıtma                                            ";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Kullanıcı Kodu";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(79, 64);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "yeni kullanıcı ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.cikisTableAdapter = null;
            this.tableAdapterManager1.hastaTableAdapter = this.hastaTableAdapter1;
            this.tableAdapterManager1.islemTableAdapter = null;
            this.tableAdapterManager1.kullaniciTableAdapter = null;
            this.tableAdapterManager1.poliklinikTableAdapter = null;
            this.tableAdapterManager1.sevkTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = Sağlık_OCağı_Hasta_Takip_Sistemi.saglikocakDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // hastaTableAdapter1
            // 
            this.hastaTableAdapter1.ClearBeforeFill = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(99, 37);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 5;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // kullanıcıtanıtma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Name = "kullanıcıtanıtma";
            this.Size = new System.Drawing.Size(271, 103);
            this.Load += new System.EventHandler(this.kullanıcıtanıtma_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private saglikocakDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private saglikocakDataSetTableAdapters.hastaTableAdapter hastaTableAdapter1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}
