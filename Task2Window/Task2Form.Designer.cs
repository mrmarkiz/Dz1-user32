namespace Task2Window
{
    partial class Task2Form
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
            textBoxWindowName = new TextBox();
            label1 = new Label();
            buttonFind = new Button();
            SuspendLayout();
            // 
            // textBoxWindowName
            // 
            textBoxWindowName.Location = new Point(12, 40);
            textBoxWindowName.Name = "textBoxWindowName";
            textBoxWindowName.Size = new Size(173, 27);
            textBoxWindowName.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(42, 16);
            label1.Name = "label1";
            label1.Size = new Size(112, 20);
            label1.TabIndex = 1;
            label1.Text = "Window to find";
            // 
            // buttonFind
            // 
            buttonFind.Location = new Point(50, 73);
            buttonFind.Name = "buttonFind";
            buttonFind.Size = new Size(94, 41);
            buttonFind.TabIndex = 2;
            buttonFind.Text = "Find";
            buttonFind.UseVisualStyleBackColor = true;
            // 
            // Task2Form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonFind);
            Controls.Add(label1);
            Controls.Add(textBoxWindowName);
            Name = "Task2Form";
            Text = "Task2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxWindowName;
        private Label label1;
        private Button buttonFind;
    }
}