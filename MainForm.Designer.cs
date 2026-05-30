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
            fileToolStripMenuItem = new ToolStripMenuItem();
            pizzaToolStripMenuItem = new ToolStripMenuItem();
            clientsToolStripMenuItem = new ToolStripMenuItem();
            adressToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripMenuItem();
            tableLayoutPanel1 = new TableLayoutPanel();
            btn_Adresses = new Button();
            btn_Clients = new Button();
            btn_Pizza = new Button();
            pictureBox1 = new PictureBox();
            groupBox_Dashboard = new GroupBox();
            textBox_Titlu = new TextBox();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            contextMenuStrip1.SuspendLayout();
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
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, pizzaToolStripMenuItem, clientsToolStripMenuItem, adressToolStripMenuItem, toolStripMenuItem2 });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(181, 136);
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(180, 22);
            fileToolStripMenuItem.Text = "&File";
            // 
            // pizzaToolStripMenuItem
            // 
            pizzaToolStripMenuItem.Name = "pizzaToolStripMenuItem";
            pizzaToolStripMenuItem.Size = new Size(180, 22);
            pizzaToolStripMenuItem.Text = "&Pizza";
            pizzaToolStripMenuItem.Click += btn_Pizza_Click;
            // 
            // clientsToolStripMenuItem
            // 
            clientsToolStripMenuItem.Name = "clientsToolStripMenuItem";
            clientsToolStripMenuItem.Size = new Size(180, 22);
            clientsToolStripMenuItem.Text = "&Clients";
            clientsToolStripMenuItem.Click += btn_Clients_Click;
            // 
            // adressToolStripMenuItem
            // 
            adressToolStripMenuItem.Name = "adressToolStripMenuItem";
            adressToolStripMenuItem.Size = new Size(180, 22);
            adressToolStripMenuItem.Text = "&Adress";
            adressToolStripMenuItem.Click += btn_Adresses_Click;
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(180, 22);
            toolStripMenuItem2.Text = "&Exit";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel1.BackColor = Color.Transparent;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(btn_Adresses, 0, 2);
            tableLayoutPanel1.Controls.Add(btn_Clients, 0, 1);
            tableLayoutPanel1.Controls.Add(btn_Pizza, 0, 0);
            tableLayoutPanel1.Location = new Point(0, 49);
            tableLayoutPanel1.Margin = new Padding(0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 32.3922729F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 34.1753349F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Size = new Size(200, 683);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // btn_Adresses
            // 
            btn_Adresses.BackColor = SystemColors.MenuBar;
            btn_Adresses.Dock = DockStyle.Fill;
            btn_Adresses.Font = new Font("Segoe UI", 30F);
            btn_Adresses.Location = new Point(3, 457);
            btn_Adresses.Name = "btn_Adresses";
            btn_Adresses.Size = new Size(194, 223);
            btn_Adresses.TabIndex = 2;
            btn_Adresses.Text = "Adresses";
            btn_Adresses.UseVisualStyleBackColor = false;
            btn_Adresses.Click += btn_Adresses_Click;
            // 
            // btn_Clients
            // 
            btn_Clients.BackColor = SystemColors.Menu;
            btn_Clients.Dock = DockStyle.Left;
            btn_Clients.Font = new Font("Segoe UI", 30F);
            btn_Clients.Location = new Point(3, 224);
            btn_Clients.Name = "btn_Clients";
            btn_Clients.Size = new Size(194, 227);
            btn_Clients.TabIndex = 1;
            btn_Clients.Text = "Clients";
            btn_Clients.UseVisualStyleBackColor = false;
            btn_Clients.Click += btn_Clients_Click;
            // 
            // btn_Pizza
            // 
            btn_Pizza.BackColor = SystemColors.Menu;
            btn_Pizza.Dock = DockStyle.Fill;
            btn_Pizza.Font = new Font("Segoe UI", 30F);
            btn_Pizza.Location = new Point(3, 3);
            btn_Pizza.Name = "btn_Pizza";
            btn_Pizza.Size = new Size(194, 215);
            btn_Pizza.TabIndex = 0;
            btn_Pizza.Text = "Pizza";
            btn_Pizza.UseVisualStyleBackColor = false;
            btn_Pizza.Click += btn_Pizza_Click;
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
            Load += MainForm_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            contextMenuStrip1.ResumeLayout(false);
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
        private Button btn_Pizza;
        private Button btn_Clients;
        private Button btn_Adresses;
        private PictureBox pictureBox1;
        private GroupBox groupBox_Dashboard;
        private TextBox textBox_Titlu;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem pizzaToolStripMenuItem;
        private ToolStripMenuItem clientsToolStripMenuItem;
        private ToolStripMenuItem adressToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem2;
    }
}