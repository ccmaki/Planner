namespace Planner
{
    partial class Add
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
            textBox1 = new TextBox();
            task_label = new Label();
            label2 = new Label();
            textBox3 = new TextBox();
            notStarted = new RadioButton();
            inProgress = new RadioButton();
            Completed = new RadioButton();
            label3 = new Label();
            panel1 = new Panel();
            button2 = new Button();
            cancel_btn = new Button();
            monthCalendar1 = new MonthCalendar();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(39, 93);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(532, 60);
            textBox1.TabIndex = 0;
            // 
            // task_label
            // 
            task_label.AutoSize = true;
            task_label.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            task_label.Location = new Point(245, 159);
            task_label.Name = "task_label";
            task_label.Size = new Size(50, 25);
            task_label.TabIndex = 1;
            task_label.Text = "Task";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(480, 344);
            label2.Name = "label2";
            label2.Size = new Size(114, 25);
            label2.TabIndex = 5;
            label2.Text = "Description";
            // 
            // textBox3
            // 
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox3.Location = new Point(39, 222);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(1024, 119);
            textBox3.TabIndex = 4;
            // 
            // notStarted
            // 
            notStarted.AutoSize = true;
            notStarted.BackColor = Color.FromArgb(255, 255, 192);
            notStarted.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            notStarted.Location = new Point(318, 395);
            notStarted.Name = "notStarted";
            notStarted.Size = new Size(135, 29);
            notStarted.TabIndex = 8;
            notStarted.TabStop = true;
            notStarted.Text = "Not Started";
            notStarted.UseVisualStyleBackColor = false;
            // 
            // inProgress
            // 
            inProgress.AutoSize = true;
            inProgress.BackColor = Color.FromArgb(255, 255, 192);
            inProgress.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            inProgress.Location = new Point(497, 395);
            inProgress.Name = "inProgress";
            inProgress.Size = new Size(131, 29);
            inProgress.TabIndex = 9;
            inProgress.TabStop = true;
            inProgress.Text = "In Progress";
            inProgress.UseVisualStyleBackColor = false;
            // 
            // Completed
            // 
            Completed.AutoSize = true;
            Completed.BackColor = Color.FromArgb(255, 255, 192);
            Completed.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Completed.Location = new Point(674, 395);
            Completed.Name = "Completed";
            Completed.Size = new Size(127, 29);
            Completed.TabIndex = 10;
            Completed.TabStop = true;
            Completed.Text = "Completed";
            Completed.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(255, 255, 192);
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(527, 449);
            label3.Name = "label3";
            label3.Size = new Size(67, 25);
            label3.TabIndex = 11;
            label3.Text = "Status";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 255, 192);
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Location = new Point(293, 381);
            panel1.Name = "panel1";
            panel1.Size = new Size(528, 103);
            panel1.TabIndex = 12;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(192, 255, 192);
            button2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(368, 517);
            button2.Name = "button2";
            button2.Size = new Size(85, 42);
            button2.TabIndex = 14;
            button2.Text = "Add";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // cancel_btn
            // 
            cancel_btn.BackColor = Color.FromArgb(255, 192, 192);
            cancel_btn.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cancel_btn.Location = new Point(637, 517);
            cancel_btn.Name = "cancel_btn";
            cancel_btn.Size = new Size(85, 42);
            cancel_btn.TabIndex = 15;
            cancel_btn.Text = "Cancel";
            cancel_btn.UseVisualStyleBackColor = false;
            cancel_btn.Click += delete_Click;
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(748, 32);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 16;
            // 
            // Add
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1100, 600);
            Controls.Add(monthCalendar1);
            Controls.Add(cancel_btn);
            Controls.Add(button2);
            Controls.Add(label3);
            Controls.Add(Completed);
            Controls.Add(inProgress);
            Controls.Add(notStarted);
            Controls.Add(label2);
            Controls.Add(textBox3);
            Controls.Add(task_label);
            Controls.Add(textBox1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Add";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "add";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label task_label;
        private Label label2;
        private TextBox textBox3;
        private RadioButton notStarted;
        private RadioButton inProgress;
        private RadioButton Completed;
        private Label label3;
        private Panel panel1;
        private Button button2;
        private Button cancel_btn;
        private MonthCalendar monthCalendar1;
    }
}