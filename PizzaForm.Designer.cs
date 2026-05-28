namespace Proiect_PAW_Chivu_Evelyn_Andrei
{
    partial class PizzaForm
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
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            textBox1 = new TextBox();
            dataGridView1 = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            numeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            pretDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            imagePathDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            pizzaBindingSource = new BindingSource(components);
            groupBox1 = new GroupBox();
            button1 = new Button();
            pbPaste = new PictureBox();
            numericUpDown1 = new NumericUpDown();
            comboBox1 = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            btnAdd = new Button();
            listView1 = new ListView();
            groupBox2 = new GroupBox();
            button3 = new Button();
            button2 = new Button();
            numericUpDown2 = new NumericUpDown();
            label3 = new Label();
            nume = new DataGridViewTextBoxColumn();
            cantitate = new DataGridViewTextBoxColumn();
            pret = new DataGridViewTextBoxColumn();
            imagePath = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pizzaBindingSource).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbPaste).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.InactiveCaption;
            panel1.Controls.Add(textBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1044, 65);
            panel1.TabIndex = 0;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox1.BackColor = SystemColors.InactiveCaption;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Cursor = Cursors.Cross;
            textBox1.Font = new Font("Segoe UI", 15F);
            textBox1.ForeColor = SystemColors.ActiveCaptionText;
            textBox1.Location = new Point(260, 21);
            textBox1.Margin = new Padding(0);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(425, 27);
            textBox1.TabIndex = 0;
            textBox1.Text = "Pizza In Stock";
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, numeDataGridViewTextBoxColumn, pretDataGridViewTextBoxColumn, imagePathDataGridViewTextBoxColumn, nume, cantitate, pret, imagePath });
            dataGridView1.DataSource = pizzaBindingSource;
            dataGridView1.Dock = DockStyle.Bottom;
            dataGridView1.Location = new Point(0, 449);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(1044, 231);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            idDataGridViewTextBoxColumn.DataPropertyName = "id";
            idDataGridViewTextBoxColumn.HeaderText = "id";
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // numeDataGridViewTextBoxColumn
            // 
            numeDataGridViewTextBoxColumn.DataPropertyName = "nume";
            numeDataGridViewTextBoxColumn.HeaderText = "nume";
            numeDataGridViewTextBoxColumn.Name = "numeDataGridViewTextBoxColumn";
            // 
            // pretDataGridViewTextBoxColumn
            // 
            pretDataGridViewTextBoxColumn.DataPropertyName = "pret";
            pretDataGridViewTextBoxColumn.HeaderText = "pret";
            pretDataGridViewTextBoxColumn.Name = "pretDataGridViewTextBoxColumn";
            // 
            // imagePathDataGridViewTextBoxColumn
            // 
            imagePathDataGridViewTextBoxColumn.DataPropertyName = "imagePath";
            imagePathDataGridViewTextBoxColumn.HeaderText = "imagePath";
            imagePathDataGridViewTextBoxColumn.Name = "imagePathDataGridViewTextBoxColumn";
            // 
            // pizzaBindingSource
            // 
            pizzaBindingSource.DataSource = typeof(Entities.Pizza);
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(numericUpDown2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(pbPaste);
            groupBox1.Controls.Add(numericUpDown1);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label4);
            groupBox1.Location = new Point(0, 71);
            groupBox1.Margin = new Padding(4, 3, 4, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 3, 4, 3);
            groupBox1.Size = new Size(1044, 178);
            groupBox1.TabIndex = 13;
            groupBox1.TabStop = false;
            groupBox1.Text = "New Participant";
            // 
            // button1
            // 
            button1.Location = new Point(611, 126);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 58;
            button1.Text = "Adauga imagine";
            button1.UseVisualStyleBackColor = true;
            // 
            // pbPaste
            // 
            pbPaste.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pbPaste.BackColor = SystemColors.ControlDark;
            pbPaste.BorderStyle = BorderStyle.Fixed3D;
            pbPaste.Location = new Point(571, 37);
            pbPaste.Margin = new Padding(4, 3, 4, 3);
            pbPaste.Name = "pbPaste";
            pbPaste.Size = new Size(176, 66);
            pbPaste.SizeMode = PictureBoxSizeMode.StretchImage;
            pbPaste.TabIndex = 57;
            pbPaste.TabStop = false;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(141, 80);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(120, 23);
            numericUpDown1.TabIndex = 56;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "\"country\"", "\"All Cheese\"", "\"romaneasca\"", "\"cu ton\"", "\"mediteraneana\"", "\"rustica\"", "\"texas\"", "\"custom\"" });
            comboBox1.Location = new Point(141, 37);
            comboBox1.MaxLength = 15;
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 55;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(45, 39);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(78, 15);
            label1.TabIndex = 1;
            label1.Text = "Nume Pizza : ";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(45, 82);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(34, 15);
            label2.TabIndex = 3;
            label2.Text = "Pret :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(446, 63);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(101, 15);
            label4.TabIndex = 6;
            label4.Text = "Imagine Custom :";
            // 
            // btnAdd
            // 
            btnAdd.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            btnAdd.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnAdd.Location = new Point(0, 0);
            btnAdd.Margin = new Padding(4, 3, 4, 3);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(89, 62);
            btnAdd.TabIndex = 52;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // listView1
            // 
            listView1.Location = new Point(228, 268);
            listView1.Name = "listView1";
            listView1.Size = new Size(8, 8);
            listView1.TabIndex = 53;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.ActiveCaption;
            groupBox2.Controls.Add(button3);
            groupBox2.Controls.Add(button2);
            groupBox2.Controls.Add(btnAdd);
            groupBox2.FlatStyle = FlatStyle.Flat;
            groupBox2.Location = new Point(287, 295);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(339, 62);
            groupBox2.TabIndex = 54;
            groupBox2.TabStop = false;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            button3.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button3.Location = new Point(249, 0);
            button3.Margin = new Padding(0, 0, 0, 0);
            button3.Name = "button3";
            button3.Size = new Size(90, 62);
            button3.TabIndex = 54;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            button2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button2.Location = new Point(126, 0);
            button2.Margin = new Padding(0, 0, 0, 0);
            button2.Name = "button2";
            button2.Size = new Size(82, 62);
            button2.TabIndex = 53;
            button2.Text = "Update";
            button2.UseVisualStyleBackColor = true;
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(141, 124);
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(120, 23);
            numericUpDown2.TabIndex = 60;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(45, 126);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(61, 15);
            label3.TabIndex = 59;
            label3.Text = "Cantitate :";
            // 
            // nume
            // 
            nume.DataPropertyName = "nume";
            nume.HeaderText = "nume";
            nume.Name = "nume";
            // 
            // cantitate
            // 
            cantitate.DataPropertyName = "cantitate";
            cantitate.HeaderText = "cantitate";
            cantitate.Name = "cantitate";
            // 
            // pret
            // 
            pret.DataPropertyName = "pret";
            pret.HeaderText = "pret";
            pret.Name = "pret";
            // 
            // imagePath
            // 
            imagePath.DataPropertyName = "imagePath";
            imagePath.HeaderText = "imagePath";
            imagePath.Name = "imagePath";
            // 
            // PizzaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1044, 680);
            Controls.Add(groupBox2);
            Controls.Add(listView1);
            Controls.Add(groupBox1);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Name = "PizzaForm";
            Text = "PizzaForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pizzaBindingSource).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbPaste).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox textBox1;
        private DataGridView dataGridView1;
        private BindingSource pizzaBindingSource;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn numeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn descriereDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn pretDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn imagePathDataGridViewTextBoxColumn;
        private GroupBox groupBox1;
        private Button btnAdd;
        private Label label1;
        private Label label2;
        private Label label4;
        private ComboBox comboBox1;
        private NumericUpDown numericUpDown1;
        private Button button1;
        internal PictureBox pbPaste;
        private ListView listView1;
        private GroupBox groupBox2;
        private Button button3;
        private Button button2;
        private NumericUpDown numericUpDown2;
        private Label label3;
        private DataGridViewTextBoxColumn nume;
        private DataGridViewTextBoxColumn cantitate;
        private DataGridViewTextBoxColumn pret;
        private DataGridViewTextBoxColumn imagePath;
    }
}