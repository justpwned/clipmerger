namespace clipmerger
{
	partial class Form1
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
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
			this.mergeButton = new System.Windows.Forms.Button();
			this.outputTextbox = new System.Windows.Forms.TextBox();
			this.outputLabel = new System.Windows.Forms.Label();
			this.filesListbox = new System.Windows.Forms.ListBox();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.selectClipsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.saveButton = new System.Windows.Forms.Button();
			this.downButton = new System.Windows.Forms.Button();
			this.upButton = new System.Windows.Forms.Button();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.Multiselect = true;
			// 
			// saveFileDialog1
			// 
			this.saveFileDialog1.DefaultExt = "mp4";
			// 
			// mergeButton
			// 
			this.mergeButton.Location = new System.Drawing.Point(130, 369);
			this.mergeButton.Name = "mergeButton";
			this.mergeButton.Size = new System.Drawing.Size(99, 22);
			this.mergeButton.TabIndex = 4;
			this.mergeButton.Text = "Merge";
			this.mergeButton.UseVisualStyleBackColor = true;
			this.mergeButton.Click += new System.EventHandler(this.mergeButton_Click);
			// 
			// outputTextbox
			// 
			this.outputTextbox.Location = new System.Drawing.Point(47, 34);
			this.outputTextbox.Name = "outputTextbox";
			this.outputTextbox.Size = new System.Drawing.Size(305, 20);
			this.outputTextbox.TabIndex = 5;
			// 
			// outputLabel
			// 
			this.outputLabel.AutoSize = true;
			this.outputLabel.Location = new System.Drawing.Point(3, 37);
			this.outputLabel.Name = "outputLabel";
			this.outputLabel.Size = new System.Drawing.Size(42, 13);
			this.outputLabel.TabIndex = 6;
			this.outputLabel.Text = "Output:";
			// 
			// filesListbox
			// 
			this.filesListbox.FormattingEnabled = true;
			this.filesListbox.Location = new System.Drawing.Point(47, 60);
			this.filesListbox.Name = "filesListbox";
			this.filesListbox.Size = new System.Drawing.Size(305, 303);
			this.filesListbox.TabIndex = 7;
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(364, 24);
			this.menuStrip1.TabIndex = 8;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectClipsToolStripMenuItem,
            this.saveAsToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.fileToolStripMenuItem.Text = "&File";
			// 
			// selectClipsToolStripMenuItem
			// 
			this.selectClipsToolStripMenuItem.Name = "selectClipsToolStripMenuItem";
			this.selectClipsToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
			this.selectClipsToolStripMenuItem.Text = "Select clips";
			this.selectClipsToolStripMenuItem.Click += new System.EventHandler(this.selectClipsToolStripMenuItem_Click);
			// 
			// saveAsToolStripMenuItem
			// 
			this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
			this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
			this.saveAsToolStripMenuItem.Text = "Save as";
			this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
			// 
			// helpToolStripMenuItem
			// 
			this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
			this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
			this.helpToolStripMenuItem.Text = "&Help";
			this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
			// 
			// saveButton
			// 
			this.saveButton.BackgroundImage = global::clipmerger.Properties.Resources.save;
			this.saveButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.saveButton.FlatAppearance.BorderSize = 0;
			this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.saveButton.Location = new System.Drawing.Point(12, 60);
			this.saveButton.Name = "saveButton";
			this.saveButton.Size = new System.Drawing.Size(25, 25);
			this.saveButton.TabIndex = 11;
			this.saveButton.UseVisualStyleBackColor = true;
			this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
			// 
			// downButton
			// 
			this.downButton.BackgroundImage = global::clipmerger.Properties.Resources.arrow_down;
			this.downButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.downButton.FlatAppearance.BorderSize = 0;
			this.downButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.downButton.Location = new System.Drawing.Point(12, 122);
			this.downButton.Name = "downButton";
			this.downButton.Size = new System.Drawing.Size(25, 25);
			this.downButton.TabIndex = 10;
			this.downButton.UseVisualStyleBackColor = true;
			this.downButton.Click += new System.EventHandler(this.downButton_Click);
			// 
			// upButton
			// 
			this.upButton.BackgroundImage = global::clipmerger.Properties.Resources.arrow_up;
			this.upButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.upButton.FlatAppearance.BorderSize = 0;
			this.upButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.upButton.Location = new System.Drawing.Point(12, 91);
			this.upButton.Name = "upButton";
			this.upButton.Size = new System.Drawing.Size(25, 25);
			this.upButton.TabIndex = 9;
			this.upButton.UseVisualStyleBackColor = true;
			this.upButton.Click += new System.EventHandler(this.upButton_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(364, 402);
			this.Controls.Add(this.saveButton);
			this.Controls.Add(this.downButton);
			this.Controls.Add(this.upButton);
			this.Controls.Add(this.filesListbox);
			this.Controls.Add(this.outputLabel);
			this.Controls.Add(this.outputTextbox);
			this.Controls.Add(this.mergeButton);
			this.Controls.Add(this.menuStrip1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MainMenuStrip = this.menuStrip1;
			this.MaximizeBox = false;
			this.Name = "Form1";
			this.Text = "Clip Merger";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.SaveFileDialog saveFileDialog1;
		private System.Windows.Forms.Button mergeButton;
		private System.Windows.Forms.TextBox outputTextbox;
		private System.Windows.Forms.Label outputLabel;
		private System.Windows.Forms.ListBox filesListbox;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem selectClipsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
		private System.Windows.Forms.Button upButton;
		private System.Windows.Forms.Button downButton;
		private System.Windows.Forms.Button saveButton;
	}
}

