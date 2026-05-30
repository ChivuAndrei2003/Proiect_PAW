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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PizzaForm));
            pizzaBindingSource = new BindingSource(components);
            groupBox1 = new GroupBox();
            btn_Delete = new Button();
            textBox_Cantitate = new NumericUpDown();
            btn_Update = new Button();
            btn_Add = new Button();
            label3 = new Label();
            button_Adauga_Imagine = new Button();
            pb_Imagine_Custom = new PictureBox();
            textBox_Pret = new NumericUpDown();
            comboBox1 = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            toolStrip1 = new ToolStrip();
            toolStripButton3 = new ToolStripButton();
            toolStripButton1 = new ToolStripButton();
            toolStripButton2 = new ToolStripButton();
            toolStripButton4 = new ToolStripDropDownButton();
            serializeToolStripMenuItem = new ToolStripMenuItem();
            deserealizeToolStripMenuItem = new ToolStripMenuItem();
            textFileToolStripMenuItem = new ToolStripMenuItem();
            btnTextFile = new ToolStripMenuItem();
            flowLayoutPanel1 = new FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)pizzaBindingSource).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)textBox_Cantitate).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb_Imagine_Custom).BeginInit();
            ((System.ComponentModel.ISupportInitialize)textBox_Pret).BeginInit();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(btn_Delete);
            groupBox1.Controls.Add(textBox_Cantitate);
            groupBox1.Controls.Add(btn_Update);
            groupBox1.Controls.Add(btn_Add);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(button_Adauga_Imagine);
            groupBox1.Controls.Add(pb_Imagine_Custom);
            groupBox1.Controls.Add(textBox_Pret);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label4);
            groupBox1.Location = new Point(0, 28);
            groupBox1.Margin = new Padding(4, 3, 4, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 3, 4, 3);
            groupBox1.Size = new Size(1099, 276);
            groupBox1.TabIndex = 13;
            groupBox1.TabStop = false;
            groupBox1.Text = "Adauga pizza in stock :";
            // 
            // btn_Delete
            // 
            btn_Delete.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            btn_Delete.Location = new Point(270, 197);
            btn_Delete.Margin = new Padding(0);
            btn_Delete.Name = "btn_Delete";
            btn_Delete.Size = new Size(83, 44);
            btn_Delete.TabIndex = 54;
            btn_Delete.Text = "Delete";
            btn_Delete.UseVisualStyleBackColor = true;
            btn_Delete.Click += btn_Delete_Click;
            // 
            // textBox_Cantitate
            // 
            textBox_Cantitate.Location = new Point(141, 124);
            textBox_Cantitate.Name = "textBox_Cantitate";
            textBox_Cantitate.Size = new Size(179, 23);
            textBox_Cantitate.TabIndex = 60;
            // 
            // btn_Update
            // 
            btn_Update.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            btn_Update.Location = new Point(155, 197);
            btn_Update.Margin = new Padding(0);
            btn_Update.Name = "btn_Update";
            btn_Update.Size = new Size(90, 44);
            btn_Update.TabIndex = 53;
            btn_Update.Text = "Update";
            btn_Update.UseVisualStyleBackColor = true;
            btn_Update.Click += btn_Update_Click;
            // 
            // btn_Add
            // 
            btn_Add.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            btn_Add.Location = new Point(45, 197);
            btn_Add.Margin = new Padding(4, 3, 4, 3);
            btn_Add.Name = "btn_Add";
            btn_Add.Size = new Size(83, 44);
            btn_Add.TabIndex = 52;
            btn_Add.Text = "Add";
            btn_Add.UseVisualStyleBackColor = true;
            btn_Add.Click += btn_Add_Click;
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
            // button_Adauga_Imagine
            // 
            button_Adauga_Imagine.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            button_Adauga_Imagine.Location = new Point(646, 243);
            button_Adauga_Imagine.Name = "button_Adauga_Imagine";
            button_Adauga_Imagine.Size = new Size(75, 23);
            button_Adauga_Imagine.TabIndex = 58;
            button_Adauga_Imagine.Text = "Adauga imagine";
            button_Adauga_Imagine.UseVisualStyleBackColor = true;
            button_Adauga_Imagine.Click += btn_Adauga_Imagine_Custom_Click;
            // 
            // pb_Imagine_Custom
            // 
            pb_Imagine_Custom.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            pb_Imagine_Custom.BackColor = SystemColors.ControlDark;
            pb_Imagine_Custom.BorderStyle = BorderStyle.Fixed3D;
            pb_Imagine_Custom.Location = new Point(583, 77);
            pb_Imagine_Custom.Margin = new Padding(4, 3, 4, 3);
            pb_Imagine_Custom.Name = "pb_Imagine_Custom";
            pb_Imagine_Custom.Size = new Size(209, 164);
            pb_Imagine_Custom.SizeMode = PictureBoxSizeMode.StretchImage;
            pb_Imagine_Custom.TabIndex = 57;
            pb_Imagine_Custom.TabStop = false;
            // 
            // textBox_Pret
            // 
            textBox_Pret.Location = new Point(141, 80);
            textBox_Pret.Name = "textBox_Pret";
            textBox_Pret.Size = new Size(179, 23);
            textBox_Pret.TabIndex = 56;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Country", "All Cheese", "Romaneasca", "Cu ton", "Mediteraneana", "Rustica", "Texas", "Custom" });
            comboBox1.Location = new Point(141, 37);
            comboBox1.MaxLength = 15;
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(179, 23);
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
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new Point(646, 45);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(101, 15);
            label4.TabIndex = 6;
            label4.Text = "Imagine Custom :";
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButton3, toolStripButton1, toolStripButton2, toolStripButton4, textFileToolStripMenuItem });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1099, 25);
            toolStrip1.TabIndex = 64;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton3
            // 
            toolStripButton3.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButton3.ImageTransparentColor = Color.Magenta;
            toolStripButton3.Name = "toolStripButton3";
            toolStripButton3.Size = new Size(67, 22);
            toolStripButton3.Text = "Main Page";
            toolStripButton3.Click += btn_Main_Page_Click;
            // 
            // toolStripButton1
            // 
            toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(36, 22);
            toolStripButton1.Text = "Print";
            // 
            // toolStripButton2
            // 
            toolStripButton2.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButton2.ImageTransparentColor = Color.Magenta;
            toolStripButton2.Name = "toolStripButton2";
            toolStripButton2.Size = new Size(80, 22);
            toolStripButton2.Text = "Preview Print";
            toolStripButton2.ToolTipText = "Print Preview";
            // 
            // toolStripButton4
            // 
            toolStripButton4.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButton4.DropDownItems.AddRange(new ToolStripItem[] { serializeToolStripMenuItem, deserealizeToolStripMenuItem });
            toolStripButton4.Image = (Image)resources.GetObject("toolStripButton4.Image");
            toolStripButton4.ImageTransparentColor = Color.Magenta;
            toolStripButton4.Name = "toolStripButton4";
            toolStripButton4.Size = new Size(109, 22);
            toolStripButton4.Text = "Json Serialization";
            // 
            // serializeToolStripMenuItem
            // 
            serializeToolStripMenuItem.Name = "serializeToolStripMenuItem";
            serializeToolStripMenuItem.Size = new Size(132, 22);
            serializeToolStripMenuItem.Text = "Serialize";
            serializeToolStripMenuItem.Click += btn_Json_Serialize_Click;
            // 
            // deserealizeToolStripMenuItem
            // 
            deserealizeToolStripMenuItem.Name = "deserealizeToolStripMenuItem";
            deserealizeToolStripMenuItem.Size = new Size(132, 22);
            deserealizeToolStripMenuItem.Text = "Deserealize";
            deserealizeToolStripMenuItem.Click += btn_Json_Deserealize_Click;
            // 
            // textFileToolStripMenuItem
            // 
            textFileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { btnTextFile });
            textFileToolStripMenuItem.Name = "textFileToolStripMenuItem";
            textFileToolStripMenuItem.Size = new Size(58, 25);
            textFileToolStripMenuItem.Text = "TextFile";
            textFileToolStripMenuItem.Click += btn_Text_File;
            // 
            // btnTextFile
            // 
            btnTextFile.Name = "btnTextFile";
            btnTextFile.Size = new Size(107, 22);
            btnTextFile.Text = "Export";
            btnTextFile.Click += btn_Text_File;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Location = new Point(0, 300);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new Padding(10);
            flowLayoutPanel1.Size = new Size(1099, 434);
            flowLayoutPanel1.TabIndex = 65;
            // 
            // PizzaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1099, 731);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(toolStrip1);
            Controls.Add(groupBox1);
            Name = "PizzaForm";
            Text = "PizzaForm";
            Load += PizzaForm_Load;
            ((System.ComponentModel.ISupportInitialize)pizzaBindingSource).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)textBox_Cantitate).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb_Imagine_Custom).EndInit();
            ((System.ComponentModel.ISupportInitialize)textBox_Pret).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private BindingSource pizzaBindingSource;
        private GroupBox groupBox1;
        private Button btn_Add;
        private Label label1;
        private Label label2;
        private Label label4;
        private ComboBox comboBox1;
        private NumericUpDown textBox_Pret;
        private Button button_Adauga_Imagine;
        internal PictureBox pb_Imagine_Custom;
        private Button btn_Delete;
        private Button btn_Update;
        private NumericUpDown textBox_Cantitate;
        private Label label3;
        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButton3;
        private ToolStripButton toolStripButton1;
        private ToolStripButton toolStripButton2;
        private FlowLayoutPanel flowLayoutPanel1;
        private ToolStripDropDownButton toolStripButton4;
        private ToolStripMenuItem serializeToolStripMenuItem;
        private ToolStripMenuItem deserealizeToolStripMenuItem;
        private ToolStripMenuItem textFileToolStripMenuItem;
        private ToolStripMenuItem btnTextFile;
    }
}
