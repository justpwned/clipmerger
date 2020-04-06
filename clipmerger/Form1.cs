using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;

namespace clipmerger
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void mergeButton_Click(object sender, EventArgs e)
		{
			if (filesListbox.Items.Count == 0)
			{
				MessageBox.Show("You didn't select any clips!", "You didn't select any clips!", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			else if (outputTextbox.Text == "")
			{
				MessageBox.Show("You didn't specify output file!", "You didn't specify output file!", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			else
			{
				try
				{
					using (Process process = new Process())
					{
						ProcessStartInfo startInfo = new ProcessStartInfo();
						startInfo.WindowStyle = ProcessWindowStyle.Hidden;
						startInfo.FileName = "cmd.exe";

						StringBuilder sb = new StringBuilder();
						foreach (var f in filesListbox.Items)
						{
							sb.Append($"\"{(f as FileRecord).FullFilename}\"").Append(" ");
						}
						startInfo.Arguments = $"/C vlc {sb.ToString()} --sout \"#gather:std{{access=file,dst={outputTextbox.Text}}}\" --sout-keep";

						process.StartInfo = startInfo;
						process.Start();
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}

		private void helpToolStripMenuItem_Click(object sender, EventArgs e)
		{
			string message = "ClipMerger made by https://github.com/justpwned";
			MessageBox.Show(message, "Help");
		}

		private void selectClipsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			DialogResult result = openFileDialog1.ShowDialog();
			if (result == DialogResult.OK)
			{
				filesListbox.Items.Clear();

				for (int i = 0; i < openFileDialog1.FileNames.Length; ++i)
				{
					filesListbox.Items.Add(new FileRecord(openFileDialog1.FileNames[i], openFileDialog1.SafeFileNames[i]));
				}
			}
		}

		private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			DialogResult result = saveFileDialog1.ShowDialog();
			if (result == DialogResult.OK)
			{
				outputTextbox.Text = saveFileDialog1.FileName;
			}
		}

		private void upButton_Click(object sender, EventArgs e)
		{
			if (filesListbox.SelectedIndex > 0)
			{
				object temp = filesListbox.Items[filesListbox.SelectedIndex];
				filesListbox.Items[filesListbox.SelectedIndex] = filesListbox.Items[filesListbox.SelectedIndex - 1];
				filesListbox.Items[filesListbox.SelectedIndex - 1] = temp;
				filesListbox.SelectedIndex--;
			}
		}

		private void downButton_Click(object sender, EventArgs e)
		{
			if (filesListbox.SelectedIndex >= 0 && filesListbox.SelectedIndex <= filesListbox.Items.Count - 2)
			{
				object temp = filesListbox.Items[filesListbox.SelectedIndex];
				filesListbox.Items[filesListbox.SelectedIndex] = filesListbox.Items[filesListbox.SelectedIndex + 1];
				filesListbox.Items[filesListbox.SelectedIndex + 1] = temp;
				filesListbox.SelectedIndex++;
			}
		}

		private void saveButton_Click(object sender, EventArgs e)
		{
			saveAsToolStripMenuItem_Click(sender, e);
		}
	}
}
