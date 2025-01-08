namespace keyboardAndMouse
{
    partial class Form2
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtKeyCode = new TextBox();
            txtKeyValue = new TextBox();
            txtKeyData = new TextBox();
            chkShift = new CheckBox();
            chkControl = new CheckBox();
            chkAlt = new CheckBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(51, 66);
            label1.Name = "label1";
            label1.Size = new Size(81, 25);
            label1.TabIndex = 0;
            label1.Text = "keyCode";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(51, 117);
            label2.Name = "label2";
            label2.Size = new Size(81, 25);
            label2.TabIndex = 1;
            label2.Text = "keyValue";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(51, 174);
            label3.Name = "label3";
            label3.Size = new Size(76, 25);
            label3.TabIndex = 2;
            label3.Text = "keyData";
            // 
            // txtKeyCode
            // 
            txtKeyCode.Location = new Point(145, 67);
            txtKeyCode.Name = "txtKeyCode";
            txtKeyCode.Size = new Size(185, 27);
            txtKeyCode.TabIndex = 3;
            // 
            // txtKeyValue
            // 
            txtKeyValue.Location = new Point(145, 118);
            txtKeyValue.Name = "txtKeyValue";
            txtKeyValue.Size = new Size(185, 27);
            txtKeyValue.TabIndex = 4;
            // 
            // txtKeyData
            // 
            txtKeyData.Location = new Point(145, 175);
            txtKeyData.Name = "txtKeyData";
            txtKeyData.Size = new Size(185, 27);
            txtKeyData.TabIndex = 5;
            // 
            // chkShift
            // 
            chkShift.AutoSize = true;
            chkShift.Location = new Point(59, 235);
            chkShift.Name = "chkShift";
            chkShift.Size = new Size(59, 24);
            chkShift.TabIndex = 6;
            chkShift.Text = "shift";
            chkShift.UseVisualStyleBackColor = true;
            // 
            // chkControl
            // 
            chkControl.AutoSize = true;
            chkControl.Location = new Point(175, 235);
            chkControl.Name = "chkControl";
            chkControl.Size = new Size(80, 24);
            chkControl.TabIndex = 7;
            chkControl.Text = "Control";
            chkControl.UseVisualStyleBackColor = true;
            // 
            // chkAlt
            // 
            chkAlt.AutoSize = true;
            chkAlt.Location = new Point(300, 235);
            chkAlt.Name = "chkAlt";
            chkAlt.Size = new Size(50, 24);
            chkAlt.TabIndex = 8;
            chkAlt.Text = "Alt";
            chkAlt.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(chkAlt);
            Controls.Add(chkControl);
            Controls.Add(chkShift);
            Controls.Add(txtKeyData);
            Controls.Add(txtKeyValue);
            Controls.Add(txtKeyCode);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            KeyDown += Form2_KeyDown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtKeyCode;
        private TextBox txtKeyValue;
        private TextBox txtKeyData;
        private CheckBox chkShift;
        private CheckBox chkControl;
        private CheckBox chkAlt;
    }
}