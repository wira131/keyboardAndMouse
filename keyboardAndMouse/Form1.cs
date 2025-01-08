namespace keyboardAndMouse
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] product = { "นกแก้ว", "แมว", "สุนัข", "คางคาว", "ช้าง", "สิงโต" };
            listBox1.Items.AddRange(product);
        }

        private void listBox1_MouseDown(object sender, MouseEventArgs e)
        {//ต้นทาง
            int idx = listBox1.SelectedIndex;
            listBox1.DoDragDrop(listBox1.Items[idx], DragDropEffects.Copy);

        }

        private void listBox2_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void listBox2_DragDrop(object sender, DragEventArgs e)
        {
            string data = e.Data.GetData(DataFormats.Text).ToString();
            if (listBox2.FindStringExact(data) == -1)
            {
                listBox2.Items.Add(data);
            }

        }
    }
}
