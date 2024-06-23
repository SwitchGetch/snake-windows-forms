namespace snake
{
    partial class Menu
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
            tableLayoutPanel1 = new TableLayoutPanel();
            label1 = new Label();
            numericUpDown1 = new NumericUpDown();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            numericUpDown2 = new NumericUpDown();
            numericUpDown3 = new NumericUpDown();
            button1 = new Button();
            label5 = new Label();
            label6 = new Label();
            numericUpDown4 = new NumericUpDown();
            numericUpDown5 = new NumericUpDown();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown5).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 10;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.Controls.Add(label1, 4, 1);
            tableLayoutPanel1.Controls.Add(numericUpDown1, 5, 4);
            tableLayoutPanel1.Controls.Add(label2, 4, 4);
            tableLayoutPanel1.Controls.Add(label3, 4, 5);
            tableLayoutPanel1.Controls.Add(label4, 4, 6);
            tableLayoutPanel1.Controls.Add(numericUpDown2, 5, 5);
            tableLayoutPanel1.Controls.Add(numericUpDown3, 5, 6);
            tableLayoutPanel1.Controls.Add(button1, 4, 7);
            tableLayoutPanel1.Controls.Add(label5, 4, 2);
            tableLayoutPanel1.Controls.Add(label6, 4, 3);
            tableLayoutPanel1.Controls.Add(numericUpDown4, 5, 2);
            tableLayoutPanel1.Controls.Add(numericUpDown5, 5, 3);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 10;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.Size = new Size(800, 450);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Control;
            tableLayoutPanel1.SetColumnSpan(label1, 2);
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Snap ITC", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new System.Drawing.Point(323, 45);
            label1.Name = "label1";
            label1.Size = new Size(154, 45);
            label1.TabIndex = 0;
            label1.Text = "SNAKE";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Dock = DockStyle.Fill;
            numericUpDown1.Location = new System.Drawing.Point(403, 183);
            numericUpDown1.Maximum = new decimal(new int[] { 50, 0, 0, 0 });
            numericUpDown1.Minimum = new decimal(new int[] { 2, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(74, 23);
            numericUpDown1.TabIndex = 4;
            numericUpDown1.Value = new decimal(new int[] { 2, 0, 0, 0 });
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Location = new System.Drawing.Point(323, 180);
            label2.Name = "label2";
            label2.Size = new Size(74, 45);
            label2.TabIndex = 1;
            label2.Text = "Field\r\nWidth";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Fill;
            label3.Location = new System.Drawing.Point(323, 225);
            label3.Name = "label3";
            label3.Size = new Size(74, 45);
            label3.TabIndex = 2;
            label3.Text = "Field\r\nHeight";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Fill;
            label4.Location = new System.Drawing.Point(323, 270);
            label4.Name = "label4";
            label4.Size = new Size(74, 45);
            label4.TabIndex = 3;
            label4.Text = "Snake\r\nSpeed";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // numericUpDown2
            // 
            numericUpDown2.Dock = DockStyle.Fill;
            numericUpDown2.Location = new System.Drawing.Point(403, 228);
            numericUpDown2.Maximum = new decimal(new int[] { 50, 0, 0, 0 });
            numericUpDown2.Minimum = new decimal(new int[] { 2, 0, 0, 0 });
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(74, 23);
            numericUpDown2.TabIndex = 5;
            numericUpDown2.Value = new decimal(new int[] { 2, 0, 0, 0 });
            // 
            // numericUpDown3
            // 
            numericUpDown3.Dock = DockStyle.Fill;
            numericUpDown3.Increment = new decimal(new int[] { 100, 0, 0, 0 });
            numericUpDown3.Location = new System.Drawing.Point(403, 273);
            numericUpDown3.Maximum = new decimal(new int[] { 999, 0, 0, 0 });
            numericUpDown3.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown3.Name = "numericUpDown3";
            numericUpDown3.Size = new Size(74, 23);
            numericUpDown3.TabIndex = 6;
            numericUpDown3.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // button1
            // 
            tableLayoutPanel1.SetColumnSpan(button1, 2);
            button1.Dock = DockStyle.Fill;
            button1.Font = new Font("Snap ITC", 18F);
            button1.Location = new System.Drawing.Point(323, 318);
            button1.Name = "button1";
            button1.Size = new Size(154, 39);
            button1.TabIndex = 7;
            button1.Text = "START";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Dock = DockStyle.Fill;
            label5.Location = new System.Drawing.Point(323, 90);
            label5.Name = "label5";
            label5.Size = new Size(74, 45);
            label5.TabIndex = 8;
            label5.Text = "Window Width";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Dock = DockStyle.Fill;
            label6.Location = new System.Drawing.Point(323, 135);
            label6.Name = "label6";
            label6.Size = new Size(74, 45);
            label6.TabIndex = 9;
            label6.Text = "Window\r\nHeight";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // numericUpDown4
            // 
            numericUpDown4.Dock = DockStyle.Fill;
            numericUpDown4.Location = new System.Drawing.Point(403, 93);
            numericUpDown4.Maximum = new decimal(new int[] { 1920, 0, 0, 0 });
            numericUpDown4.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown4.Name = "numericUpDown4";
            numericUpDown4.Size = new Size(74, 23);
            numericUpDown4.TabIndex = 10;
            numericUpDown4.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // numericUpDown5
            // 
            numericUpDown5.Dock = DockStyle.Fill;
            numericUpDown5.Location = new System.Drawing.Point(403, 138);
            numericUpDown5.Maximum = new decimal(new int[] { 1080, 0, 0, 0 });
            numericUpDown5.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown5.Name = "numericUpDown5";
            numericUpDown5.Size = new Size(74, 23);
            numericUpDown5.TabIndex = 11;
            numericUpDown5.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            Name = "Menu";
            Text = "Menu";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown4).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown5).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private NumericUpDown numericUpDown1;
        private NumericUpDown numericUpDown2;
        private NumericUpDown numericUpDown3;
        private Button button1;
        private Label label5;
        private Label label6;
        private NumericUpDown numericUpDown4;
        private NumericUpDown numericUpDown5;
    }
}
