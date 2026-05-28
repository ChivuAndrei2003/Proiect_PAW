namespace Proiect_PAW_Chivu_Evelyn_Andrei
{
    partial class ClientsForm
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
            panel1 = new Panel();
            textBox1 = new TextBox();
            groupBox2 = new GroupBox();
            button3 = new Button();
            button2 = new Button();
            btnAdd = new Button();
            groupBox1 = new GroupBox();
            label1 = new Label();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            panel1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.InactiveCaption;
            panel1.Controls.Add(textBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1038, 65);
            panel1.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox1.BackColor = SystemColors.InactiveCaption;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Cursor = Cursors.Cross;
            textBox1.Font = new Font("Segoe UI", 15F);
            textBox1.ForeColor = SystemColors.ActiveCaptionText;
            textBox1.Location = new Point(0, 18);
            textBox1.Margin = new Padding(0);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(1038, 27);
            textBox1.TabIndex = 0;
            textBox1.Text = "Clienti";
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.AppWorkspace;
            groupBox2.Controls.Add(button3);
            groupBox2.Controls.Add(button2);
            groupBox2.Controls.Add(btnAdd);
            groupBox2.FlatStyle = FlatStyle.Flat;
            groupBox2.Location = new Point(46, 255);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(302, 30);
            groupBox2.TabIndex = 58;
            groupBox2.TabStop = false;
            // 
            // button3
            // 
            button3.Location = new Point(206, 0);
            button3.Margin = new Padding(4, 3, 4, 3);
            button3.Name = "button3";
            button3.Size = new Size(82, 30);
            button3.TabIndex = 54;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(109, 0);
            button2.Margin = new Padding(4, 3, 4, 3);
            button2.Name = "button2";
            button2.Size = new Size(82, 30);
            button2.TabIndex = 53;
            button2.Text = "Update";
            button2.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(7, 0);
            btnAdd.Margin = new Padding(4, 3, 4, 3);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(82, 30);
            btnAdd.TabIndex = 52;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(0, 68);
            groupBox1.Margin = new Padding(4, 3, 4, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 3, 4, 3);
            groupBox1.Size = new Size(1038, 139);
            groupBox1.TabIndex = 56;
            groupBox1.TabStop = false;
            groupBox1.Text = "New Participant";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(46, 39);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(81, 15);
            label1.TabIndex = 1;
            label1.Text = "Nume client : ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(46, 82);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(87, 15);
            label2.TabIndex = 3;
            label2.Text = "Adresa livrare : ";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Bottom;
            dataGridView1.Location = new Point(0, 347);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(1038, 173);
            dataGridView1.TabIndex = 55;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(141, 36);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(120, 23);
            textBox2.TabIndex = 57;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(141, 82);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(120, 23);
            textBox3.TabIndex = 58;
            // 
            // ClientsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1038, 520);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Name = "ClientsForm";
            Text = "ClientsForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox textBox1;
        private GroupBox groupBox2;
        private Button button3;
        private Button button2;
        private Button btnAdd;
        private GroupBox groupBox1;
        private Label label1;
        private Label label2;
        private DataGridView dataGridView1;
        private TextBox textBox3;
        private TextBox textBox2;
    }
}