namespace Dz1
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
            btnTask1 = new Button();
            btnTask2 = new Button();
            btnTask3 = new Button();
            btnTask4 = new Button();
            SuspendLayout();
            // 
            // btnTask1
            // 
            btnTask1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnTask1.Location = new Point(12, 12);
            btnTask1.Name = "btnTask1";
            btnTask1.Size = new Size(165, 72);
            btnTask1.TabIndex = 0;
            btnTask1.Tag = "1";
            btnTask1.Text = "Task1";
            btnTask1.UseVisualStyleBackColor = true;
            btnTask1.Click += btnTask_Click;
            // 
            // btnTask2
            // 
            btnTask2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnTask2.Location = new Point(183, 12);
            btnTask2.Name = "btnTask2";
            btnTask2.Size = new Size(165, 72);
            btnTask2.TabIndex = 1;
            btnTask2.Tag = "2";
            btnTask2.Text = "Task2";
            btnTask2.UseVisualStyleBackColor = true;
            btnTask2.Click += btnTask_Click;
            // 
            // btnTask3
            // 
            btnTask3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnTask3.Location = new Point(12, 90);
            btnTask3.Name = "btnTask3";
            btnTask3.Size = new Size(165, 72);
            btnTask3.TabIndex = 2;
            btnTask3.Tag = "3";
            btnTask3.Text = "Task3";
            btnTask3.UseVisualStyleBackColor = true;
            btnTask3.Click += btnTask_Click;
            // 
            // btnTask4
            // 
            btnTask4.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnTask4.Location = new Point(183, 90);
            btnTask4.Name = "btnTask4";
            btnTask4.Size = new Size(165, 72);
            btnTask4.TabIndex = 3;
            btnTask4.Tag = "4";
            btnTask4.Text = "Task4";
            btnTask4.UseVisualStyleBackColor = true;
            btnTask4.Click += btnTask_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(360, 176);
            Controls.Add(btnTask4);
            Controls.Add(btnTask3);
            Controls.Add(btnTask2);
            Controls.Add(btnTask1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnTask1;
        private Button btnTask2;
        private Button btnTask3;
        private Button btnTask4;
    }
}