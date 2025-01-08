namespace keyboardAndMouse
{
    partial class Form5
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
            menuStrip1 = new MenuStrip();
            form1ToolStripMenuItem = new ToolStripMenuItem();
            form2ToolStripMenuItem = new ToolStripMenuItem();
            form3ToolStripMenuItem = new ToolStripMenuItem();
            form4ToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { form1ToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1136, 28);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // form1ToolStripMenuItem
            // 
            form1ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { form2ToolStripMenuItem, form3ToolStripMenuItem, form4ToolStripMenuItem });
            form1ToolStripMenuItem.Name = "form1ToolStripMenuItem";
            form1ToolStripMenuItem.Size = new Size(65, 24);
            form1ToolStripMenuItem.Text = "Form1";
            form1ToolStripMenuItem.Click += form1ToolStripMenuItem_Click;
            // 
            // form2ToolStripMenuItem
            // 
            form2ToolStripMenuItem.Name = "form2ToolStripMenuItem";
            form2ToolStripMenuItem.Size = new Size(224, 26);
            form2ToolStripMenuItem.Text = "Form2";
            form2ToolStripMenuItem.Click += form2ToolStripMenuItem_Click;
            // 
            // form3ToolStripMenuItem
            // 
            form3ToolStripMenuItem.Name = "form3ToolStripMenuItem";
            form3ToolStripMenuItem.Size = new Size(224, 26);
            form3ToolStripMenuItem.Text = "Form3";
            form3ToolStripMenuItem.Click += form3ToolStripMenuItem_Click;
            // 
            // form4ToolStripMenuItem
            // 
            form4ToolStripMenuItem.Name = "form4ToolStripMenuItem";
            form4ToolStripMenuItem.Size = new Size(224, 26);
            form4ToolStripMenuItem.Text = "Form4";
            form4ToolStripMenuItem.Click += form4ToolStripMenuItem_Click;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1136, 620);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "Form5";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form5";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem form1ToolStripMenuItem;
        private ToolStripMenuItem form2ToolStripMenuItem;
        private ToolStripMenuItem form3ToolStripMenuItem;
        private ToolStripMenuItem form4ToolStripMenuItem;
    }
}