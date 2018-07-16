namespace IOBTag
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bodyTextBox = new System.Windows.Forms.TextBox();
            this.wordsPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewHelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.skip = new System.Windows.Forms.Button();
            this.currentLabel = new System.Windows.Forms.Label();
            this.savedLabel = new System.Windows.Forms.Label();
            this.back = new System.Windows.Forms.Button();
            this.fill = new System.Windows.Forms.Button();
            this.instruct = new System.Windows.Forms.Label();
            this.jumpBox = new System.Windows.Forms.TextBox();
            this.jumpLabel = new System.Windows.Forms.Label();
            this.jump = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bodyTextBox
            // 
            this.bodyTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bodyTextBox.BackColor = System.Drawing.Color.White;
            this.bodyTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bodyTextBox.Location = new System.Drawing.Point(15, 44);
            this.bodyTextBox.Multiline = true;
            this.bodyTextBox.Name = "bodyTextBox";
            this.bodyTextBox.ReadOnly = true;
            this.bodyTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.bodyTextBox.Size = new System.Drawing.Size(757, 61);
            this.bodyTextBox.TabIndex = 2;
            this.bodyTextBox.TabStop = false;
            // 
            // wordsPanel
            // 
            this.wordsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.wordsPanel.AutoScroll = true;
            this.wordsPanel.Location = new System.Drawing.Point(15, 111);
            this.wordsPanel.Name = "wordsPanel";
            this.wordsPanel.Size = new System.Drawing.Size(757, 391);
            this.wordsPanel.TabIndex = 3;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadFileToolStripMenuItem,
            this.exportFileToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // loadFileToolStripMenuItem
            // 
            this.loadFileToolStripMenuItem.Name = "loadFileToolStripMenuItem";
            this.loadFileToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.loadFileToolStripMenuItem.Text = "Load File";
            this.loadFileToolStripMenuItem.Click += new System.EventHandler(this.loadFileToolStripMenuItem_Click);
            // 
            // exportFileToolStripMenuItem
            // 
            this.exportFileToolStripMenuItem.Name = "exportFileToolStripMenuItem";
            this.exportFileToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exportFileToolStripMenuItem.Text = "Save File";
            this.exportFileToolStripMenuItem.Click += new System.EventHandler(this.exportFileToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewHelpToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Visible = false;
            // 
            // viewHelpToolStripMenuItem
            // 
            this.viewHelpToolStripMenuItem.Name = "viewHelpToolStripMenuItem";
            this.viewHelpToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.viewHelpToolStripMenuItem.Text = "View Help";
            this.viewHelpToolStripMenuItem.Click += new System.EventHandler(this.viewHelpToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // skip
            // 
            this.skip.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.skip.Enabled = false;
            this.skip.Location = new System.Drawing.Point(452, 526);
            this.skip.Name = "skip";
            this.skip.Size = new System.Drawing.Size(75, 23);
            this.skip.TabIndex = 5;
            this.skip.Text = "Next";
            this.skip.UseVisualStyleBackColor = true;
            this.skip.Click += new System.EventHandler(this.skip_Click);
            // 
            // currentLabel
            // 
            this.currentLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.currentLabel.AutoSize = true;
            this.currentLabel.Location = new System.Drawing.Point(0, 548);
            this.currentLabel.Name = "currentLabel";
            this.currentLabel.Size = new System.Drawing.Size(0, 13);
            this.currentLabel.TabIndex = 6;
            // 
            // savedLabel
            // 
            this.savedLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.savedLabel.AutoSize = true;
            this.savedLabel.Location = new System.Drawing.Point(699, 539);
            this.savedLabel.Name = "savedLabel";
            this.savedLabel.Size = new System.Drawing.Size(0, 13);
            this.savedLabel.TabIndex = 7;
            // 
            // back
            // 
            this.back.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.back.Enabled = false;
            this.back.Location = new System.Drawing.Point(251, 526);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(75, 23);
            this.back.TabIndex = 8;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // fill
            // 
            this.fill.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.fill.Enabled = false;
            this.fill.Location = new System.Drawing.Point(352, 526);
            this.fill.Name = "fill";
            this.fill.Size = new System.Drawing.Size(75, 23);
            this.fill.TabIndex = 9;
            this.fill.Text = "Fill O";
            this.fill.UseVisualStyleBackColor = true;
            this.fill.Click += new System.EventHandler(this.fill_Click);
            // 
            // instruct
            // 
            this.instruct.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.instruct.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.instruct.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instruct.Location = new System.Drawing.Point(0, 505);
            this.instruct.Name = "instruct";
            this.instruct.Size = new System.Drawing.Size(1006, 18);
            this.instruct.TabIndex = 10;
            this.instruct.Text = "O  : Out  - M : Medication - B-ADR : Begin Negative Reaction  -  I-ADR : Part of " +
    "Negative Reaction  -  B-IND : Begin Positive Reaction  -  I-IND : Part of Positi" +
    "ve Reaction";
            this.instruct.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // jumpBox
            // 
            this.jumpBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.jumpBox.Enabled = false;
            this.jumpBox.Location = new System.Drawing.Point(515, 528);
            this.jumpBox.Name = "jumpBox";
            this.jumpBox.Size = new System.Drawing.Size(60, 20);
            this.jumpBox.TabIndex = 11;
            // 
            // jumpLabel
            // 
            this.jumpLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.jumpLabel.AutoSize = true;
            this.jumpLabel.Location = new System.Drawing.Point(462, 531);
            this.jumpLabel.Name = "jumpLabel";
            this.jumpLabel.Size = new System.Drawing.Size(47, 13);
            this.jumpLabel.TabIndex = 12;
            this.jumpLabel.Text = "Skip To:";
            this.jumpLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // jump
            // 
            this.jump.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.jump.Enabled = false;
            this.jump.Location = new System.Drawing.Point(581, 526);
            this.jump.Name = "jump";
            this.jump.Size = new System.Drawing.Size(75, 23);
            this.jump.TabIndex = 13;
            this.jump.Text = "Go";
            this.jump.UseVisualStyleBackColor = true;
            this.jump.Click += new System.EventHandler(this.jump_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.jump);
            this.Controls.Add(this.jumpLabel);
            this.Controls.Add(this.jumpBox);
            this.Controls.Add(this.instruct);
            this.Controls.Add(this.fill);
            this.Controls.Add(this.back);
            this.Controls.Add(this.savedLabel);
            this.Controls.Add(this.currentLabel);
            this.Controls.Add(this.skip);
            this.Controls.Add(this.wordsPanel);
            this.Controls.Add(this.bodyTextBox);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Name = "Form1";
            this.Text = "IOBTag";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox bodyTextBox;
        private System.Windows.Forms.FlowLayoutPanel wordsPanel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button skip;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewHelpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Label currentLabel;
        private System.Windows.Forms.Label savedLabel;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.ToolStripMenuItem exportFileToolStripMenuItem;
        private System.Windows.Forms.Button fill;
        private System.Windows.Forms.Label instruct;
        private System.Windows.Forms.TextBox jumpBox;
        private System.Windows.Forms.Label jumpLabel;
        private System.Windows.Forms.Button jump;
    }
}

