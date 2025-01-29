namespace Planner
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
            label1 = new Label();
            listView1 = new ListView();
            add = new Button();
            delete = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Rodetta", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(382, 9);
            label1.Name = "label1";
            label1.Size = new Size(301, 73);
            label1.TabIndex = 2;
            label1.Text = "Planner";
            // 
            // listView1
            // 
            listView1.BackColor = Color.FromArgb(255, 255, 192);
            listView1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listView1.Location = new Point(36, 85);
            listView1.Name = "listView1";
            listView1.Size = new Size(1004, 395);
            listView1.TabIndex = 3;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // add
            // 
            add.BackColor = Color.FromArgb(192, 255, 192);
            add.Location = new Point(172, 507);
            add.Name = "add";
            add.Size = new Size(85, 42);
            add.TabIndex = 4;
            add.Text = "Add";
            add.UseVisualStyleBackColor = false;
            add.Click += add_Click;
            // 
            // delete
            // 
            delete.BackColor = Color.FromArgb(255, 192, 192);
            delete.Location = new Point(802, 507);
            delete.Name = "delete";
            delete.Size = new Size(85, 42);
            delete.TabIndex = 5;
            delete.Text = "Delete";
            delete.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(192, 255, 255);
            button1.Location = new Point(494, 507);
            button1.Name = "button1";
            button1.Size = new Size(85, 42);
            button1.TabIndex = 6;
            button1.Text = "Edit";
            button1.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnableAllowFocusChange;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1084, 561);
            Controls.Add(button1);
            Controls.Add(delete);
            Controls.Add(add);
            Controls.Add(listView1);
            Controls.Add(label1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private ListView listView1;
        private Button add;
        private Button delete;
        private Button button1;
    }
}
