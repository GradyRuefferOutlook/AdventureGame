namespace AdventureGame
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
            this.uInput = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textOutput = new System.Windows.Forms.Label();
            this.uInputBack = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // uInput
            // 
            this.uInput.BackColor = System.Drawing.Color.Blue;
            this.uInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uInput.ForeColor = System.Drawing.SystemColors.Window;
            this.uInput.Location = new System.Drawing.Point(88, 814);
            this.uInput.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.uInput.Name = "uInput";
            this.uInput.Size = new System.Drawing.Size(1748, 46);
            this.uInput.TabIndex = 0;
            this.uInput.Text = "Press Enter to start";
            this.uInput.KeyUp += new System.Windows.Forms.KeyEventHandler(this.uInput_KeyUp);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::AdventureGame.Properties.Resources.Medieval_Arrow;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Image = global::AdventureGame.Properties.Resources.Medieval_Arrow;
            this.pictureBox1.Location = new System.Drawing.Point(13, 814);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(67, 53);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // textOutput
            // 
            this.textOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.textOutput.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.textOutput.Location = new System.Drawing.Point(891, -2);
            this.textOutput.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.textOutput.Name = "textOutput";
            this.textOutput.Size = new System.Drawing.Size(947, 812);
            this.textOutput.TabIndex = 2;
            // 
            // uInputBack
            // 
            this.uInputBack.BackColor = System.Drawing.Color.Blue;
            this.uInputBack.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.uInputBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.uInputBack.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.uInputBack.Location = new System.Drawing.Point(88, 814);
            this.uInputBack.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.uInputBack.Name = "uInputBack";
            this.uInputBack.Size = new System.Drawing.Size(1749, 62);
            this.uInputBack.TabIndex = 3;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(-6, -2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(796, 692);
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AdventureGame.Properties.Resources.CastleBackdrop;
            this.ClientSize = new System.Drawing.Size(1827, 863);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.textOutput);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.uInput);
            this.Controls.Add(this.uInputBack);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Medisia";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox uInput;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label textOutput;
        private System.Windows.Forms.Label uInputBack;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

