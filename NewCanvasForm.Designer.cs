namespace WinFormsLab
{
    partial class NewCanvasForm
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
            widthLabel = new Label();
            heightLabel = new Label();
            backgroundColorLabel = new Label();
            newCanvasButton = new Button();
            cancelButton = new Button();
            backgroundColorDialog = new ColorDialog();
            colorDialogButton = new Button();
            widthUpDown = new NumericUpDown();
            heightUpDown = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)widthUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)heightUpDown).BeginInit();
            SuspendLayout();
            // 
            // widthLabel
            // 
            widthLabel.AutoSize = true;
            widthLabel.Location = new Point(21, 20);
            widthLabel.Name = "widthLabel";
            widthLabel.Size = new Size(64, 25);
            widthLabel.TabIndex = 0;
            widthLabel.Text = "Width:";
            // 
            // heightLabel
            // 
            heightLabel.AutoSize = true;
            heightLabel.Location = new Point(21, 66);
            heightLabel.Name = "heightLabel";
            heightLabel.Size = new Size(69, 25);
            heightLabel.TabIndex = 1;
            heightLabel.Text = "Height:";
            // 
            // backgroundColorLabel
            // 
            backgroundColorLabel.AutoSize = true;
            backgroundColorLabel.Location = new Point(21, 112);
            backgroundColorLabel.Name = "backgroundColorLabel";
            backgroundColorLabel.Size = new Size(111, 25);
            backgroundColorLabel.TabIndex = 2;
            backgroundColorLabel.Text = "Background:";
            // 
            // newCanvasButton
            // 
            newCanvasButton.Location = new Point(102, 162);
            newCanvasButton.Name = "newCanvasButton";
            newCanvasButton.Size = new Size(112, 34);
            newCanvasButton.TabIndex = 3;
            newCanvasButton.Text = "New";
            newCanvasButton.UseVisualStyleBackColor = true;
            newCanvasButton.Click += newCanvasButton_Click_1;
            // 
            // cancelButton
            // 
            cancelButton.Location = new Point(233, 162);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(112, 34);
            cancelButton.TabIndex = 4;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += cancelButton_Click;
            // 
            // colorDialogButton
            // 
            colorDialogButton.Location = new Point(138, 107);
            colorDialogButton.Name = "colorDialogButton";
            colorDialogButton.Size = new Size(180, 34);
            colorDialogButton.TabIndex = 7;
            colorDialogButton.UseVisualStyleBackColor = true;
            colorDialogButton.Click += colorDialogButton_Click;
            // 
            // widthUpDown
            // 
            widthUpDown.Location = new Point(138, 18);
            widthUpDown.Maximum = new decimal(new int[] { 2000, 0, 0, 0 });
            widthUpDown.Name = "widthUpDown";
            widthUpDown.Size = new Size(180, 31);
            widthUpDown.TabIndex = 8;
            widthUpDown.ValueChanged += widthUpDown_ValueChanged;
            // 
            // heightUpDown
            // 
            heightUpDown.Location = new Point(138, 64);
            heightUpDown.Maximum = new decimal(new int[] { 2000, 0, 0, 0 });
            heightUpDown.Name = "heightUpDown";
            heightUpDown.Size = new Size(180, 31);
            heightUpDown.TabIndex = 9;
            heightUpDown.ValueChanged += heightUpDown_ValueChanged;
            // 
            // NewCanvasForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(378, 208);
            Controls.Add(heightUpDown);
            Controls.Add(widthUpDown);
            Controls.Add(colorDialogButton);
            Controls.Add(cancelButton);
            Controls.Add(newCanvasButton);
            Controls.Add(backgroundColorLabel);
            Controls.Add(heightLabel);
            Controls.Add(widthLabel);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "NewCanvasForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "New Image...";
            ((System.ComponentModel.ISupportInitialize)widthUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)heightUpDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label widthLabel;
        private Label heightLabel;
        private Label backgroundColorLabel;
        private Button newCanvasButton;
        private Button cancelButton;
        private ColorDialog backgroundColorDialog;
        private Button colorDialogButton;
        private NumericUpDown widthUpDown;
        private NumericUpDown heightUpDown;
    }
}