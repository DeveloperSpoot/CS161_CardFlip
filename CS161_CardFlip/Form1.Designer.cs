namespace CS161_CardFlip
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
            this.cardBackPic = new System.Windows.Forms.PictureBox();
            this.cardFrontPic = new System.Windows.Forms.PictureBox();
            this.showBackCardButton = new System.Windows.Forms.Button();
            this.showCardFrontButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.cardBackPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardFrontPic)).BeginInit();
            this.SuspendLayout();
            // 
            // cardBackPic
            // 
            this.cardBackPic.Image = ((System.Drawing.Image)(resources.GetObject("cardBackPic.Image")));
            this.cardBackPic.Location = new System.Drawing.Point(52, 12);
            this.cardBackPic.Name = "cardBackPic";
            this.cardBackPic.Size = new System.Drawing.Size(143, 203);
            this.cardBackPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cardBackPic.TabIndex = 0;
            this.cardBackPic.TabStop = false;
            // 
            // cardFrontPic
            // 
            this.cardFrontPic.Image = ((System.Drawing.Image)(resources.GetObject("cardFrontPic.Image")));
            this.cardFrontPic.Location = new System.Drawing.Point(215, 12);
            this.cardFrontPic.Name = "cardFrontPic";
            this.cardFrontPic.Size = new System.Drawing.Size(143, 203);
            this.cardFrontPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cardFrontPic.TabIndex = 1;
            this.cardFrontPic.TabStop = false;
            this.cardFrontPic.Visible = false;
            // 
            // showBackCardButton
            // 
            this.showBackCardButton.Enabled = false;
            this.showBackCardButton.Location = new System.Drawing.Point(52, 221);
            this.showBackCardButton.Name = "showBackCardButton";
            this.showBackCardButton.Size = new System.Drawing.Size(143, 44);
            this.showBackCardButton.TabIndex = 2;
            this.showBackCardButton.Text = "Show the Card Back";
            this.showBackCardButton.UseVisualStyleBackColor = true;
            this.showBackCardButton.Click += new System.EventHandler(this.showBackCardButton_Click);
            // 
            // showCardFrontButton
            // 
            this.showCardFrontButton.Location = new System.Drawing.Point(215, 221);
            this.showCardFrontButton.Name = "showCardFrontButton";
            this.showCardFrontButton.Size = new System.Drawing.Size(143, 44);
            this.showCardFrontButton.TabIndex = 3;
            this.showCardFrontButton.Text = "Show the Card Front";
            this.showCardFrontButton.UseVisualStyleBackColor = true;
            this.showCardFrontButton.Click += new System.EventHandler(this.showCardFrontButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 278);
            this.Controls.Add(this.showCardFrontButton);
            this.Controls.Add(this.showBackCardButton);
            this.Controls.Add(this.cardFrontPic);
            this.Controls.Add(this.cardBackPic);
            this.Name = "Form1";
            this.Text = "CS161 Card Flip";
            ((System.ComponentModel.ISupportInitialize)(this.cardBackPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardFrontPic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox cardBackPic;
        private System.Windows.Forms.PictureBox cardFrontPic;
        private System.Windows.Forms.Button showBackCardButton;
        private System.Windows.Forms.Button showCardFrontButton;
    }
}

