namespace keyboardAndMouse
{
    partial class Form4
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
            pictuerBox1 = new PictureBox();
            cboColor = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            cboWidth = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)pictuerBox1).BeginInit();
            SuspendLayout();
            // 
            // pictuerBox1
            // 
            pictuerBox1.BackColor = Color.White;
            pictuerBox1.BorderStyle = BorderStyle.Fixed3D;
            pictuerBox1.Location = new Point(12, 12);
            pictuerBox1.Name = "pictuerBox1";
            pictuerBox1.Size = new Size(776, 412);
            pictuerBox1.TabIndex = 0;
            pictuerBox1.TabStop = false;
            pictuerBox1.MouseDown += pictuerBox1_MouseDown;
            pictuerBox1.MouseMove += pictuerBox1_MouseMove;
            // 
            // cboColor
            // 
            cboColor.FormattingEnabled = true;
            cboColor.Location = new Point(102, 447);
            cboColor.Name = "cboColor";
            cboColor.Size = new Size(151, 28);
            cboColor.TabIndex = 1;
            cboColor.SelectedIndexChanged += cboColor_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(51, 450);
            label1.Name = "label1";
            label1.Size = new Size(19, 23);
            label1.TabIndex = 2;
            label1.Text = "สี";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(334, 452);
            label2.Name = "label2";
            label2.Size = new Size(48, 23);
            label2.TabIndex = 3;
            label2.Text = "ขนาด";
            // 
            // cboWidth
            // 
            cboWidth.FormattingEnabled = true;
            cboWidth.Location = new Point(388, 449);
            cboWidth.Name = "cboWidth";
            cboWidth.Size = new Size(151, 28);
            cboWidth.TabIndex = 4;
            cboWidth.SelectedIndexChanged += cboWidth_SelectedIndexChanged;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 506);
            Controls.Add(cboWidth);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cboColor);
            Controls.Add(pictuerBox1);
            Name = "Form4";
            Text = "Form4";
            Load += Form4_Load;
            ((System.ComponentModel.ISupportInitialize)pictuerBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictuerBox1;
        private ComboBox cboColor;
        private Label label1;
        private Label label2;
        private ComboBox cboWidth;
    }
}