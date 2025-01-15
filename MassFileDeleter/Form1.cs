using System;
using System.IO;
using System.Windows.Forms;

namespace MassFileDeleter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void extensionTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow control characters (e.g., backspace).
            if (char.IsControl(e.KeyChar))
            {
                return;
            }

            // Allow letters and a dot.
            if (char.IsLetter(e.KeyChar) || (e.KeyChar == '.'))
            {
                return;
            }

            // Block any other characters.
            e.Handled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Set a default file extension.
            extensionTextBox.Text = "txt";
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            // Get folder path and file extension from textboxes.
            string folderPath = folderTextBox.Text.Trim();
            string extensionFilter = extensionTextBox.Text.Trim().ToLower();

            // Validate the folder path.
            if (!Directory.Exists(folderPath))
            {
                MessageBox.Show("The specified directory does not exist. Please enter a valid path.",
                                "Directory Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validate the file extension.
            // If the extension does not start with a '.', add it.
            if (!extensionFilter.StartsWith("."))
            {
                extensionFilter = "." + extensionFilter;
            }

            // Ask the user for confirmation before deleting files.
            DialogResult confirmation = MessageBox.Show(
                $"Are you sure you want to delete all files with the '{extensionFilter}' extension?",
                "Confirm Deletion",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirmation != DialogResult.Yes)
            {
                // User chose not to proceed.
                return;
            }

            // Build a search pattern for the file extension (e.g., "*.txt").
            string searchPattern = "*" + extensionFilter;

            // Determine whether to search recursively based on the checkbox.
            SearchOption searchOption = recursiveCheckBox1.Checked ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly;

            // Retrieve all files in the directory (and subdirectories if recursive).
            string[] files;
            try
            {
                files = Directory.GetFiles(folderPath, searchPattern, searchOption);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error accessing files: {ex.Message}",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool anyDeleted = false;

            foreach (string filePath in files)
            {
                try
                {
                    File.Delete(filePath);
                    anyDeleted = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error deleting file '{filePath}': {ex.Message}",
                                    "Deletion Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            // Inform the user of the result.
            if (anyDeleted)
            {
                MessageBox.Show("File deletion complete.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No files with the specified extension were found.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // If you need to perform an action when the recursive checkbox state changes,
        // you can add your logic here. Otherwise, this event handler can be left empty.
        private void recursiveCheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            // Optional: Implement any additional logic on checking/unchecking the box.
        }
    }
}
