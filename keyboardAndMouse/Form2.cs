using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace keyboardAndMouse
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
        }

        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {
            txtKeyCode.Text = e.KeyCode.ToString();
            txtKeyValue.Text = e.KeyValue.ToString();
            txtKeyData.Text = e.KeyData.ToString();
            chkAlt.Checked = e.Alt;          // True, False
            chkControl.Checked = e.Control;
            chkShift.Checked = e.Shift;

        }
    }
}
