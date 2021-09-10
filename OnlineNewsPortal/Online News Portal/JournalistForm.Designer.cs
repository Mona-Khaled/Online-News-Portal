namespace Online_News_Portal
{
    partial class JournalistForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JournalistForm));
            this.jourPanel = new System.Windows.Forms.Panel();
            this.deletebtn = new Online_News_Portal.Roundbuttons();
            this.updatebtn = new Online_News_Portal.Roundbuttons();
            this.publishbtn = new Online_News_Portal.Roundbuttons();
            this.categoryname_cmb = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.newsdes_txt = new System.Windows.Forms.TextBox();
            this.newsid_cmb = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.closebtn = new System.Windows.Forms.Button();
            this.backbtn = new Online_News_Portal.Roundbuttons();
            this.jourPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // jourPanel
            // 
            this.jourPanel.BackColor = System.Drawing.SystemColors.Control;
            this.jourPanel.Controls.Add(this.deletebtn);
            this.jourPanel.Controls.Add(this.updatebtn);
            this.jourPanel.Controls.Add(this.publishbtn);
            this.jourPanel.Controls.Add(this.categoryname_cmb);
            this.jourPanel.Controls.Add(this.label3);
            this.jourPanel.Controls.Add(this.newsdes_txt);
            this.jourPanel.Controls.Add(this.newsid_cmb);
            this.jourPanel.Controls.Add(this.label5);
            this.jourPanel.Controls.Add(this.label4);
            this.jourPanel.Location = new System.Drawing.Point(205, 48);
            this.jourPanel.Name = "jourPanel";
            this.jourPanel.Size = new System.Drawing.Size(448, 444);
            this.jourPanel.TabIndex = 1;
            // 
            // deletebtn
            // 
            this.deletebtn.BackColor = System.Drawing.Color.LightBlue;
            this.deletebtn.FlatAppearance.BorderSize = 0;
            this.deletebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deletebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletebtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.deletebtn.Location = new System.Drawing.Point(321, 339);
            this.deletebtn.Name = "deletebtn";
            this.deletebtn.Size = new System.Drawing.Size(94, 94);
            this.deletebtn.TabIndex = 21;
            this.deletebtn.Text = "Delete";
            this.deletebtn.UseVisualStyleBackColor = false;
            this.deletebtn.Click += new System.EventHandler(this.deletebtn_Click);
            // 
            // updatebtn
            // 
            this.updatebtn.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.updatebtn.FlatAppearance.BorderSize = 0;
            this.updatebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updatebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updatebtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.updatebtn.Location = new System.Drawing.Point(171, 339);
            this.updatebtn.Name = "updatebtn";
            this.updatebtn.Size = new System.Drawing.Size(94, 94);
            this.updatebtn.TabIndex = 20;
            this.updatebtn.Text = "Update";
            this.updatebtn.UseVisualStyleBackColor = false;
            this.updatebtn.Click += new System.EventHandler(this.updatebtn_Click);
            // 
            // publishbtn
            // 
            this.publishbtn.BackColor = System.Drawing.Color.LightBlue;
            this.publishbtn.FlatAppearance.BorderSize = 0;
            this.publishbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.publishbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.publishbtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.publishbtn.Location = new System.Drawing.Point(31, 339);
            this.publishbtn.Name = "publishbtn";
            this.publishbtn.Size = new System.Drawing.Size(94, 94);
            this.publishbtn.TabIndex = 19;
            this.publishbtn.Text = "Publish";
            this.publishbtn.UseVisualStyleBackColor = false;
            this.publishbtn.Click += new System.EventHandler(this.publishbtn_Click);
            // 
            // categoryname_cmb
            // 
            this.categoryname_cmb.BackColor = System.Drawing.Color.LavenderBlush;
            this.categoryname_cmb.ForeColor = System.Drawing.Color.Black;
            this.categoryname_cmb.FormattingEnabled = true;
            this.categoryname_cmb.Location = new System.Drawing.Point(130, 283);
            this.categoryname_cmb.Name = "categoryname_cmb";
            this.categoryname_cmb.Size = new System.Drawing.Size(285, 21);
            this.categoryname_cmb.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.label3.Location = new System.Drawing.Point(25, 284);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "Category";
            // 
            // newsdes_txt
            // 
            this.newsdes_txt.BackColor = System.Drawing.Color.LavenderBlush;
            this.newsdes_txt.ForeColor = System.Drawing.Color.Black;
            this.newsdes_txt.Location = new System.Drawing.Point(130, 156);
            this.newsdes_txt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.newsdes_txt.Multiline = true;
            this.newsdes_txt.Name = "newsdes_txt";
            this.newsdes_txt.Size = new System.Drawing.Size(285, 84);
            this.newsdes_txt.TabIndex = 14;
            // 
            // newsid_cmb
            // 
            this.newsid_cmb.BackColor = System.Drawing.Color.LavenderBlush;
            this.newsid_cmb.ForeColor = System.Drawing.Color.Black;
            this.newsid_cmb.FormattingEnabled = true;
            this.newsid_cmb.Location = new System.Drawing.Point(130, 90);
            this.newsid_cmb.Name = "newsid_cmb";
            this.newsid_cmb.Size = new System.Drawing.Size(285, 21);
            this.newsid_cmb.TabIndex = 13;
            this.newsid_cmb.SelectedIndexChanged += new System.EventHandler(this.newsid_cmb_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.label5.Location = new System.Drawing.Point(25, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "News ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.label4.Location = new System.Drawing.Point(25, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Description";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.label1.Location = new System.Drawing.Point(308, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 39);
            this.label1.TabIndex = 2;
            this.label1.Text = "JOURNALIST";
            // 
            // closebtn
            // 
            this.closebtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.closebtn.FlatAppearance.BorderSize = 0;
            this.closebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closebtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closebtn.ForeColor = System.Drawing.Color.White;
            this.closebtn.Location = new System.Drawing.Point(778, 0);
            this.closebtn.Name = "closebtn";
            this.closebtn.Size = new System.Drawing.Size(19, 34);
            this.closebtn.TabIndex = 7;
            this.closebtn.Text = "x";
            this.closebtn.UseVisualStyleBackColor = true;
            this.closebtn.Click += new System.EventHandler(this.closebtn_Click);
            // 
            // backbtn
            // 
            this.backbtn.BackColor = System.Drawing.Color.LightSlateGray;
            this.backbtn.FlatAppearance.BorderSize = 0;
            this.backbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backbtn.ForeColor = System.Drawing.Color.LavenderBlush;
            this.backbtn.Location = new System.Drawing.Point(0, 0);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(64, 36);
            this.backbtn.TabIndex = 20;
            this.backbtn.Text = "Back";
            this.backbtn.UseVisualStyleBackColor = false;
            this.backbtn.Click += new System.EventHandler(this.backbtn_Click);
            // 
            // JournalistForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(797, 493);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.backbtn);
            this.Controls.Add(this.closebtn);
            this.Controls.Add(this.jourPanel);
            this.ForeColor = System.Drawing.Color.Lavender;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "JournalistForm";
            this.Text = "JournalistForm";
            this.Load += new System.EventHandler(this.JournalistForm_Load);
            this.jourPanel.ResumeLayout(false);
            this.jourPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel jourPanel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox categoryname_cmb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox newsdes_txt;
        private System.Windows.Forms.ComboBox newsid_cmb;
        private System.Windows.Forms.Button closebtn;
        private Roundbuttons publishbtn;
        private Roundbuttons deletebtn;
        private Roundbuttons updatebtn;
        private Roundbuttons backbtn;
    }
}