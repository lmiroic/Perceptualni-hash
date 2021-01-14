
namespace Prezentacijski_sloj
{
    partial class PerceptualnoHashiranje
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
            this.pbPicture1 = new System.Windows.Forms.PictureBox();
            this.pbPicture2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAddPicture1 = new System.Windows.Forms.Button();
            this.btnAddPicture2 = new System.Windows.Forms.Button();
            this.rTxtIspis = new System.Windows.Forms.RichTextBox();
            this.btnPerceptualniHash = new System.Windows.Forms.Button();
            this.btnAverageHash = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbPicture1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPicture2)).BeginInit();
            this.SuspendLayout();
            // 
            // pbPicture1
            // 
            this.pbPicture1.Location = new System.Drawing.Point(12, 12);
            this.pbPicture1.Name = "pbPicture1";
            this.pbPicture1.Size = new System.Drawing.Size(239, 196);
            this.pbPicture1.TabIndex = 0;
            this.pbPicture1.TabStop = false;
            // 
            // pbPicture2
            // 
            this.pbPicture2.Location = new System.Drawing.Point(549, 12);
            this.pbPicture2.Name = "pbPicture2";
            this.pbPicture2.Size = new System.Drawing.Size(239, 196);
            this.pbPicture2.TabIndex = 1;
            this.pbPicture2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(98, 211);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Prva slika";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(644, 211);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Druga slika";
            // 
            // btnAddPicture1
            // 
            this.btnAddPicture1.Location = new System.Drawing.Point(257, 45);
            this.btnAddPicture1.Name = "btnAddPicture1";
            this.btnAddPicture1.Size = new System.Drawing.Size(219, 28);
            this.btnAddPicture1.TabIndex = 4;
            this.btnAddPicture1.Text = "Dodaj prvu sliku";
            this.btnAddPicture1.UseVisualStyleBackColor = true;
            this.btnAddPicture1.Click += new System.EventHandler(this.btnAddPicture1_Click);
            // 
            // btnAddPicture2
            // 
            this.btnAddPicture2.Location = new System.Drawing.Point(324, 142);
            this.btnAddPicture2.Name = "btnAddPicture2";
            this.btnAddPicture2.Size = new System.Drawing.Size(219, 28);
            this.btnAddPicture2.TabIndex = 5;
            this.btnAddPicture2.Text = "Dodaj drugu sliku";
            this.btnAddPicture2.UseVisualStyleBackColor = true;
            this.btnAddPicture2.Click += new System.EventHandler(this.btnAddPicture2_Click);
            // 
            // rTxtIspis
            // 
            this.rTxtIspis.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rTxtIspis.Location = new System.Drawing.Point(12, 253);
            this.rTxtIspis.Name = "rTxtIspis";
            this.rTxtIspis.Size = new System.Drawing.Size(776, 104);
            this.rTxtIspis.TabIndex = 6;
            this.rTxtIspis.Text = "";
            // 
            // btnPerceptualniHash
            // 
            this.btnPerceptualniHash.Location = new System.Drawing.Point(44, 393);
            this.btnPerceptualniHash.Name = "btnPerceptualniHash";
            this.btnPerceptualniHash.Size = new System.Drawing.Size(237, 45);
            this.btnPerceptualniHash.TabIndex = 7;
            this.btnPerceptualniHash.Text = "Perceptualno hashiranje";
            this.btnPerceptualniHash.UseVisualStyleBackColor = true;
            this.btnPerceptualniHash.Click += new System.EventHandler(this.btnPerceptualniHash_Click);
            // 
            // btnAverageHash
            // 
            this.btnAverageHash.Location = new System.Drawing.Point(509, 393);
            this.btnAverageHash.Name = "btnAverageHash";
            this.btnAverageHash.Size = new System.Drawing.Size(237, 45);
            this.btnAverageHash.TabIndex = 8;
            this.btnAverageHash.Text = "Average hashiranje";
            this.btnAverageHash.UseVisualStyleBackColor = true;
            this.btnAverageHash.Click += new System.EventHandler(this.btnAverageHash_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAverageHash);
            this.Controls.Add(this.btnPerceptualniHash);
            this.Controls.Add(this.rTxtIspis);
            this.Controls.Add(this.btnAddPicture2);
            this.Controls.Add(this.btnAddPicture1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbPicture2);
            this.Controls.Add(this.pbPicture1);
            this.Name = "Form1";
            this.Text = "Perceptualno hashiranje";
            ((System.ComponentModel.ISupportInitialize)(this.pbPicture1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPicture2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbPicture1;
        private System.Windows.Forms.PictureBox pbPicture2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAddPicture1;
        private System.Windows.Forms.Button btnAddPicture2;
        private System.Windows.Forms.RichTextBox rTxtIspis;
        private System.Windows.Forms.Button btnPerceptualniHash;
        private System.Windows.Forms.Button btnAverageHash;
    }
}

