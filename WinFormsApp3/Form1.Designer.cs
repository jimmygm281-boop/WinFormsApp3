namespace WinFormsApp3
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
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            closeToolStripMenuItem1 = new ToolStripMenuItem();
            graphicsToolStripMenuItem = new ToolStripMenuItem();
            clearToolStripMenuItem = new ToolStripMenuItem();
            blackToolStripMenuItem = new ToolStripMenuItem();
            redToolStripMenuItem = new ToolStripMenuItem();
            blueToolStripMenuItem = new ToolStripMenuItem();
            panel1 = new Panel();
            tseverleh = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            radioButton4 = new RadioButton();
            radioButton5 = new RadioButton();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, graphicsToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { closeToolStripMenuItem1 });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(44, 24);
            fileToolStripMenuItem.Text = "file";
            // 
            // closeToolStripMenuItem1
            // 
            closeToolStripMenuItem1.Name = "closeToolStripMenuItem1";
            closeToolStripMenuItem1.Size = new Size(126, 26);
            closeToolStripMenuItem1.Text = "close";
            closeToolStripMenuItem1.Click += closeToolStripMenuItem1_Click;
            // 
            // graphicsToolStripMenuItem
            // 
            graphicsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { clearToolStripMenuItem, blackToolStripMenuItem, redToolStripMenuItem, blueToolStripMenuItem });
            graphicsToolStripMenuItem.Name = "graphicsToolStripMenuItem";
            graphicsToolStripMenuItem.Size = new Size(80, 24);
            graphicsToolStripMenuItem.Text = "Graphics";
            // 
            // clearToolStripMenuItem
            // 
            clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            clearToolStripMenuItem.Size = new Size(127, 26);
            clearToolStripMenuItem.Text = "clear";
            clearToolStripMenuItem.Click += clearToolStripMenuItem_Click;
            // 
            // blackToolStripMenuItem
            // 
            blackToolStripMenuItem.Name = "blackToolStripMenuItem";
            blackToolStripMenuItem.Size = new Size(127, 26);
            blackToolStripMenuItem.Text = "black";
            blackToolStripMenuItem.Click += blackToolStripMenuItem_Click;
            // 
            // redToolStripMenuItem
            // 
            redToolStripMenuItem.Name = "redToolStripMenuItem";
            redToolStripMenuItem.Size = new Size(127, 26);
            redToolStripMenuItem.Text = "red";
            redToolStripMenuItem.Click += redToolStripMenuItem_Click;
            // 
            // blueToolStripMenuItem
            // 
            blueToolStripMenuItem.Name = "blueToolStripMenuItem";
            blueToolStripMenuItem.Size = new Size(127, 26);
            blueToolStripMenuItem.Text = "blue";
            blueToolStripMenuItem.Click += blueToolStripMenuItem_Click;
            // 
            // panel1
            // 
            panel1.Location = new Point(12, 31);
            panel1.Name = "panel1";
            panel1.Size = new Size(649, 398);
            panel1.TabIndex = 1;
            panel1.MouseDown += panel1_MouseDown;
            panel1.MouseUp += panel1_MouseUp;
            // 
            // tseverleh
            // 
            tseverleh.Location = new Point(682, 31);
            tseverleh.Name = "tseverleh";
            tseverleh.Size = new Size(118, 29);
            tseverleh.TabIndex = 2;
            tseverleh.Text = "tseverleh\r\n";
            tseverleh.UseVisualStyleBackColor = true;
            tseverleh.Click += tseverleh_Click;
            // 
            // button2
            // 
            button2.Location = new Point(682, 66);
            button2.Name = "button2";
            button2.Size = new Size(118, 29);
            button2.TabIndex = 3;
            button2.Text = "tegsh untsugt";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(682, 101);
            button3.Name = "button3";
            button3.Size = new Size(118, 29);
            button3.TabIndex = 4;
            button3.Text = "dugui";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(682, 136);
            button4.Name = "button4";
            button4.Size = new Size(118, 29);
            button4.TabIndex = 5;
            button4.Text = "shuluun";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(682, 171);
            button5.Name = "button5";
            button5.Size = new Size(118, 29);
            button5.TabIndex = 6;
            button5.Text = "pie";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(682, 206);
            button6.Name = "button6";
            button6.Size = new Size(118, 29);
            button6.TabIndex = 7;
            button6.Text = "polygon";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Location = new Point(682, 241);
            button7.Name = "button7";
            button7.Size = new Size(118, 29);
            button7.TabIndex = 8;
            button7.Text = "curve";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(681, 276);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(119, 24);
            radioButton1.TabIndex = 9;
            radioButton1.TabStop = true;
            radioButton1.Text = "tegsh untsugt";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(682, 306);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(80, 24);
            radioButton2.TabIndex = 10;
            radioButton2.TabStop = true;
            radioButton2.Text = "shuluun";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(681, 336);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(71, 24);
            radioButton3.TabIndex = 11;
            radioButton3.TabStop = true;
            radioButton3.Text = "toirog";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Location = new Point(681, 366);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(85, 24);
            radioButton4.TabIndex = 12;
            radioButton4.TabStop = true;
            radioButton4.Text = "polygon";
            radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            radioButton5.AutoSize = true;
            radioButton5.Location = new Point(682, 396);
            radioButton5.Name = "radioButton5";
            radioButton5.Size = new Size(65, 24);
            radioButton5.TabIndex = 13;
            radioButton5.TabStop = true;
            radioButton5.Text = "curve";
            radioButton5.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(radioButton5);
            Controls.Add(radioButton4);
            Controls.Add(radioButton3);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(tseverleh);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "hulganaar zurah";
            Load += Form1_Load;
            MouseDown += Form1_MouseDown;
            MouseMove += Form1_MouseMove;
            MouseUp += Form1_MouseUp;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem closeToolStripMenuItem1;
        private ToolStripMenuItem graphicsToolStripMenuItem;
        private ToolStripMenuItem clearToolStripMenuItem;
        private ToolStripMenuItem blackToolStripMenuItem;
        private ToolStripMenuItem redToolStripMenuItem;
        private ToolStripMenuItem blueToolStripMenuItem;
        private Panel panel1;
        private Button tseverleh;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private RadioButton radioButton4;
        private RadioButton radioButton5;
    }
}
