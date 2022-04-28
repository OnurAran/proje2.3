
namespace prolab2._3
{
    partial class musteriTemsilcisi
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
            this.musteriIslemleriButton = new System.Windows.Forms.Button();
            this.talepIslemleriButton = new System.Windows.Forms.Button();
            this.musteriOzetButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // musteriIslemleriButton
            // 
            this.musteriIslemleriButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.musteriIslemleriButton.Location = new System.Drawing.Point(238, 126);
            this.musteriIslemleriButton.Name = "musteriIslemleriButton";
            this.musteriIslemleriButton.Size = new System.Drawing.Size(200, 50);
            this.musteriIslemleriButton.TabIndex = 6;
            this.musteriIslemleriButton.Text = "Müşteri İşlemleri";
            this.musteriIslemleriButton.UseVisualStyleBackColor = true;
            // 
            // talepIslemleriButton
            // 
            this.talepIslemleriButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.talepIslemleriButton.Location = new System.Drawing.Point(444, 126);
            this.talepIslemleriButton.Name = "talepIslemleriButton";
            this.talepIslemleriButton.Size = new System.Drawing.Size(200, 50);
            this.talepIslemleriButton.TabIndex = 7;
            this.talepIslemleriButton.Text = "Talep İşlemleri";
            this.talepIslemleriButton.UseVisualStyleBackColor = true;
            // 
            // musteriOzetButton
            // 
            this.musteriOzetButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.musteriOzetButton.Location = new System.Drawing.Point(650, 126);
            this.musteriOzetButton.Name = "musteriOzetButton";
            this.musteriOzetButton.Size = new System.Drawing.Size(200, 50);
            this.musteriOzetButton.TabIndex = 8;
            this.musteriOzetButton.Text = "Müşteri Özeti Görüntüleme";
            this.musteriOzetButton.UseVisualStyleBackColor = true;
            // 
            // musteriTemsilcisi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.musteriOzetButton);
            this.Controls.Add(this.talepIslemleriButton);
            this.Controls.Add(this.musteriIslemleriButton);
            this.Name = "musteriTemsilcisi";
            this.Text = "musteriTemsilcisi";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button musteriIslemleriButton;
        private System.Windows.Forms.Button talepIslemleriButton;
        private System.Windows.Forms.Button musteriOzetButton;
    }
}