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
            this.lbDescrition1 = new System.Windows.Forms.Label();
            this.picGithub = new System.Windows.Forms.PictureBox();
            this.picTwitter = new System.Windows.Forms.PictureBox();
            this.picWebsite = new System.Windows.Forms.PictureBox();
            this.txtIPs = new System.Windows.Forms.TextBox();
            this.txtIPGrpName = new System.Windows.Forms.TextBox();
            this.grpDesc = new System.Windows.Forms.GroupBox();
            this.grpApp = new System.Windows.Forms.GroupBox();
            this.lbDescription2 = new System.Windows.Forms.Label();
            this.grpWarn = new System.Windows.Forms.GroupBox();
            this.lbWarn1 = new System.Windows.Forms.Label();
            this.lbWarn2 = new System.Windows.Forms.Label();
            this.lbWarn3 = new System.Windows.Forms.Label();
            this.grpReadMe = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.picGithub)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTwitter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWebsite)).BeginInit();
            this.grpDesc.SuspendLayout();
            this.grpApp.SuspendLayout();
            this.grpWarn.SuspendLayout();
            this.grpReadMe.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCreate
            // 
            this.btnCreate.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCreate.Location = new System.Drawing.Point(285, 212);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(250, 40);
            this.btnCreate.TabIndex = 2;
            this.btnCreate.Text = "Create Script";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnClear.ForeColor = System.Drawing.Color.Maroon;
            this.btnClear.Location = new System.Drawing.Point(285, 258);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(250, 40);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lbDescrition1
            // 
            this.lbDescrition1.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbDescrition1.Location = new System.Drawing.Point(12, 26);
            this.lbDescrition1.Name = "lbDescrition1";
            this.lbDescrition1.Size = new System.Drawing.Size(535, 40);
            this.lbDescrition1.TabIndex = 5;
            this.lbDescrition1.Text = "With this application, the IP addresses you paste in lines are converted into a b" +
    "ulk IP address addition script for Fortinet.";
            // 
            // picGithub
            // 
            this.picGithub.Image = ((System.Drawing.Image)(resources.GetObject("picGithub.Image")));
            this.picGithub.Location = new System.Drawing.Point(292, 607);
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
            this.picTwitter.Location = new System.Drawing.Point(322, 607);
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
            this.picWebsite.Location = new System.Drawing.Point(262, 607);
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
            this.txtIPs.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtIPs.ForeColor = System.Drawing.Color.SeaGreen;
            this.txtIPs.Location = new System.Drawing.Point(18, 52);
            this.txtIPs.Multiline = true;
            this.txtIPs.Name = "txtIPs";
            this.txtIPs.Size = new System.Drawing.Size(250, 395);
            this.txtIPs.TabIndex = 9;
            this.txtIPs.Text = "Paste the IP Addresses here, without spaces, in lines";
            this.txtIPs.Enter += new System.EventHandler(this.txtIPs_Enter);
            this.txtIPs.Leave += new System.EventHandler(this.txtIPs_Leave);
            // 
            // txtIPGrpName
            // 
            this.txtIPGrpName.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtIPGrpName.ForeColor = System.Drawing.Color.SeaGreen;
            this.txtIPGrpName.Location = new System.Drawing.Point(18, 24);
            this.txtIPGrpName.MaximumSize = new System.Drawing.Size(250, 20);
            this.txtIPGrpName.MinimumSize = new System.Drawing.Size(250, 20);
            this.txtIPGrpName.Name = "txtIPGrpName";
            this.txtIPGrpName.Size = new System.Drawing.Size(250, 20);
            this.txtIPGrpName.TabIndex = 10;
            this.txtIPGrpName.Text = "Enter IP Group Name";
            this.txtIPGrpName.Enter += new System.EventHandler(this.txtIPGrpName_Enter);
            this.txtIPGrpName.Leave += new System.EventHandler(this.txtIPGrpName_Leave);
            // 
            // grpDesc
            // 
            this.grpDesc.Controls.Add(this.lbDescrition1);
            this.grpDesc.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpDesc.Location = new System.Drawing.Point(30, 35);
            this.grpDesc.Name = "grpDesc";
            this.grpDesc.Size = new System.Drawing.Size(550, 79);
            this.grpDesc.TabIndex = 11;
            this.grpDesc.TabStop = false;
            this.grpDesc.Text = "Description";
            // 
            // grpApp
            // 
            this.grpApp.Controls.Add(this.grpReadMe);
            this.grpApp.Controls.Add(this.grpWarn);
            this.grpApp.Controls.Add(this.txtIPs);
            this.grpApp.Controls.Add(this.txtIPGrpName);
            this.grpApp.Controls.Add(this.btnCreate);
            this.grpApp.Controls.Add(this.btnClear);
            this.grpApp.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpApp.Location = new System.Drawing.Point(30, 130);
            this.grpApp.Name = "grpApp";
            this.grpApp.Size = new System.Drawing.Size(550, 459);
            this.grpApp.TabIndex = 12;
            this.grpApp.TabStop = false;
            this.grpApp.Text = "Application";
            // 
            // lbDescription2
            // 
            this.lbDescription2.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbDescription2.Location = new System.Drawing.Point(12, 27);
            this.lbDescription2.Name = "lbDescription2";
            this.lbDescription2.Size = new System.Drawing.Size(224, 147);
            this.lbDescription2.TabIndex = 6;
            this.lbDescription2.Text = "Please enter the group name first. Then enter all IP addresses in the field. This" +
    " script will first import the IP addresses to Fortinet in bulk and make them a m" +
    "ember of the IP group you named.";
            // 
            // grpWarn
            // 
            this.grpWarn.Controls.Add(this.lbWarn3);
            this.grpWarn.Controls.Add(this.lbWarn2);
            this.grpWarn.Controls.Add(this.lbWarn1);
            this.grpWarn.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpWarn.Location = new System.Drawing.Point(285, 304);
            this.grpWarn.Name = "grpWarn";
            this.grpWarn.Size = new System.Drawing.Size(250, 144);
            this.grpWarn.TabIndex = 12;
            this.grpWarn.TabStop = false;
            this.grpWarn.Text = "Warning";
            // 
            // lbWarn1
            // 
            this.lbWarn1.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbWarn1.Location = new System.Drawing.Point(12, 22);
            this.lbWarn1.Name = "lbWarn1";
            this.lbWarn1.Size = new System.Drawing.Size(224, 42);
            this.lbWarn1.TabIndex = 5;
            this.lbWarn1.Text = "Do not leave spaces at the end of IP addresses!";
            // 
            // lbWarn2
            // 
            this.lbWarn2.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbWarn2.Location = new System.Drawing.Point(12, 64);
            this.lbWarn2.Name = "lbWarn2";
            this.lbWarn2.Size = new System.Drawing.Size(224, 42);
            this.lbWarn2.TabIndex = 6;
            this.lbWarn2.Text = "Do not leave spaces between lines!";
            // 
            // lbWarn3
            // 
            this.lbWarn3.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbWarn3.Location = new System.Drawing.Point(12, 106);
            this.lbWarn3.Name = "lbWarn3";
            this.lbWarn3.Size = new System.Drawing.Size(224, 25);
            this.lbWarn3.TabIndex = 7;
            this.lbWarn3.Text = "Do not space the last line!";
            // 
            // grpReadMe
            // 
            this.grpReadMe.Controls.Add(this.lbDescription2);
            this.grpReadMe.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpReadMe.Location = new System.Drawing.Point(285, 24);
            this.grpReadMe.Name = "grpReadMe";
            this.grpReadMe.Size = new System.Drawing.Size(250, 182);
            this.grpReadMe.TabIndex = 13;
            this.grpReadMe.TabStop = false;
            this.grpReadMe.Text = "Please Read Me!";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 651);
            this.Controls.Add(this.grpApp);
            this.Controls.Add(this.grpDesc);
            this.Controls.Add(this.picWebsite);
            this.Controls.Add(this.picTwitter);
            this.Controls.Add(this.picGithub);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Fortinet Bulk IP Address Add Script";
            ((System.ComponentModel.ISupportInitialize)(this.picGithub)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTwitter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWebsite)).EndInit();
            this.grpDesc.ResumeLayout(false);
            this.grpApp.ResumeLayout(false);
            this.grpApp.PerformLayout();
            this.grpWarn.ResumeLayout(false);
            this.grpReadMe.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lbDescrition1;
        private System.Windows.Forms.PictureBox picGithub;
        private System.Windows.Forms.PictureBox picTwitter;
        private System.Windows.Forms.PictureBox picWebsite;
        private System.Windows.Forms.TextBox txtIPs;
        private System.Windows.Forms.TextBox txtIPGrpName;
        private System.Windows.Forms.GroupBox grpDesc;
        private System.Windows.Forms.GroupBox grpApp;
        private System.Windows.Forms.Label lbDescription2;
        private System.Windows.Forms.GroupBox grpReadMe;
        private System.Windows.Forms.GroupBox grpWarn;
        private System.Windows.Forms.Label lbWarn3;
        private System.Windows.Forms.Label lbWarn2;
        private System.Windows.Forms.Label lbWarn1;
    }
}

