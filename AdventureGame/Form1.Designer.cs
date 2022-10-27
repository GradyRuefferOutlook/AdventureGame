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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // uInput
            // 
            this.uInput.BackColor = System.Drawing.Color.Blue;
            this.uInput.Font = new System.Drawing.Font("Morpheus", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uInput.ForeColor = System.Drawing.SystemColors.Window;
            this.uInput.Location = new System.Drawing.Point(66, 661);
            this.uInput.Name = "uInput";
            this.uInput.Size = new System.Drawing.Size(1312, 44);
            this.uInput.TabIndex = 0;
            this.uInput.KeyUp += new System.Windows.Forms.KeyEventHandler(this.uInput_KeyUp);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::AdventureGame.Properties.Resources.Medieval_Arrow;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Image = global::AdventureGame.Properties.Resources.Medieval_Arrow;
            this.pictureBox1.Location = new System.Drawing.Point(10, 661);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 43);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // textOutput
            // 
            this.textOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.textOutput.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.textOutput.Location = new System.Drawing.Point(668, -2);
            this.textOutput.Name = "textOutput";
            this.textOutput.Size = new System.Drawing.Size(710, 660);
            this.textOutput.TabIndex = 2;
            // 
            // uInputBack
            // 
            this.uInputBack.BackColor = System.Drawing.Color.Blue;
            this.uInputBack.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.uInputBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.uInputBack.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.uInputBack.Location = new System.Drawing.Point(66, 661);
            this.uInputBack.Name = "uInputBack";
            this.uInputBack.Size = new System.Drawing.Size(1312, 50);
            this.uInputBack.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AdventureGame.Properties.Resources.CastleBackdrop;
            this.ClientSize = new System.Drawing.Size(1370, 701);
            this.Controls.Add(this.textOutput);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.uInput);
            this.Controls.Add(this.uInputBack);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Medisia";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox uInput;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label textOutput;
        private System.Windows.Forms.Label uInputBack;
    }
}

