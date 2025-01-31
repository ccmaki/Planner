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
            label3 = new Label();
            button2 = new Button();
            cancel_btn = new Button();
            dateTimePicker1 = new DateTimePicker();
            label1 = new Label();
            label4 = new Label();
            inProgress = new RadioButton();
            Completed = new RadioButton();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(321, 136);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(608, 80);
            textBox1.TabIndex = 0;
            textBox1.Text = "ASdf";
            // 
            // task_label
            // 
            task_label.AutoSize = true;
            task_label.Font = new Font("MS Reference Sans Serif", 13.8F, FontStyle.Bold);
            task_label.Location = new Point(218, 167);
            task_label.Name = "task_label";
            task_label.Size = new Size(70, 28);
            task_label.TabIndex = 1;
            task_label.Text = "Task";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("MS Reference Sans Serif", 13.8F, FontStyle.Bold);
            label2.Location = new Point(132, 247);
            label2.Name = "label2";
            label2.Size = new Size(153, 28);
            label2.TabIndex = 5;
            label2.Text = "Description";
            label2.Click += label2_Click;
            // 
            // textBox3
            // 
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox3.Location = new Point(321, 231);
            textBox3.Margin = new Padding(3, 4, 3, 4);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(608, 82);
            textBox3.TabIndex = 4;
            // 
            // notStarted
            // 
            notStarted.AutoSize = true;
            notStarted.BackColor = SystemColors.ActiveCaption;
            notStarted.Font = new Font("MS Reference Sans Serif", 13.8F, FontStyle.Bold);
            notStarted.Location = new Point(540, 514);
            notStarted.Margin = new Padding(3, 4, 3, 4);
            notStarted.Name = "notStarted";
            notStarted.Size = new Size(178, 32);
            notStarted.TabIndex = 8;
            notStarted.TabStop = true;
            notStarted.Text = "Not Started";
            notStarted.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ActiveCaption;
            label3.Font = new Font("MS Reference Sans Serif", 13.8F, FontStyle.Bold);
            label3.Location = new Point(585, 453);
            label3.Name = "label3";
            label3.Size = new Size(93, 28);
            label3.TabIndex = 11;
            label3.Text = "Status";
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(192, 255, 192);
            button2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(470, 636);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(97, 56);
            button2.TabIndex = 14;
            button2.Text = "Add";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // cancel_btn
            // 
            cancel_btn.BackColor = Color.FromArgb(255, 192, 192);
            cancel_btn.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cancel_btn.Location = new Point(687, 636);
            cancel_btn.Margin = new Padding(3, 4, 3, 4);
            cancel_btn.Name = "cancel_btn";
            cancel_btn.Size = new Size(97, 56);
            cancel_btn.TabIndex = 15;
            cancel_btn.Text = "Cancel";
            cancel_btn.UseVisualStyleBackColor = false;
            cancel_btn.Click += delete_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = "mm/DD/yyyy";
            dateTimePicker1.Font = new Font("Yu Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(321, 338);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(608, 56);
            dateTimePicker1.TabIndex = 17;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("MS Reference Sans Serif", 13.8F, FontStyle.Bold);
            label1.Location = new Point(218, 347);
            label1.Name = "label1";
            label1.Size = new Size(71, 28);
            label1.TabIndex = 18;
            label1.Text = "Date";
            label1.Click += label1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Perpetua Titling MT", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.SteelBlue;
            label4.Location = new Point(364, 24);
            label4.Name = "label4";
            label4.Size = new Size(565, 96);
            label4.TabIndex = 19;
            label4.Text = "DAILY TASK";
            // 
            // inProgress
            // 
            inProgress.AutoSize = true;
            inProgress.BackColor = SystemColors.ActiveCaption;
            inProgress.Font = new Font("MS Reference Sans Serif", 13.8F, FontStyle.Bold);
            inProgress.Location = new Point(321, 514);
            inProgress.Margin = new Padding(3, 4, 3, 4);
            inProgress.Name = "inProgress";
            inProgress.Size = new Size(177, 32);
            inProgress.TabIndex = 9;
            inProgress.TabStop = true;
            inProgress.Text = "In Progress";
            inProgress.UseVisualStyleBackColor = false;
            // 
            // Completed
            // 
            Completed.AutoSize = true;
            Completed.BackColor = SystemColors.ActiveCaption;
            Completed.Font = new Font("MS Reference Sans Serif", 13.8F, FontStyle.Bold);
            Completed.Location = new Point(770, 514);
            Completed.Margin = new Padding(3, 4, 3, 4);
            Completed.Name = "Completed";
            Completed.Size = new Size(165, 32);
            Completed.TabIndex = 10;
            Completed.TabStop = true;
            Completed.Text = "Completed";
            Completed.UseVisualStyleBackColor = false;
            // 
            // Add
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1257, 800);
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
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
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
        private Label label3;
        private Button button2;
        private Button cancel_btn;
        private DateTimePicker dateTimePicker1;
        private Label label1;
        private Label label4;
        private RadioButton inProgress;
        private RadioButton Completed;
    }
}