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
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
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
            this.infoUserLastName.Size = new System.Drawing.Size(74, 25);
            this.infoUserLastName.TabIndex = 45;
            this.infoUserLastName.Text = "Name";
            // 
            // infoUserDateBirth
            // 
            this.infoUserDateBirth.AutoSize = true;
            this.infoUserDateBirth.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoUserDateBirth.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.infoUserDateBirth.Location = new System.Drawing.Point(414, 280);
            this.infoUserDateBirth.Name = "infoUserDateBirth";
            this.infoUserDateBirth.Size = new System.Drawing.Size(128, 25);
            this.infoUserDateBirth.TabIndex = 46;
            this.infoUserDateBirth.Text = "xx/xx/xxxx";
            // 
            // infoUserStreet
            // 
            this.infoUserStreet.AutoSize = true;
            this.infoUserStreet.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoUserStreet.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.infoUserStreet.Location = new System.Drawing.Point(429, 323);
            this.infoUserStreet.Name = "infoUserStreet";
            this.infoUserStreet.Size = new System.Drawing.Size(98, 25);
            this.infoUserStreet.TabIndex = 47;
            this.infoUserStreet.Text = "Street X";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label7.Location = new System.Drawing.Point(395, 368);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(181, 25);
            this.label7.TabIndex = 50;
            this.label7.Text = "000.000.000-00";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label9.Location = new System.Drawing.Point(414, 413);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(139, 25);
            this.label9.TabIndex = 52;
            this.label9.Text = "00000-0000";
            // 
            // infoUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 570);
            this.ControlBox = false;
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.infoUserStreet);
            this.Controls.Add(this.infoUserDateBirth);
            this.Controls.Add(this.infoUserLastName);
            this.Controls.Add(this.pictureBox1);
            this.DisplayHeader = false;
            this.Movable = false;
            this.Name = "infoUser";
            this.Padding = new System.Windows.Forms.Padding(20, 30, 20, 20);
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
            this.Style = MetroFramework.MetroColorStyle.White;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label infoUserLastName;
        private System.Windows.Forms.Label infoUserDateBirth;
        private System.Windows.Forms.Label infoUserStreet;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
    }
}