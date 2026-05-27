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
            lblPicture = new PictureBox();
            lblName = new Label();
            lblBuy = new Button();
            lblPrice = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)lblPicture).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.LightGoldenrodYellow;
            panel1.Controls.Add(lblPrice);
            panel1.Controls.Add(lblBuy);
            panel1.Controls.Add(lblName);
            panel1.Controls.Add(lblPicture);
            panel1.Location = new Point(233, 166);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(30, 20, 30, 20);
            panel1.Size = new Size(322, 400);
            panel1.TabIndex = 0;
            // 
            // lblPicture
            // 
            lblPicture.Location = new Point(30, 22);
            lblPicture.Margin = new Padding(0);
            lblPicture.Name = "lblPicture";
            lblPicture.Size = new Size(262, 196);
            lblPicture.TabIndex = 0;
            lblPicture.TabStop = false;
            // 
            // lblName
            // 
            lblName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 20F);
            lblName.Location = new Point(99, 238);
            lblName.Name = "lblName";
            lblName.Size = new Size(118, 37);
            lblName.TabIndex = 1;
            lblName.Text = "lblName";
            lblName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblBuy
            // 
            lblBuy.BackColor = Color.Lime;
            lblBuy.FlatAppearance.BorderColor = SystemColors.ActiveCaption;
            lblBuy.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBuy.Location = new Point(27, 329);
            lblBuy.Margin = new Padding(0);
            lblBuy.Name = "lblBuy";
            lblBuy.Size = new Size(262, 48);
            lblBuy.TabIndex = 2;
            lblBuy.Text = "BUY";
            lblBuy.UseVisualStyleBackColor = false;
            lblBuy.Click += lblBuy_Click;
            // 
            // lblPrice
            // 
            lblPrice.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblPrice.AutoSize = true;
            lblPrice.Font = new Font("Segoe UI", 20F);
            lblPrice.Location = new Point(99, 292);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(104, 37);
            lblPrice.TabIndex = 3;
            lblPrice.Text = "lblPrice";
            lblPrice.TextAlign = ContentAlignment.MiddleCenter;
            lblPrice.Click += label1_Click;
            // 
            // PizzaCardControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "PizzaCardControl";
            Size = new Size(878, 829);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)lblPicture).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox lblPicture;
        private Label lblName;
        private Button lblBuy;
        private Label lblPrice;
    }
}
