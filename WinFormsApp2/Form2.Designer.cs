namespace WinFormsApp2
{
    partial class Form2
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
            label1 = new Label();
            label2 = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            toolStripTextBox1 = new ToolStripTextBox();
            USERNAME = new TextBox();
            PASSWORD = new TextBox();
            button1 = new Button();
            button2 = new Button();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(282, 132);
            label1.Name = "label1";
            label1.Size = new Size(118, 25);
            label1.TabIndex = 0;
            label1.Text = "ENTER NAME";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(282, 218);
            label2.Name = "label2";
            label2.Size = new Size(164, 25);
            label2.TabIndex = 1;
            label2.Text = "ENTER PASSWORD";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(24, 24);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { toolStripTextBox1 });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(161, 39);
            contextMenuStrip1.Opening += contextMenuStrip1_Opening;
            // 
            // toolStripTextBox1
            // 
            toolStripTextBox1.Name = "toolStripTextBox1";
            toolStripTextBox1.Size = new Size(100, 31);
            // 
            // USERNAME
            // 
            USERNAME.Location = new Point(438, 132);
            USERNAME.Name = "USERNAME";
            USERNAME.Size = new Size(332, 31);
            USERNAME.TabIndex = 3;
            USERNAME.TextChanged += USERNAME_TextChanged;
            // 
            // PASSWORD
            // 
            PASSWORD.Location = new Point(452, 215);
            PASSWORD.Name = "PASSWORD";
            PASSWORD.PasswordChar = '?';
            PASSWORD.Size = new Size(318, 31);
            PASSWORD.TabIndex = 4;
            PASSWORD.TextChanged += textBox2_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(469, 303);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 5;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            button1.Enter += button1_Enter;
            button1.Leave += button1_Leave;
            button1.MouseMove += button1_MouseMove;
            // 
            // button2
            // 
            button2.Location = new Point(622, 303);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 6;
            button2.Text = "Cancel";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.HotTrack;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(PASSWORD);
            Controls.Add(USERNAME);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form2";
            Text = "login";
            Load += Form2_Load;
            contextMenuStrip1.ResumeLayout(false);
            contextMenuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripTextBox toolStripTextBox1;
        private TextBox USERNAME;
        private TextBox PASSWORD;
        private Button button1;
        private Button button2;
    }
}