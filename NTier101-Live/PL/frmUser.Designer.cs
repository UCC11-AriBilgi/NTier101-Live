namespace NTier101_Live.PL
{
    partial class frmUser
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
            this.dgrdUser = new System.Windows.Forms.DataGridView();
            this.btonNew = new System.Windows.Forms.Button();
            this.btonUpdate = new System.Windows.Forms.Button();
            this.btonDelete = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tboxUserName = new System.Windows.Forms.TextBox();
            this.tboxUserPassw = new System.Windows.Forms.TextBox();
            this.tboxAd = new System.Windows.Forms.TextBox();
            this.tboxSoyad = new System.Windows.Forms.TextBox();
            this.tboxTCKimlik = new System.Windows.Forms.TextBox();
            this.tboxMudurlukID = new System.Windows.Forms.TextBox();
            this.bonSave = new System.Windows.Forms.Button();
            this.btonClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgrdUser)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgrdUser
            // 
            this.dgrdUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrdUser.Location = new System.Drawing.Point(12, 12);
            this.dgrdUser.Name = "dgrdUser";
            this.dgrdUser.Size = new System.Drawing.Size(776, 150);
            this.dgrdUser.TabIndex = 0;
            // 
            // btonNew
            // 
            this.btonNew.Location = new System.Drawing.Point(12, 183);
            this.btonNew.Name = "btonNew";
            this.btonNew.Size = new System.Drawing.Size(75, 23);
            this.btonNew.TabIndex = 1;
            this.btonNew.Text = "Yeni";
            this.btonNew.UseVisualStyleBackColor = true;
            this.btonNew.Click += new System.EventHandler(this.btonNew_Click);
            // 
            // btonUpdate
            // 
            this.btonUpdate.Location = new System.Drawing.Point(115, 183);
            this.btonUpdate.Name = "btonUpdate";
            this.btonUpdate.Size = new System.Drawing.Size(75, 23);
            this.btonUpdate.TabIndex = 2;
            this.btonUpdate.Text = "Güncelle";
            this.btonUpdate.UseVisualStyleBackColor = true;
            this.btonUpdate.Click += new System.EventHandler(this.btonUpdate_Click);
            // 
            // btonDelete
            // 
            this.btonDelete.Location = new System.Drawing.Point(213, 183);
            this.btonDelete.Name = "btonDelete";
            this.btonDelete.Size = new System.Drawing.Size(75, 23);
            this.btonDelete.TabIndex = 3;
            this.btonDelete.Text = "Sil";
            this.btonDelete.UseVisualStyleBackColor = true;
            this.btonDelete.Click += new System.EventHandler(this.btonDelete_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bonSave);
            this.groupBox1.Controls.Add(this.tboxMudurlukID);
            this.groupBox1.Controls.Add(this.tboxTCKimlik);
            this.groupBox1.Controls.Add(this.tboxSoyad);
            this.groupBox1.Controls.Add(this.tboxAd);
            this.groupBox1.Controls.Add(this.tboxUserPassw);
            this.groupBox1.Controls.Add(this.tboxUserName);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 228);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(351, 211);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kullanıcı Detay";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kullanıcı Şifre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Soyad";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "TCKimlik";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 177);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Mudurluk";
            // 
            // tboxUserName
            // 
            this.tboxUserName.Location = new System.Drawing.Point(102, 23);
            this.tboxUserName.Name = "tboxUserName";
            this.tboxUserName.Size = new System.Drawing.Size(100, 20);
            this.tboxUserName.TabIndex = 6;
            // 
            // tboxUserPassw
            // 
            this.tboxUserPassw.Location = new System.Drawing.Point(102, 53);
            this.tboxUserPassw.Name = "tboxUserPassw";
            this.tboxUserPassw.Size = new System.Drawing.Size(100, 20);
            this.tboxUserPassw.TabIndex = 7;
            // 
            // tboxAd
            // 
            this.tboxAd.Location = new System.Drawing.Point(102, 83);
            this.tboxAd.Name = "tboxAd";
            this.tboxAd.Size = new System.Drawing.Size(148, 20);
            this.tboxAd.TabIndex = 8;
            // 
            // tboxSoyad
            // 
            this.tboxSoyad.Location = new System.Drawing.Point(102, 114);
            this.tboxSoyad.Name = "tboxSoyad";
            this.tboxSoyad.Size = new System.Drawing.Size(148, 20);
            this.tboxSoyad.TabIndex = 9;
            // 
            // tboxTCKimlik
            // 
            this.tboxTCKimlik.Location = new System.Drawing.Point(102, 145);
            this.tboxTCKimlik.Name = "tboxTCKimlik";
            this.tboxTCKimlik.Size = new System.Drawing.Size(100, 20);
            this.tboxTCKimlik.TabIndex = 10;
            // 
            // tboxMudurlukID
            // 
            this.tboxMudurlukID.Location = new System.Drawing.Point(102, 174);
            this.tboxMudurlukID.Name = "tboxMudurlukID";
            this.tboxMudurlukID.Size = new System.Drawing.Size(54, 20);
            this.tboxMudurlukID.TabIndex = 11;
            // 
            // bonSave
            // 
            this.bonSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bonSave.Location = new System.Drawing.Point(270, 177);
            this.bonSave.Name = "bonSave";
            this.bonSave.Size = new System.Drawing.Size(75, 23);
            this.bonSave.TabIndex = 12;
            this.bonSave.Text = "Kaydet";
            this.bonSave.UseVisualStyleBackColor = true;
            this.bonSave.Click += new System.EventHandler(this.bonSave_Click);
            // 
            // btonClose
            // 
            this.btonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btonClose.Location = new System.Drawing.Point(713, 473);
            this.btonClose.Name = "btonClose";
            this.btonClose.Size = new System.Drawing.Size(75, 23);
            this.btonClose.TabIndex = 5;
            this.btonClose.Text = "Kapat";
            this.btonClose.UseVisualStyleBackColor = true;
            this.btonClose.Click += new System.EventHandler(this.btonClose_Click);
            // 
            // frmUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 508);
            this.Controls.Add(this.btonClose);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btonDelete);
            this.Controls.Add(this.btonUpdate);
            this.Controls.Add(this.btonNew);
            this.Controls.Add(this.dgrdUser);
            this.Name = "frmUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmUser";
            this.Load += new System.EventHandler(this.frmUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgrdUser)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgrdUser;
        private System.Windows.Forms.Button btonNew;
        private System.Windows.Forms.Button btonUpdate;
        private System.Windows.Forms.Button btonDelete;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bonSave;
        private System.Windows.Forms.TextBox tboxMudurlukID;
        private System.Windows.Forms.TextBox tboxTCKimlik;
        private System.Windows.Forms.TextBox tboxSoyad;
        private System.Windows.Forms.TextBox tboxAd;
        private System.Windows.Forms.TextBox tboxUserPassw;
        private System.Windows.Forms.TextBox tboxUserName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btonClose;
    }
}