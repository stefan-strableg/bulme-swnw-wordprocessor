using System.ComponentModel;
using System.Text;

namespace WordProcessor
{
    public partial class WordProcessorForm : Form
    {
        BackgroundWorker worker = new BackgroundWorker();

        Thread runningThread;

        public WordProcessorForm()
        {
            InitializeComponent();
        }

        private void ProcessInput(object obj)
        {
            string input = (string)obj;
            string output = "";

            // Iterate through each character in the input
            foreach (char c in input)
            {
                if (Thread.CurrentThread != runningThread)
                    return;
                // Add the character and a dot to the output
                output += c + ".";

                // Update the output box on the main UI thread
                UpdateOutput(output);

                // Sleep for some time to simulate processing
                Thread.Sleep(10);
            }
        }

        private void UpdateOutput(string output)
        {
            // Check if the current thread is not the UI thread
            if (InvokeRequired)
            {
                // If not, invoke this method on the UI thread
                Invoke(new Action<string>(UpdateOutput), output);
            }
            else
            {
                // Update the output text box with the new output
                textBox_output.Text = output;
            }
        }

        private void textBox_input_TextChanged(object sender, EventArgs e)
        {
            Thread thread = new Thread(ProcessInput);
            runningThread = thread;
            thread.Start(textBox_input.Text);
        }
    }
}