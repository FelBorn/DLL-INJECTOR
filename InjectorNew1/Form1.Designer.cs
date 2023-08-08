namespace InjectorNew1
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
            panel1 = new Panel();
            label2 = new Label();
            label1 = new Label();
            button2 = new Button();
            button1 = new Button();
            textBox1 = new TextBox();
            bindingSource1 = new BindingSource(components);
            comboBox1 = new ComboBox();
            button3 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaptionText;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(500, 58);
            panel1.TabIndex = 6;
            panel1.MouseDown += mouse_Down;
            panel1.MouseMove += move_Move;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe Fluent Icons", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(0, -2);
            label2.Name = "label2";
            label2.Size = new Size(385, 49);
            label2.TabIndex = 1;
            label2.Text = "Requested by rankor0, Setup by FelBorn";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI Black", 25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(452, 2);
            label1.Name = "label1";
            label1.Size = new Size(50, 50);
            label1.TabIndex = 0;
            label1.Text = "X";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ActiveCaptionText;
            button2.ForeColor = Color.Lime;
            button2.Location = new Point(200, 124);
            button2.Name = "button2";
            button2.Size = new Size(92, 23);
            button2.TabIndex = 9;
            button2.Text = "Inject DLL";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaptionText;
            button1.ForeColor = SystemColors.ButtonFace;
            button1.Location = new Point(396, 67);
            button1.Name = "button1";
            button1.Size = new Size(92, 23);
            button1.TabIndex = 8;
            button1.Text = "Locate DLL";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.InactiveCaptionText;
            textBox1.ForeColor = SystemColors.Window;
            textBox1.Location = new Point(7, 67);
            textBox1.Name = "textBox1";
            textBox1.RightToLeft = RightToLeft.No;
            textBox1.Size = new Size(383, 23);
            textBox1.TabIndex = 7;
            textBox1.Text = "DLL PATH";
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // comboBox1
            // 
            comboBox1.BackColor = SystemColors.InactiveCaptionText;
            comboBox1.ForeColor = SystemColors.Window;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(6, 95);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(384, 23);
            comboBox1.TabIndex = 10;
            comboBox1.Text = "PROCESS";
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ActiveCaptionText;
            button3.ForeColor = SystemColors.ButtonFace;
            button3.Location = new Point(396, 94);
            button3.Name = "button3";
            button3.Size = new Size(92, 23);
            button3.TabIndex = 11;
            button3.Text = "Refresh";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(500, 150);
            Controls.Add(button3);
            Controls.Add(comboBox1);
            Controls.Add(panel1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Label label1;
        private Button button2;
        private Button button1;
        private TextBox textBox1;
        private BindingSource bindingSource1;
        private ComboBox comboBox1;
        private Button button3;
    }
}