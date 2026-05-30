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
            ContextMenuStrip = new ContextMenuStrip(components);
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
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem1 = new ToolStripMenuItem();
            pizzaToolStripMenuItem1 = new ToolStripMenuItem();
            clientsToolStripMenuItem1 = new ToolStripMenuItem();
            adressesToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            ContextMenuStrip.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox_Dashboard.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // ContextMenuStrip
            // 
            ContextMenuStrip.Items.AddRange(new ToolStripItem[] { pizzaToolStripMenuItem, clientsToolStripMenuItem, adressToolStripMenuItem, toolStripMenuItem2 });
            ContextMenuStrip.Name = "contextMenuStrip1";
            ContextMenuStrip.Size = new Size(143, 92);
            // 
            // pizzaToolStripMenuItem
            // 
            pizzaToolStripMenuItem.Name = "pizzaToolStripMenuItem";
            pizzaToolStripMenuItem.Size = new Size(142, 22);
            pizzaToolStripMenuItem.Text = "Open Pizza";
            pizzaToolStripMenuItem.Click += btn_Pizza_Click;
            // 
            // clientsToolStripMenuItem
            // 
            clientsToolStripMenuItem.Name = "clientsToolStripMenuItem";
            clientsToolStripMenuItem.Size = new Size(142, 22);
            clientsToolStripMenuItem.Text = "Open Clients";
            clientsToolStripMenuItem.Click += btn_Clients_Click;
            // 
            // adressToolStripMenuItem
            // 
            adressToolStripMenuItem.Name = "adressToolStripMenuItem";
            adressToolStripMenuItem.Size = new Size(142, 22);
            adressToolStripMenuItem.Text = "Open Adress";
            adressToolStripMenuItem.Click += btn_Adresses_Click;
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(142, 22);
            toolStripMenuItem2.Text = "&Exit";
            toolStripMenuItem2.Click += exitToolStripMenuItem_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel1.BackColor = Color.Transparent;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ContextMenuStrip = ContextMenuStrip;
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
            tableLayoutPanel1.Size = new Size(200, 704);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // btn_Adresses
            // 
            btn_Adresses.BackColor = SystemColors.MenuBar;
            btn_Adresses.Dock = DockStyle.Fill;
            btn_Adresses.Font = new Font("Segoe UI", 30F);
            btn_Adresses.Location = new Point(3, 471);
            btn_Adresses.Name = "btn_Adresses";
            btn_Adresses.Size = new Size(194, 230);
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
            btn_Clients.Location = new Point(3, 231);
            btn_Clients.Name = "btn_Clients";
            btn_Clients.Size = new Size(194, 234);
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
            btn_Pizza.Size = new Size(194, 222);
            btn_Pizza.TabIndex = 0;
            btn_Pizza.Text = "Pizza";
            btn_Pizza.UseVisualStyleBackColor = false;
            btn_Pizza.Click += btn_Pizza_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.ContextMenuStrip = ContextMenuStrip;
            pictureBox1.Image = Resources.Resource1.PIzza_Falling;
            pictureBox1.Location = new Point(203, 52);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(995, 676);
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
            groupBox_Dashboard.Controls.Add(menuStrip1);
            groupBox_Dashboard.FlatStyle = FlatStyle.Flat;
            groupBox_Dashboard.Font = new Font("Segoe UI", 15F);
            groupBox_Dashboard.ForeColor = Color.FromArgb(192, 0, 192);
            groupBox_Dashboard.Location = new Point(0, 1);
            groupBox_Dashboard.Name = "groupBox_Dashboard";
            groupBox_Dashboard.Size = new Size(1198, 45);
            groupBox_Dashboard.TabIndex = 5;
            groupBox_Dashboard.TabStop = false;
            groupBox_Dashboard.Enter += groupBox_Dashboard_Enter;
            // 
            // textBox_Titlu
            // 
            textBox_Titlu.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox_Titlu.BackColor = SystemColors.Control;
            textBox_Titlu.BorderStyle = BorderStyle.None;
            textBox_Titlu.Font = new Font("Segoe UI", 16F);
            textBox_Titlu.ForeColor = Color.Red;
            textBox_Titlu.Location = new Point(320, 0);
            textBox_Titlu.Name = "textBox_Titlu";
            textBox_Titlu.Size = new Size(516, 29);
            textBox_Titlu.TabIndex = 0;
            textBox_Titlu.Text = "DASHBOARD";
            textBox_Titlu.TextAlign = HorizontalAlignment.Center;
            textBox_Titlu.TextChanged += textBox_Titlu_TextChanged;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.Control;
            menuStrip1.Dock = DockStyle.None;
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem1 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(45, 24);
            menuStrip1.TabIndex = 6;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem1
            // 
            fileToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { pizzaToolStripMenuItem1, clientsToolStripMenuItem1, adressesToolStripMenuItem, exitToolStripMenuItem });
            fileToolStripMenuItem1.Name = "fileToolStripMenuItem1";
            fileToolStripMenuItem1.Size = new Size(37, 20);
            fileToolStripMenuItem1.Text = "&File";
            fileToolStripMenuItem1.Click += fileToolStripMenuItem1_Click;
            // 
            // pizzaToolStripMenuItem1
            // 
            pizzaToolStripMenuItem1.Name = "pizzaToolStripMenuItem1";
            pizzaToolStripMenuItem1.Size = new Size(120, 22);
            pizzaToolStripMenuItem1.Text = "&Pizza";
            pizzaToolStripMenuItem1.Click += btn_Pizza_Click;
            // 
            // clientsToolStripMenuItem1
            // 
            clientsToolStripMenuItem1.Name = "clientsToolStripMenuItem1";
            clientsToolStripMenuItem1.Size = new Size(120, 22);
            clientsToolStripMenuItem1.Text = "&Clients";
            clientsToolStripMenuItem1.Click += btn_Clients_Click;
            // 
            // adressesToolStripMenuItem
            // 
            adressesToolStripMenuItem.Name = "adressesToolStripMenuItem";
            adressesToolStripMenuItem.Size = new Size(120, 22);
            adressesToolStripMenuItem.Text = "&Adresses";
            adressesToolStripMenuItem.Click += btn_Adresses_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(120, 22);
            exitToolStripMenuItem.Text = "E&xit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1198, 732);
            Controls.Add(pictureBox1);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(groupBox_Dashboard);
            Name = "MainForm";
            Text = "Form1";
            Load += MainForm_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ContextMenuStrip.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox_Dashboard.ResumeLayout(false);
            groupBox_Dashboard.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ErrorProvider errorProvider1;
        private ContextMenuStrip ContextMenuStrip;
        private TableLayoutPanel tableLayoutPanel1;
        private Button btn_Pizza;
        private Button btn_Clients;
        private Button btn_Adresses;
        private PictureBox pictureBox1;
        private GroupBox groupBox_Dashboard;
        private TextBox textBox_Titlu;
        private ToolStripMenuItem pizzaToolStripMenuItem;
        private ToolStripMenuItem clientsToolStripMenuItem;
        private ToolStripMenuItem adressToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem2;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem1;
        private ToolStripMenuItem pizzaToolStripMenuItem1;
        private ToolStripMenuItem clientsToolStripMenuItem1;
        private ToolStripMenuItem adressesToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
    }
}