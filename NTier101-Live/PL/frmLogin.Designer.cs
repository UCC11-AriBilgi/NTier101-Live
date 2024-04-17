namespace NTier101_Live.PL
{
    partial class frmLogin
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tboxUserName = new System.Windows.Forms.TextBox();
            this.tboxUserPassw = new System.Windows.Forms.TextBox();
            this.btonLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kullanıcı Şifre";
            // 
            // tboxUserName
            // 
            this.tboxUserName.Location = new System.Drawing.Point(128, 34);
            this.tboxUserName.Name = "tboxUserName";
            this.tboxUserName.Size = new System.Drawing.Size(100, 20);
            this.tboxUserName.TabIndex = 2;
            // 
            // tboxUserPassw
            // 
            this.tboxUserPassw.Location = new System.Drawing.Point(128, 70);
            this.tboxUserPassw.Name = "tboxUserPassw";
            this.tboxUserPassw.Size = new System.Drawing.Size(100, 20);
            this.tboxUserPassw.TabIndex = 3;
            // 
            // btonLogin
            // 
            this.btonLogin.Location = new System.Drawing.Point(143, 124);
            this.btonLogin.Name = "btonLogin";
            this.btonLogin.Size = new System.Drawing.Size(75, 23);
            this.btonLogin.TabIndex = 4;
            this.btonLogin.Text = "Giriş";
            this.btonLogin.UseVisualStyleBackColor = true;
            this.btonLogin.Click += new System.EventHandler(this.btonLogin_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 185);
            this.Controls.Add(this.btonLogin);
            this.Controls.Add(this.tboxUserPassw);
            this.Controls.Add(this.tboxUserName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmLogin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tboxUserName;
        private System.Windows.Forms.TextBox tboxUserPassw;
        private System.Windows.Forms.Button btonLogin;
    }
}