namespace Proiect_PAW_Chivu_Evelyn_Andrei
{
    partial class MainForm
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
            components = new System.ComponentModel.Container();
            errorProvider1 = new ErrorProvider(components);
            contextMenuStrip1 = new ContextMenuStrip(components);
            tableLayoutPanel1 = new TableLayoutPanel();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            groupBox_Dashboard = new GroupBox();
            textBox_Titlu = new TextBox();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox_Dashboard.SuspendLayout();
            SuspendLayout();
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel1.BackColor = Color.Transparent;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(button3, 0, 2);
            tableLayoutPanel1.Controls.Add(button2, 0, 1);
            tableLayoutPanel1.Controls.Add(button1, 0, 0);
            tableLayoutPanel1.Location = new Point(0, 49);
            tableLayoutPanel1.Margin = new Padding(0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 32.3922729F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 34.1753349F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Size = new Size(200, 665);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.MenuBar;
            button3.Dock = DockStyle.Fill;
            button3.Font = new Font("Segoe UI", 30F);
            button3.Location = new Point(3, 445);
            button3.Name = "button3";
            button3.Size = new Size(194, 217);
            button3.TabIndex = 2;
            button3.Text = "Adresses";
            button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.Menu;
            button2.Dock = DockStyle.Left;
            button2.Font = new Font("Segoe UI", 30F);
            button2.Location = new Point(3, 218);
            button2.Name = "button2";
            button2.Size = new Size(194, 221);
            button2.TabIndex = 1;
            button2.Text = "Clients";
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Menu;
            button1.Dock = DockStyle.Fill;
            button1.Font = new Font("Segoe UI", 30F);
            button1.Location = new Point(3, 3);
            button1.Name = "button1";
            button1.Size = new Size(194, 209);
            button1.TabIndex = 0;
            button1.Text = "Pizza";
            button1.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.Image = Resources.Resource1.PIzza_Falling;
            pictureBox1.Location = new Point(203, 48);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(718, 677);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // groupBox_Dashboard
            // 
            groupBox_Dashboard.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox_Dashboard.BackgroundImageLayout = ImageLayout.None;
            groupBox_Dashboard.Controls.Add(textBox_Titlu);
            groupBox_Dashboard.FlatStyle = FlatStyle.Flat;
            groupBox_Dashboard.Font = new Font("Segoe UI", 15F);
            groupBox_Dashboard.ForeColor = Color.FromArgb(192, 0, 192);
            groupBox_Dashboard.Location = new Point(0, 0);
            groupBox_Dashboard.Name = "groupBox_Dashboard";
            groupBox_Dashboard.Size = new Size(921, 45);
            groupBox_Dashboard.TabIndex = 5;
            groupBox_Dashboard.TabStop = false;
            // 
            // textBox_Titlu
            // 
            textBox_Titlu.BackColor = SystemColors.Control;
            textBox_Titlu.BorderStyle = BorderStyle.None;
            textBox_Titlu.Font = new Font("Segoe UI", 16F);
            textBox_Titlu.ForeColor = Color.Red;
            textBox_Titlu.Location = new Point(297, 10);
            textBox_Titlu.Name = "textBox_Titlu";
            textBox_Titlu.Size = new Size(297, 29);
            textBox_Titlu.TabIndex = 0;
            textBox_Titlu.Text = "DASHBOARD";
            textBox_Titlu.TextAlign = HorizontalAlignment.Center;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(921, 722);
            Controls.Add(groupBox_Dashboard);
            Controls.Add(pictureBox1);
            Controls.Add(tableLayoutPanel1);
            Name = "MainForm";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox_Dashboard.ResumeLayout(false);
            groupBox_Dashboard.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ErrorProvider errorProvider1;
        private ContextMenuStrip contextMenuStrip1;
        private TableLayoutPanel tableLayoutPanel1;
        private Button button1;
        private Button button2;
        private Button button3;
        private PictureBox pictureBox1;
        private GroupBox groupBox_Dashboard;
        private TextBox textBox_Titlu;
    }
}