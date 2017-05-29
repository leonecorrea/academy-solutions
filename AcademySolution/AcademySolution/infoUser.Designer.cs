namespace AcademySolution
{
    partial class infoUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(infoUser));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.infoUserLastName = new System.Windows.Forms.Label();
            this.infoUserDateBirth = new System.Windows.Forms.Label();
            this.infoUserStreet = new System.Windows.Forms.Label();
            this.infoUserCpf = new System.Windows.Forms.Label();
            this.infoUserTelefone = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(371, 41);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(214, 186);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // infoUserLastName
            // 
            this.infoUserLastName.AutoSize = true;
            this.infoUserLastName.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoUserLastName.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.infoUserLastName.Location = new System.Drawing.Point(441, 235);
            this.infoUserLastName.Name = "infoUserLastName";
            this.infoUserLastName.Size = new System.Drawing.Size(0, 25);
            this.infoUserLastName.TabIndex = 45;
            // 
            // infoUserDateBirth
            // 
            this.infoUserDateBirth.AutoSize = true;
            this.infoUserDateBirth.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoUserDateBirth.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.infoUserDateBirth.Location = new System.Drawing.Point(414, 280);
            this.infoUserDateBirth.Name = "infoUserDateBirth";
            this.infoUserDateBirth.Size = new System.Drawing.Size(0, 25);
            this.infoUserDateBirth.TabIndex = 46;
            // 
            // infoUserStreet
            // 
            this.infoUserStreet.AutoSize = true;
            this.infoUserStreet.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoUserStreet.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.infoUserStreet.Location = new System.Drawing.Point(429, 323);
            this.infoUserStreet.Name = "infoUserStreet";
            this.infoUserStreet.Size = new System.Drawing.Size(0, 25);
            this.infoUserStreet.TabIndex = 47;
            // 
            // infoUserCpf
            // 
            this.infoUserCpf.AutoSize = true;
            this.infoUserCpf.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoUserCpf.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.infoUserCpf.Location = new System.Drawing.Point(395, 368);
            this.infoUserCpf.Name = "infoUserCpf";
            this.infoUserCpf.Size = new System.Drawing.Size(0, 25);
            this.infoUserCpf.TabIndex = 50;
            // 
            // infoUserTelefone
            // 
            this.infoUserTelefone.AutoSize = true;
            this.infoUserTelefone.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoUserTelefone.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.infoUserTelefone.Location = new System.Drawing.Point(414, 413);
            this.infoUserTelefone.Name = "infoUserTelefone";
            this.infoUserTelefone.Size = new System.Drawing.Size(0, 25);
            this.infoUserTelefone.TabIndex = 52;
            // 
            // infoUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 570);
            this.Controls.Add(this.infoUserTelefone);
            this.Controls.Add(this.infoUserCpf);
            this.Controls.Add(this.infoUserStreet);
            this.Controls.Add(this.infoUserDateBirth);
            this.Controls.Add(this.infoUserLastName);
            this.Controls.Add(this.pictureBox1);
            this.DisplayHeader = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Movable = false;
            this.Name = "infoUser";
            this.Padding = new System.Windows.Forms.Padding(20, 30, 20, 20);
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.SystemShadow;
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Load += new System.EventHandler(this.infoUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label infoUserLastName;
        private System.Windows.Forms.Label infoUserDateBirth;
        private System.Windows.Forms.Label infoUserStreet;
        private System.Windows.Forms.Label infoUserCpf;
        private System.Windows.Forms.Label infoUserTelefone;
    }
}