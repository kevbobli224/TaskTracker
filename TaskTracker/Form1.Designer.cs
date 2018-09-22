using System.Windows.Forms;

namespace TaskTracker
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.aesButtonClass2 = new TaskTracker.AesButtonClass();
            this.aesButtonClass1 = new TaskTracker.AesButtonClass();
            this.panel2 = new System.Windows.Forms.Panel();
            this.aesTable1 = new TaskTracker.AesTable();
            this.panel3 = new System.Windows.Forms.Panel();
            this.aesButtonClass4 = new TaskTracker.AesButtonClass();
            this.panel4 = new System.Windows.Forms.Panel();
            this.aesTextField1 = new TaskTracker.AesTextField();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.l_sec = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.l_min = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.l_hour = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.aesButtonClass3 = new TaskTracker.AesButtonClass();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.l_des = new System.Windows.Forms.Label();
            this.l_task = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.aesButtonClass2);
            this.panel1.Controls.Add(this.aesButtonClass1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(985, 55);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Panel1_Mousemove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Panel1_MouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(51, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "TASK MANAGER";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TaskTracker.Properties.Resources.ExaltedOrb1;
            this.pictureBox1.Location = new System.Drawing.Point(5, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 45);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // aesButtonClass2
            // 
            this.aesButtonClass2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.aesButtonClass2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(88)))), ((int)(((byte)(88)))));
            this.aesButtonClass2.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(88)))), ((int)(((byte)(88)))));
            this.aesButtonClass2.ButtonLocation = new System.Drawing.Point(22, 22);
            this.aesButtonClass2.FlatAppearance.BorderSize = 0;
            this.aesButtonClass2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aesButtonClass2.Location = new System.Drawing.Point(885, 5);
            this.aesButtonClass2.Margin = new System.Windows.Forms.Padding(0);
            this.aesButtonClass2.Name = "aesButtonClass2";
            this.aesButtonClass2.Size = new System.Drawing.Size(45, 45);
            this.aesButtonClass2.Styles = TaskTracker.FStyles.Minimize;
            this.aesButtonClass2.TabIndex = 1;
            this.aesButtonClass2.Transparent = false;
            this.aesButtonClass2.UseVisualStyleBackColor = false;
            this.aesButtonClass2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Minimizebutton);
            // 
            // aesButtonClass1
            // 
            this.aesButtonClass1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.aesButtonClass1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(88)))), ((int)(((byte)(88)))));
            this.aesButtonClass1.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(88)))), ((int)(((byte)(88)))));
            this.aesButtonClass1.ButtonLocation = new System.Drawing.Point(22, 22);
            this.aesButtonClass1.FlatAppearance.BorderSize = 0;
            this.aesButtonClass1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aesButtonClass1.Location = new System.Drawing.Point(935, 5);
            this.aesButtonClass1.Margin = new System.Windows.Forms.Padding(0);
            this.aesButtonClass1.Name = "aesButtonClass1";
            this.aesButtonClass1.Size = new System.Drawing.Size(45, 45);
            this.aesButtonClass1.Styles = TaskTracker.FStyles.Close;
            this.aesButtonClass1.TabIndex = 0;
            this.aesButtonClass1.Text = "32";
            this.aesButtonClass1.Transparent = false;
            this.aesButtonClass1.UseVisualStyleBackColor = false;
            this.aesButtonClass1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Xbutton);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.panel2.Controls.Add(this.aesTable1);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(0, 61);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(199, 576);
            this.panel2.TabIndex = 1;
            // 
            // aesTable1
            // 
            this.aesTable1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.aesTable1.AutoScroll = true;
            this.aesTable1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.aesTable1.ColumnCount = 1;
            this.aesTable1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.aesTable1.Location = new System.Drawing.Point(8, 13);
            this.aesTable1.Name = "aesTable1";
            this.aesTable1.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.aesTable1.RowCount = 1;
            this.aesTable1.rowHeight = 50F;
            this.aesTable1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.aesTable1.Size = new System.Drawing.Size(184, 509);
            this.aesTable1.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.panel3.Controls.Add(this.aesButtonClass4);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Location = new System.Drawing.Point(3, 528);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(193, 45);
            this.panel3.TabIndex = 0;
            // 
            // aesButtonClass4
            // 
            this.aesButtonClass4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(88)))), ((int)(((byte)(88)))));
            this.aesButtonClass4.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(88)))), ((int)(((byte)(88)))));
            this.aesButtonClass4.ButtonLocation = new System.Drawing.Point(18, 18);
            this.aesButtonClass4.FlatAppearance.BorderSize = 0;
            this.aesButtonClass4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aesButtonClass4.Location = new System.Drawing.Point(153, 4);
            this.aesButtonClass4.Margin = new System.Windows.Forms.Padding(1);
            this.aesButtonClass4.Name = "aesButtonClass4";
            this.aesButtonClass4.Size = new System.Drawing.Size(36, 36);
            this.aesButtonClass4.Styles = TaskTracker.FStyles.Plus;
            this.aesButtonClass4.TabIndex = 4;
            this.aesButtonClass4.Transparent = false;
            this.aesButtonClass4.UseVisualStyleBackColor = false;
            this.aesButtonClass4.Click += new System.EventHandler(this.aesButtonClass4_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.panel4.Controls.Add(this.aesTextField1);
            this.panel4.Location = new System.Drawing.Point(3, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(148, 36);
            this.panel4.TabIndex = 3;
            // 
            // aesTextField1
            // 
            this.aesTextField1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.aesTextField1.BackColour = System.Drawing.Color.Empty;
            this.aesTextField1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.aesTextField1.Location = new System.Drawing.Point(14, 5);
            this.aesTextField1.Margin = new System.Windows.Forms.Padding(0, 1, 0, 1);
            this.aesTextField1.Multiline = false;
            this.aesTextField1.Name = "aesTextField1";
            this.aesTextField1.RightMargin = 5;
            this.aesTextField1.Size = new System.Drawing.Size(122, 30);
            this.aesTextField1.TabIndex = 3;
            this.aesTextField1.Text = "";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label7);
            this.panel5.Controls.Add(this.button3);
            this.panel5.Controls.Add(this.label6);
            this.panel5.Controls.Add(this.listBox2);
            this.panel5.Controls.Add(this.textBox1);
            this.panel5.Controls.Add(this.button2);
            this.panel5.Controls.Add(this.button1);
            this.panel5.Controls.Add(this.groupBox1);
            this.panel5.Controls.Add(this.listBox1);
            this.panel5.Controls.Add(this.aesButtonClass3);
            this.panel5.Controls.Add(this.progressBar1);
            this.panel5.Controls.Add(this.l_des);
            this.panel5.Controls.Add(this.l_task);
            this.panel5.Location = new System.Drawing.Point(205, 61);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(775, 573);
            this.panel5.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Palatino Linotype", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(566, 94);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 31);
            this.label7.TabIndex = 19;
            this.label7.Text = "Name";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label7.UseCompatibleTextRendering = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(566, 324);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(206, 33);
            this.button3.TabIndex = 18;
            this.button3.Text = "Repeat Tasks";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Palatino Linotype", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(566, 196);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 31);
            this.label6.TabIndex = 17;
            this.label6.Text = "Completed";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label6.UseCompatibleTextRendering = true;
            // 
            // listBox2
            // 
            this.listBox2.BackColor = System.Drawing.Color.Silver;
            this.listBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox2.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox2.ForeColor = System.Drawing.Color.Black;
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 22;
            this.listBox2.Location = new System.Drawing.Point(566, 230);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(206, 88);
            this.listBox2.TabIndex = 16;
            this.listBox2.DoubleClick += new System.EventHandler(this.listbox2DoubleClick);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(631, 99);
            this.textBox1.MaxLength = 24;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(141, 22);
            this.textBox1.TabIndex = 15;
            this.textBox1.Text = "tasklistfilenamehere";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(566, 164);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(206, 33);
            this.button2.TabIndex = 14;
            this.button2.Text = "Load Tasks";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(566, 125);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(206, 33);
            this.button1.TabIndex = 13;
            this.button1.Text = "Save Tasks";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.l_sec);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.l_min);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.l_hour);
            this.groupBox1.Location = new System.Drawing.Point(179, 336);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(381, 100);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 35);
            this.label2.TabIndex = 6;
            this.label2.Text = "Hours";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.UseCompatibleTextRendering = true;
            // 
            // l_sec
            // 
            this.l_sec.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.l_sec.AutoSize = true;
            this.l_sec.Font = new System.Drawing.Font("Palatino Linotype", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_sec.Location = new System.Drawing.Point(250, 60);
            this.l_sec.Name = "l_sec";
            this.l_sec.Size = new System.Drawing.Size(30, 35);
            this.l_sec.TabIndex = 11;
            this.l_sec.Text = "99";
            this.l_sec.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.l_sec.UseCompatibleTextRendering = true;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(152, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 35);
            this.label3.TabIndex = 7;
            this.label3.Text = "Minutes";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.UseCompatibleTextRendering = true;
            // 
            // l_min
            // 
            this.l_min.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.l_min.AutoSize = true;
            this.l_min.Font = new System.Drawing.Font("Palatino Linotype", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_min.Location = new System.Drawing.Point(116, 60);
            this.l_min.Name = "l_min";
            this.l_min.Size = new System.Drawing.Size(30, 35);
            this.l_min.TabIndex = 10;
            this.l_min.Text = "99";
            this.l_min.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.l_min.UseCompatibleTextRendering = true;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(128, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 35);
            this.label4.TabIndex = 2;
            this.label4.Text = "TIME LEFT";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label4.UseCompatibleTextRendering = true;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Palatino Linotype", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(286, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 35);
            this.label5.TabIndex = 8;
            this.label5.Text = "Seconds";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label5.UseCompatibleTextRendering = true;
            // 
            // l_hour
            // 
            this.l_hour.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.l_hour.AutoSize = true;
            this.l_hour.Font = new System.Drawing.Font("Palatino Linotype", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_hour.Location = new System.Drawing.Point(4, 60);
            this.l_hour.Name = "l_hour";
            this.l_hour.Size = new System.Drawing.Size(30, 35);
            this.l_hour.TabIndex = 9;
            this.l_hour.Text = "99";
            this.l_hour.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.l_hour.UseCompatibleTextRendering = true;
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.Silver;
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox1.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.ForeColor = System.Drawing.Color.Black;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 22;
            this.listBox1.Location = new System.Drawing.Point(566, 3);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(206, 88);
            this.listBox1.TabIndex = 5;
            this.listBox1.DoubleClick += new System.EventHandler(this.listboxDoubleClick);
            // 
            // aesButtonClass3
            // 
            this.aesButtonClass3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.aesButtonClass3.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(88)))), ((int)(((byte)(88)))));
            this.aesButtonClass3.ButtonLocation = new System.Drawing.Point(32, 32);
            this.aesButtonClass3.FlatAppearance.BorderSize = 0;
            this.aesButtonClass3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aesButtonClass3.Location = new System.Drawing.Point(697, 453);
            this.aesButtonClass3.Margin = new System.Windows.Forms.Padding(0);
            this.aesButtonClass3.Name = "aesButtonClass3";
            this.aesButtonClass3.Size = new System.Drawing.Size(64, 64);
            this.aesButtonClass3.Styles = TaskTracker.FStyles.Play;
            this.aesButtonClass3.TabIndex = 4;
            this.aesButtonClass3.Transparent = false;
            this.aesButtonClass3.UseVisualStyleBackColor = false;
            this.aesButtonClass3.Click += new System.EventHandler(this.aesButtonClass3_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.Color.Black;
            this.progressBar1.ForeColor = System.Drawing.Color.Black;
            this.progressBar1.Location = new System.Drawing.Point(15, 453);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(679, 64);
            this.progressBar1.TabIndex = 3;
            // 
            // l_des
            // 
            this.l_des.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.l_des.Font = new System.Drawing.Font("Palatino Linotype", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_des.Location = new System.Drawing.Point(3, 43);
            this.l_des.Name = "l_des";
            this.l_des.Size = new System.Drawing.Size(520, 290);
            this.l_des.TabIndex = 1;
            this.l_des.Text = "DESCRIPTION";
            this.l_des.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.l_des.UseCompatibleTextRendering = true;
            // 
            // l_task
            // 
            this.l_task.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.l_task.AutoSize = true;
            this.l_task.Font = new System.Drawing.Font("Palatino Linotype", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_task.Location = new System.Drawing.Point(0, 0);
            this.l_task.Name = "l_task";
            this.l_task.Size = new System.Drawing.Size(170, 43);
            this.l_task.TabIndex = 0;
            this.l_task.Text = "TASK HERE";
            this.l_task.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.l_task.UseCompatibleTextRendering = true;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(88)))), ((int)(((byte)(88)))));
            this.ClientSize = new System.Drawing.Size(985, 649);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.TransparencyKey = System.Drawing.Color.White;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Panel panel1;
        private AesButtonClass aesButtonClass1;
        private AesButtonClass aesButtonClass2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private AesTextField aesTextField1;
        private System.Windows.Forms.Panel panel4;
        private AesButtonClass aesButtonClass4;
        private AesTable aesTable1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label l_des;
        private System.Windows.Forms.Label l_task;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer timer1;
        private AesButtonClass aesButtonClass3;
        private ListBox listBox1;
        private GroupBox groupBox1;
        private Label l_sec;
        private Label l_min;
        private Label l_hour;
        private Label label5;
        private Label label3;
        private Label label2;
        private Button button2;
        private Button button1;
        private TextBox textBox1;
        private Label label6;
        private ListBox listBox2;
        private Button button3;
        private Label label7;
        #endregion
    }
}

