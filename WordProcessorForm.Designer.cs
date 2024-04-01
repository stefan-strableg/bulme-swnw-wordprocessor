namespace WordProcessor
{
    partial class WordProcessorForm
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
            textBox_input = new TextBox();
            textBox_output = new TextBox();
            SuspendLayout();
            // 
            // textBox_input
            // 
            textBox_input.AcceptsReturn = true;
            textBox_input.Location = new Point(12, 12);
            textBox_input.Multiline = true;
            textBox_input.Name = "textBox_input";
            textBox_input.Size = new Size(619, 718);
            textBox_input.TabIndex = 0;
            textBox_input.TextChanged += textBox_input_TextChanged;
            // 
            // textBox_output
            // 
            textBox_output.AcceptsReturn = true;
            textBox_output.Location = new Point(772, 17);
            textBox_output.Multiline = true;
            textBox_output.Name = "textBox_output";
            textBox_output.ReadOnly = true;
            textBox_output.Size = new Size(632, 713);
            textBox_output.TabIndex = 1;
            // 
            // WordProcessorForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1416, 742);
            Controls.Add(textBox_output);
            Controls.Add(textBox_input);
            Name = "WordProcessorForm";
            Text = "Word Processor";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox_input;
        private TextBox textBox_output;
    }
}