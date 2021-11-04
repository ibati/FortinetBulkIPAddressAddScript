namespace FortinetBulkIPAddressAddScript
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lbDescrition2 = new System.Windows.Forms.Label();
            this.lbDescrition1 = new System.Windows.Forms.Label();
            this.picGithub = new System.Windows.Forms.PictureBox();
            this.picTwitter = new System.Windows.Forms.PictureBox();
            this.picWebsite = new System.Windows.Forms.PictureBox();
            this.txtIPs = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picGithub)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTwitter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWebsite)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCreate
            // 
            this.btnCreate.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCreate.Location = new System.Drawing.Point(380, 60);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(150, 60);
            this.btnCreate.TabIndex = 2;
            this.btnCreate.Text = "Create Script";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnClear.ForeColor = System.Drawing.Color.Maroon;
            this.btnClear.Location = new System.Drawing.Point(380, 140);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(150, 60);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lbDescrition2
            // 
            this.lbDescrition2.Font = new System.Drawing.Font("Consolas", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbDescrition2.Location = new System.Drawing.Point(377, 363);
            this.lbDescrition2.Name = "lbDescrition2";
            this.lbDescrition2.Size = new System.Drawing.Size(150, 70);
            this.lbDescrition2.TabIndex = 4;
            this.lbDescrition2.Text = "Additionally, added IP addresses are included in the deny-ip-grp group.";
            // 
            // lbDescrition1
            // 
            this.lbDescrition1.Font = new System.Drawing.Font("Consolas", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbDescrition1.Location = new System.Drawing.Point(380, 223);
            this.lbDescrition1.Name = "lbDescrition1";
            this.lbDescrition1.Size = new System.Drawing.Size(150, 127);
            this.lbDescrition1.TabIndex = 5;
            this.lbDescrition1.Text = "With this application, the IP addresses you paste in lines are converted into a b" +
    "ulk IP address addition script for Fortinet.";
            // 
            // picGithub
            // 
            this.picGithub.Image = ((System.Drawing.Image)(resources.GetObject("picGithub.Image")));
            this.picGithub.Location = new System.Drawing.Point(320, 607);
            this.picGithub.MaximumSize = new System.Drawing.Size(24, 24);
            this.picGithub.MinimumSize = new System.Drawing.Size(24, 24);
            this.picGithub.Name = "picGithub";
            this.picGithub.Size = new System.Drawing.Size(24, 24);
            this.picGithub.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picGithub.TabIndex = 6;
            this.picGithub.TabStop = false;
            this.picGithub.Click += new System.EventHandler(this.picGithub_Click);
            // 
            // picTwitter
            // 
            this.picTwitter.Image = ((System.Drawing.Image)(resources.GetObject("picTwitter.Image")));
            this.picTwitter.Location = new System.Drawing.Point(350, 607);
            this.picTwitter.MaximumSize = new System.Drawing.Size(24, 24);
            this.picTwitter.MinimumSize = new System.Drawing.Size(24, 24);
            this.picTwitter.Name = "picTwitter";
            this.picTwitter.Size = new System.Drawing.Size(24, 24);
            this.picTwitter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picTwitter.TabIndex = 7;
            this.picTwitter.TabStop = false;
            this.picTwitter.Click += new System.EventHandler(this.picTwitter_Click);
            // 
            // picWebsite
            // 
            this.picWebsite.Image = ((System.Drawing.Image)(resources.GetObject("picWebsite.Image")));
            this.picWebsite.Location = new System.Drawing.Point(290, 607);
            this.picWebsite.MaximumSize = new System.Drawing.Size(16, 16);
            this.picWebsite.MinimumSize = new System.Drawing.Size(24, 24);
            this.picWebsite.Name = "picWebsite";
            this.picWebsite.Size = new System.Drawing.Size(24, 24);
            this.picWebsite.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picWebsite.TabIndex = 8;
            this.picWebsite.TabStop = false;
            this.picWebsite.Click += new System.EventHandler(this.picWebsite_Click);
            // 
            // txtIPs
            // 
            this.txtIPs.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtIPs.ForeColor = System.Drawing.Color.SeaGreen;
            this.txtIPs.Location = new System.Drawing.Point(55, 60);
            this.txtIPs.Multiline = true;
            this.txtIPs.Name = "txtIPs";
            this.txtIPs.Size = new System.Drawing.Size(259, 497);
            this.txtIPs.TabIndex = 9;
            this.txtIPs.Text = "Paste the IP Addresses here, without spaces, in lines";
            this.txtIPs.Enter += new System.EventHandler(this.txtIPs_Enter);
            this.txtIPs.Leave += new System.EventHandler(this.txtIPs_Leave);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 651);
            this.Controls.Add(this.txtIPs);
            this.Controls.Add(this.picWebsite);
            this.Controls.Add(this.picTwitter);
            this.Controls.Add(this.picGithub);
            this.Controls.Add(this.lbDescrition1);
            this.Controls.Add(this.lbDescrition2);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCreate);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Fortinet Bulk IP Address Add Script";
            ((System.ComponentModel.ISupportInitialize)(this.picGithub)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTwitter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWebsite)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lbDescrition2;
        private System.Windows.Forms.Label lbDescrition1;
        private System.Windows.Forms.PictureBox picGithub;
        private System.Windows.Forms.PictureBox picTwitter;
        private System.Windows.Forms.PictureBox picWebsite;
        private System.Windows.Forms.TextBox txtIPs;
    }
}

