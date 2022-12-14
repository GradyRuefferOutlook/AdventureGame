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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.uInput = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textOutput = new System.Windows.Forms.Label();
            this.uInputBack = new System.Windows.Forms.Label();
            this.medisiaImageView = new System.Windows.Forms.PictureBox();
            this.medisiaBackdrop = new System.Windows.Forms.PictureBox();
            this.medisiaBorder = new System.Windows.Forms.PictureBox();
            this.themeOperator = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medisiaImageView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medisiaBackdrop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medisiaBorder)).BeginInit();
            this.SuspendLayout();
            // 
            // uInput
            // 
            this.uInput.BackColor = System.Drawing.Color.Blue;
            this.uInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uInput.ForeColor = System.Drawing.SystemColors.Window;
            this.uInput.Location = new System.Drawing.Point(88, 814);
            this.uInput.Margin = new System.Windows.Forms.Padding(4);
            this.uInput.Multiline = true;
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
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
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
            this.uInputBack.Size = new System.Drawing.Size(1749, 46);
            this.uInputBack.TabIndex = 3;
            // 
            // medisiaImageView
            // 
            this.medisiaImageView.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.medisiaImageView.Location = new System.Drawing.Point(-6, -2);
            this.medisiaImageView.Name = "medisiaImageView";
            this.medisiaImageView.Size = new System.Drawing.Size(863, 613);
            this.medisiaImageView.TabIndex = 4;
            this.medisiaImageView.TabStop = false;
            // 
            // medisiaBackdrop
            // 
            this.medisiaBackdrop.BackgroundImage = global::AdventureGame.Properties.Resources.ForestBackdrop;
            this.medisiaBackdrop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.medisiaBackdrop.Location = new System.Drawing.Point(-6, -2);
            this.medisiaBackdrop.Name = "medisiaBackdrop";
            this.medisiaBackdrop.Size = new System.Drawing.Size(863, 613);
            this.medisiaBackdrop.TabIndex = 5;
            this.medisiaBackdrop.TabStop = false;
            // 
            // medisiaBorder
            // 
            this.medisiaBorder.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.medisiaBorder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.medisiaBorder.Location = new System.Drawing.Point(-6, -2);
            this.medisiaBorder.Name = "medisiaBorder";
            this.medisiaBorder.Size = new System.Drawing.Size(872, 628);
            this.medisiaBorder.TabIndex = 6;
            this.medisiaBorder.TabStop = false;
            // 
            // themeOperator
            // 
            this.themeOperator.Interval = 5555;
            this.themeOperator.Tick += new System.EventHandler(this.themeOperator_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = global::AdventureGame.Properties.Resources.CastleBackdrop;
            this.ClientSize = new System.Drawing.Size(1827, 855);
            this.Controls.Add(this.medisiaImageView);
            this.Controls.Add(this.textOutput);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.uInput);
            this.Controls.Add(this.uInputBack);
            this.Controls.Add(this.medisiaBackdrop);
            this.Controls.Add(this.medisiaBorder);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Medisia";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medisiaImageView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medisiaBackdrop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medisiaBorder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox uInput;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label textOutput;
        private System.Windows.Forms.Label uInputBack;
        private System.Windows.Forms.PictureBox medisiaImageView;
        private System.Windows.Forms.PictureBox medisiaBackdrop;
        private System.Windows.Forms.PictureBox medisiaBorder;
        private System.Windows.Forms.Timer themeOperator;
    }
}

