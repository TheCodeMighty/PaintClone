namespace PaintClone
{
    partial class About
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
            okButton = new Button();
            descriptionTextBox = new RichTextBox();
            SuspendLayout();
            // 
            // okButton
            // 
            okButton.Location = new Point(220, 208);
            okButton.Name = "okButton";
            okButton.Size = new Size(112, 34);
            okButton.TabIndex = 0;
            okButton.Text = "Ok";
            okButton.UseVisualStyleBackColor = true;
            okButton.Click += okButton_Click;
            // 
            // descriptionTextBox
            // 
            descriptionTextBox.Enabled = false;
            descriptionTextBox.Location = new Point(36, 23);
            descriptionTextBox.Name = "descriptionTextBox";
            descriptionTextBox.Size = new Size(501, 166);
            descriptionTextBox.TabIndex = 1;
            descriptionTextBox.Text = "";
            descriptionTextBox.TextChanged += descriptionTextBox_TextChanged;
            // 
            // About
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(574, 259);
            Controls.Add(descriptionTextBox);
            Controls.Add(okButton);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "About";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "About";
            ResumeLayout(false);
        }

        #endregion

        private Button okButton;
        private RichTextBox descriptionTextBox;
    }
}