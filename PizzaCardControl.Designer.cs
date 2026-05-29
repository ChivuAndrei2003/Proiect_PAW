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
            lblBuy = new Button();
            lblPicture = new PictureBox();
            groupBox1 = new GroupBox();
            label_Pret_Produs = new Label();
            label_Numee_Produs = new Label();
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
            panel1.Location = new Point(167, 184);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(30, 20, 30, 20);
            panel1.Size = new Size(361, 419);
            panel1.TabIndex = 0;
            // 
            // lblBuy
            // 
            lblBuy.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblBuy.AutoSize = true;
            lblBuy.BackColor = Color.Lime;
            lblBuy.BackgroundImageLayout = ImageLayout.None;
            lblBuy.FlatAppearance.BorderColor = SystemColors.ActiveCaption;
            lblBuy.FlatStyle = FlatStyle.Flat;
            lblBuy.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblBuy.Location = new Point(30, 340);
            lblBuy.Margin = new Padding(0);
            lblBuy.Name = "lblBuy";
            lblBuy.Size = new Size(307, 59);
            lblBuy.TabIndex = 2;
            lblBuy.Text = "BUY";
            lblBuy.UseVisualStyleBackColor = false;
            lblBuy.Click += lblBuy_Click;
            // 
            // lblPicture
            // 
            lblPicture.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblPicture.Location = new Point(30, 20);
            lblPicture.Margin = new Padding(0);
            lblPicture.Name = "lblPicture";
            lblPicture.Size = new Size(307, 189);
            lblPicture.TabIndex = 0;
            lblPicture.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(label_Pret_Produs);
            groupBox1.Controls.Add(label_Numee_Produs);
            groupBox1.Location = new Point(33, 236);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(304, 93);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Enter += groupBox1_Enter;
            // 
            // label_Pret_Produs
            // 
            label_Pret_Produs.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label_Pret_Produs.AutoSize = true;
            label_Pret_Produs.Font = new Font("Segoe UI", 20F);
            label_Pret_Produs.Location = new Point(107, 13);
            label_Pret_Produs.Margin = new Padding(0);
            label_Pret_Produs.Name = "label_Pret_Produs";
            label_Pret_Produs.Size = new Size(75, 37);
            label_Pret_Produs.TabIndex = 3;
            label_Pret_Produs.Text = "price";
            label_Pret_Produs.TextAlign = ContentAlignment.MiddleCenter;
            label_Pret_Produs.Click += label1_Click;
            // 
            // label_Numee_Produs
            // 
            label_Numee_Produs.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label_Numee_Produs.AutoSize = true;
            label_Numee_Produs.Font = new Font("Segoe UI", 20F);
            label_Numee_Produs.Location = new Point(99, 50);
            label_Numee_Produs.Margin = new Padding(0);
            label_Numee_Produs.Name = "label_Numee_Produs";
            label_Numee_Produs.Size = new Size(83, 37);
            label_Numee_Produs.TabIndex = 4;
            label_Numee_Produs.Text = "name";
            label_Numee_Produs.TextAlign = ContentAlignment.MiddleCenter;
            label_Numee_Produs.Click += label_Numee_Produs_Click;
            // 
            // PizzaCardControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "PizzaCardControl";
            Size = new Size(954, 829);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)lblPicture).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox lblPicture;
        private Button lblBuy;
        private Label label_Pret_Produs;
        private Label label_Numee_Produs;
        private GroupBox groupBox1;
    }
}
