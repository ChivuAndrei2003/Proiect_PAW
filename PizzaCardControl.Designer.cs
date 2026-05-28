namespace Proiect_PAW_Chivu_Evelyn_Andrei
{
    partial class PizzaCardControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            lblPrice = new Label();
            lblBuy = new Button();
            lblPicture = new PictureBox();
            label1 = new Label();
            groupBox1 = new GroupBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)lblPicture).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel1.BackColor = Color.LightGoldenrodYellow;
            panel1.Controls.Add(lblBuy);
            panel1.Controls.Add(lblPicture);
            panel1.Controls.Add(groupBox1);
            panel1.Location = new Point(246, 166);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(30, 20, 30, 20);
            panel1.Size = new Size(337, 427);
            panel1.TabIndex = 0;
            // 
            // lblPrice
            // 
            lblPrice.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblPrice.AutoSize = true;
            lblPrice.Font = new Font("Segoe UI", 20F);
            lblPrice.Location = new Point(94, 58);
            lblPrice.Margin = new Padding(0, 0, 0, 0);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(75, 37);
            lblPrice.TabIndex = 3;
            lblPrice.Text = "price";
            lblPrice.TextAlign = ContentAlignment.MiddleCenter;
            lblPrice.Click += label1_Click;
            // 
            // lblBuy
            // 
            lblBuy.BackColor = Color.Lime;
            lblBuy.BackgroundImageLayout = ImageLayout.None;
            lblBuy.FlatAppearance.BorderColor = SystemColors.ActiveCaption;
            lblBuy.FlatStyle = FlatStyle.Flat;
            lblBuy.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblBuy.Location = new Point(30, 340);
            lblBuy.Margin = new Padding(0);
            lblBuy.Name = "lblBuy";
            lblBuy.Size = new Size(280, 48);
            lblBuy.TabIndex = 2;
            lblBuy.Text = "BUY";
            lblBuy.UseVisualStyleBackColor = false;
            lblBuy.Click += lblBuy_Click;
            // 
            // lblPicture
            // 
            lblPicture.Location = new Point(30, 20);
            lblPicture.Margin = new Padding(0);
            lblPicture.Name = "lblPicture";
            lblPicture.Size = new Size(280, 196);
            lblPicture.TabIndex = 0;
            lblPicture.TabStop = false;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(94, 19);
            label1.Margin = new Padding(0, 0, 0, 0);
            label1.Name = "label1";
            label1.Size = new Size(83, 37);
            label1.TabIndex = 4;
            label1.Text = "name";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            groupBox1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            groupBox1.Controls.Add(lblPrice);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(30, 233);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(279, 98);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            // 
            // PizzaCardControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "PizzaCardControl";
            Size = new Size(954, 829);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)lblPicture).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox lblPicture;
        private Button lblBuy;
        private Label lblPrice;
        private Label label1;
        private GroupBox groupBox1;
    }
}
