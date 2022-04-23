
namespace prolab2._3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.temsilciButton = new System.Windows.Forms.Button();
            this.mudurButton = new System.Windows.Forms.Button();
            this.musteriButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            // 
            // temsilciButton
            // 
            this.temsilciButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.temsilciButton.Location = new System.Drawing.Point(640, 352);
            this.temsilciButton.Name = "temsilciButton";
            this.temsilciButton.Size = new System.Drawing.Size(200, 50);
            this.temsilciButton.TabIndex = 2;
            this.temsilciButton.Text = "Temsilci Girişi";
            this.temsilciButton.UseVisualStyleBackColor = true;
            this.temsilciButton.Click += new System.EventHandler(this.temsilciButton_Click);
            // 
            // mudurButton
            // 
            this.mudurButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.mudurButton.Location = new System.Drawing.Point(640, 402);
            this.mudurButton.Name = "mudurButton";
            this.mudurButton.Size = new System.Drawing.Size(200, 50);
            this.mudurButton.TabIndex = 3;
            this.mudurButton.Text = "Müdür Girişi";
            this.mudurButton.UseVisualStyleBackColor = true;
            this.mudurButton.Click += new System.EventHandler(this.mudurButton_Click);
            // 
            // musteriButton
            // 
            this.musteriButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.musteriButton.Location = new System.Drawing.Point(640, 302);
            this.musteriButton.Name = "musteriButton";
            this.musteriButton.Size = new System.Drawing.Size(200, 50);
            this.musteriButton.TabIndex = 4;
            this.musteriButton.Text = "Müşteri Girişi";
            this.musteriButton.UseVisualStyleBackColor = true;
            this.musteriButton.Click += new System.EventHandler(this.musteriButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(640, 205);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(200, 23);
            this.textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(640, 249);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(200, 23);
            this.textBox2.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(640, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "NUMARA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(640, 231);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "ŞİFRE";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.musteriButton);
            this.Controls.Add(this.mudurButton);
            this.Controls.Add(this.temsilciButton);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button temsilciButton;
        private System.Windows.Forms.Button mudurButton;
        private System.Windows.Forms.Button musteriButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

