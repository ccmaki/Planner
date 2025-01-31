namespace Planner
{
    partial class Form3
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
            Completed = new RadioButton();
            label4 = new Label();
            inProgress = new RadioButton();
            label1 = new Label();
            dateTimePicker1 = new DateTimePicker();
            cancel_btn = new Button();
            button2 = new Button();
            label3 = new Label();
            notStarted = new RadioButton();
            label2 = new Label();
            textBox3 = new TextBox();
            task_label = new Label();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // Completed
            // 
            Completed.AutoSize = true;
            Completed.BackColor = SystemColors.ActiveCaption;
            Completed.Font = new Font("MS Reference Sans Serif", 13.8F, FontStyle.Bold);
            Completed.ForeColor = Color.SteelBlue;
            Completed.Location = new Point(686, 416);
            Completed.Name = "Completed";
            Completed.Size = new Size(139, 28);
            Completed.TabIndex = 26;
            Completed.TabStop = true;
            Completed.Text = "Completed";
            Completed.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Perpetua Titling MT", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.SteelBlue;
            label4.Location = new Point(330, 48);
            label4.Name = "label4";
            label4.Size = new Size(455, 77);
            label4.TabIndex = 32;
            label4.Text = "DAILY TASK";
            // 
            // inProgress
            // 
            inProgress.AutoSize = true;
            inProgress.BackColor = SystemColors.ActiveCaption;
            inProgress.Font = new Font("MS Reference Sans Serif", 13.8F, FontStyle.Bold);
            inProgress.ForeColor = Color.SteelBlue;
            inProgress.Location = new Point(293, 416);
            inProgress.Name = "inProgress";
            inProgress.Size = new Size(148, 28);
            inProgress.TabIndex = 25;
            inProgress.TabStop = true;
            inProgress.Text = "In Progress";
            inProgress.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("MS Reference Sans Serif", 20.25F, FontStyle.Bold);
            label1.ForeColor = Color.SteelBlue;
            label1.Location = new Point(196, 284);
            label1.Name = "label1";
            label1.Size = new Size(83, 34);
            label1.TabIndex = 31;
            label1.Text = "Date";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarForeColor = Color.SteelBlue;
            dateTimePicker1.CalendarTitleForeColor = Color.SteelBlue;
            dateTimePicker1.CustomFormat = "mm/DD/yyyy";
            dateTimePicker1.Font = new Font("Yu Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(293, 284);
            dateTimePicker1.Margin = new Padding(3, 2, 3, 2);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(532, 46);
            dateTimePicker1.TabIndex = 30;
            // 
            // cancel_btn
            // 
            cancel_btn.BackColor = Color.FromArgb(255, 192, 192);
            cancel_btn.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cancel_btn.Location = new Point(613, 507);
            cancel_btn.Name = "cancel_btn";
            cancel_btn.Size = new Size(85, 42);
            cancel_btn.TabIndex = 29;
            cancel_btn.Text = "Cancel";
            cancel_btn.UseVisualStyleBackColor = false;
            cancel_btn.Click += cancel_btn_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(192, 255, 192);
            button2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(423, 507);
            button2.Name = "button2";
            button2.Size = new Size(85, 42);
            button2.TabIndex = 28;
            button2.Text = "Save";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ActiveCaption;
            label3.Font = new Font("MS Reference Sans Serif", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.SteelBlue;
            label3.Location = new Point(484, 344);
            label3.Name = "label3";
            label3.Size = new Size(138, 44);
            label3.TabIndex = 27;
            label3.Text = "Status";
            // 
            // notStarted
            // 
            notStarted.AutoSize = true;
            notStarted.BackColor = SystemColors.ActiveCaption;
            notStarted.Font = new Font("MS Reference Sans Serif", 13.8F, FontStyle.Bold);
            notStarted.ForeColor = Color.SteelBlue;
            notStarted.Location = new Point(484, 416);
            notStarted.Name = "notStarted";
            notStarted.Size = new Size(148, 28);
            notStarted.TabIndex = 24;
            notStarted.TabStop = true;
            notStarted.Text = "Not Started";
            notStarted.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("MS Reference Sans Serif", 20.25F, FontStyle.Bold);
            label2.ForeColor = Color.SteelBlue;
            label2.Location = new Point(109, 219);
            label2.Name = "label2";
            label2.Size = new Size(178, 34);
            label2.TabIndex = 23;
            label2.Text = "Description";
            // 
            // textBox3
            // 
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox3.Location = new Point(293, 203);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(532, 62);
            textBox3.TabIndex = 22;
            // 
            // task_label
            // 
            task_label.AutoSize = true;
            task_label.Font = new Font("MS Reference Sans Serif", 20.25F, FontStyle.Bold);
            task_label.ForeColor = Color.SteelBlue;
            task_label.Location = new Point(196, 146);
            task_label.Name = "task_label";
            task_label.Size = new Size(82, 34);
            task_label.TabIndex = 21;
            task_label.Text = "Task";
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.ForeColor = Color.SteelBlue;
            textBox1.Location = new Point(293, 132);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(532, 60);
            textBox1.TabIndex = 20;
            textBox1.Text = "Task";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1100, 600);
            Controls.Add(Completed);
            Controls.Add(label4);
            Controls.Add(inProgress);
            Controls.Add(label1);
            Controls.Add(dateTimePicker1);
            Controls.Add(cancel_btn);
            Controls.Add(button2);
            Controls.Add(label3);
            Controls.Add(notStarted);
            Controls.Add(label2);
            Controls.Add(textBox3);
            Controls.Add(task_label);
            Controls.Add(textBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form3";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form3";
            Load += Form3_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton Completed;
        private Label label4;
        private RadioButton inProgress;
        private Label label1;
        private DateTimePicker dateTimePicker1;
        private Button cancel_btn;
        private Button button2;
        private Label label3;
        private RadioButton notStarted;
        private Label label2;
        private TextBox textBox3;
        private Label task_label;
        private TextBox textBox1;
    }
}