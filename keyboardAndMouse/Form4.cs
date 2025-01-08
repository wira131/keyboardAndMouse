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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        private int x0, y0;
        private Pen p;
        private Graphics g;
        private void Form4_Load(object sender, EventArgs e)
        {
            cboColor.Items.AddRange(new string[] { "Red", "Green", "Blue" });
            cboWidth.Items.AddRange(new string[] { "2", "4", "6" });

            g = pictuerBox1.CreateGraphics();
            p = new Pen(Color.Red, 2);

            cboColor.SelectedIndex = 0;
            cboWidth.SelectedIndex = 0;

        }

        private void pictuerBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                x0 = e.X;
                y0 = e.Y;
            }
            else if (e.Button == MouseButtons.Right)
            {
                pictuerBox1.Refresh();
            }

        }

        private void pictuerBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                g.DrawLine(p, x0, y0, e.X, e.Y);
            }

            x0 = e.X;
            y0 = e.Y;

        }

        private void cboColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            p.Color = Color.FromName(cboColor.SelectedItem.ToString());

        }

        private void cboWidth_SelectedIndexChanged(object sender, EventArgs e)
        {
            p.Width = Convert.ToByte(cboWidth.SelectedItem);

        }
    }
}
