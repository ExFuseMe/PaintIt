namespace WinFormsApp1
{
    partial class Form1
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
            colorDialog1 = new ColorDialog();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            button2 = new Button();
            button3 = new Button();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            radioButton4 = new RadioButton();
            radioButton1 = new RadioButton();
            panel1 = new Panel();
            radioButton5 = new RadioButton();
            contextMenuStrip1 = new ContextMenuStrip(components);
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            openCtrlOToolStripMenuItem = new ToolStripMenuItem();
            saveCtrlSToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            clearToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            undoToolStripMenuItem = new ToolStripMenuItem();
            redoToolStripMenuItem = new ToolStripMenuItem();
            saveFileDialog1 = new SaveFileDialog();
            openFileDialog1 = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // colorDialog1
            // 
            colorDialog1.AnyColor = true;
            // 
            // button1
            // 
            button1.BackColor = Color.Silver;
            button1.Location = new Point(0, 138);
            button1.Margin = new Padding(0);
            button1.Name = "button1";
            button1.Size = new Size(50, 50);
            button1.TabIndex = 0;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Margin = new Padding(50, 3, 3, 3);
            pictureBox1.MaximumSize = new Size(4000, 4000);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(674, 529);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.MouseDown += drawpanel_mdown;
            pictureBox1.MouseMove += drawpanel_mmove;
            pictureBox1.MouseUp += drawpanel_mup;
            // 
            // button2
            // 
            button2.Location = new Point(0, 38);
            button2.Margin = new Padding(0);
            button2.Name = "button2";
            button2.Size = new Size(50, 50);
            button2.TabIndex = 2;
            button2.Text = "+";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(0, 88);
            button3.Margin = new Padding(0);
            button3.Name = "button3";
            button3.Size = new Size(50, 50);
            button3.TabIndex = 3;
            button3.Text = "-";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // radioButton2
            // 
            radioButton2.Appearance = Appearance.Button;
            radioButton2.AutoEllipsis = true;
            radioButton2.Location = new Point(0, 238);
            radioButton2.Margin = new Padding(0);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(50, 50);
            radioButton2.TabIndex = 4;
            radioButton2.Text = "○";
            radioButton2.TextAlign = ContentAlignment.MiddleCenter;
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // radioButton3
            // 
            radioButton3.Appearance = Appearance.Button;
            radioButton3.Location = new Point(0, 288);
            radioButton3.Margin = new Padding(0);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(50, 50);
            radioButton3.TabIndex = 5;
            radioButton3.Text = "▭";
            radioButton3.TextAlign = ContentAlignment.MiddleCenter;
            radioButton3.UseVisualStyleBackColor = true;
            radioButton3.CheckedChanged += radioButton3_CheckedChanged;
            // 
            // radioButton4
            // 
            radioButton4.Appearance = Appearance.Button;
            radioButton4.Location = new Point(0, 338);
            radioButton4.Margin = new Padding(0);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(50, 50);
            radioButton4.TabIndex = 6;
            radioButton4.Text = "/";
            radioButton4.TextAlign = ContentAlignment.MiddleCenter;
            radioButton4.UseVisualStyleBackColor = true;
            radioButton4.CheckedChanged += radioButton4_CheckedChanged;
            // 
            // radioButton1
            // 
            radioButton1.Appearance = Appearance.Button;
            radioButton1.AutoEllipsis = true;
            radioButton1.Checked = true;
            radioButton1.Location = new Point(0, 188);
            radioButton1.Margin = new Padding(0);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(50, 50);
            radioButton1.TabIndex = 7;
            radioButton1.TabStop = true;
            radioButton1.Text = "✏";
            radioButton1.TextAlign = ContentAlignment.MiddleCenter;
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(radioButton5);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(radioButton1);
            panel1.Controls.Add(radioButton4);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(radioButton3);
            panel1.Controls.Add(radioButton2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(50, 529);
            panel1.TabIndex = 8;
            // 
            // radioButton5
            // 
            radioButton5.Appearance = Appearance.Button;
            radioButton5.Location = new Point(0, 388);
            radioButton5.Margin = new Padding(0);
            radioButton5.Name = "radioButton5";
            radioButton5.Size = new Size(50, 50);
            radioButton5.TabIndex = 8;
            radioButton5.Text = "fill";
            radioButton5.TextAlign = ContentAlignment.MiddleCenter;
            radioButton5.UseVisualStyleBackColor = true;
            radioButton5.CheckedChanged += radioButton5_CheckedChanged;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(32, 32);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(32, 32);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, clearToolStripMenuItem, editToolStripMenuItem });
            menuStrip1.Location = new Point(50, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(624, 42);
            menuStrip1.TabIndex = 9;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { openCtrlOToolStripMenuItem, saveCtrlSToolStripMenuItem, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(71, 38);
            fileToolStripMenuItem.Text = "File";
            // 
            // openCtrlOToolStripMenuItem
            // 
            openCtrlOToolStripMenuItem.Name = "openCtrlOToolStripMenuItem";
            openCtrlOToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.O;
            openCtrlOToolStripMenuItem.Size = new Size(359, 44);
            openCtrlOToolStripMenuItem.Text = "Открыть";
            openCtrlOToolStripMenuItem.Click += openCtrlOToolStripMenuItem_Click;
            // 
            // saveCtrlSToolStripMenuItem
            // 
            saveCtrlSToolStripMenuItem.Name = "saveCtrlSToolStripMenuItem";
            saveCtrlSToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.S;
            saveCtrlSToolStripMenuItem.Size = new Size(359, 44);
            saveCtrlSToolStripMenuItem.Text = "Save";
            saveCtrlSToolStripMenuItem.Click += saveCtrlSToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.E;
            exitToolStripMenuItem.Size = new Size(359, 44);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // clearToolStripMenuItem
            // 
            clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            clearToolStripMenuItem.Size = new Size(88, 38);
            clearToolStripMenuItem.Text = "Clear";
            clearToolStripMenuItem.Click += clearToolStripMenuItem_Click;
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { undoToolStripMenuItem, redoToolStripMenuItem });
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(74, 38);
            editToolStripMenuItem.Text = "Edit";
            // 
            // undoToolStripMenuItem
            // 
            undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            undoToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Z;
            undoToolStripMenuItem.Size = new Size(286, 44);
            undoToolStripMenuItem.Text = "Undo";
            // 
            // redoToolStripMenuItem
            // 
            redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            redoToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Y;
            redoToolStripMenuItem.Size = new Size(286, 44);
            redoToolStripMenuItem.Text = "Redo";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(674, 529);
            Controls.Add(menuStrip1);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ColorDialog colorDialog1;
        private Button button1;
        private PictureBox pictureBox1;
        private Button button2;
        private Button button3;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private RadioButton radioButton4;
        private RadioButton radioButton1;
        private Panel panel1;
        private ContextMenuStrip contextMenuStrip1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem openCtrlOToolStripMenuItem;
        private ToolStripMenuItem saveCtrlSToolStripMenuItem;
        private ToolStripMenuItem clearToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem undoToolStripMenuItem;
        private ToolStripMenuItem redoToolStripMenuItem;
        private SaveFileDialog saveFileDialog1;
        private ToolStripMenuItem exitToolStripMenuItem;
        private OpenFileDialog openFileDialog1;
        private RadioButton radioButton5;
    }
}