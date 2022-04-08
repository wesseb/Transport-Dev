namespace Transport_Dev
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            

            testColumns();
        }

        private void testColumns()
        {
            ListViewItem model = new ListViewItem();
            model.Text = "Ford";
            model.SubItems.Add("Focus");

            listView1.Columns.Add("Marka", -2, HorizontalAlignment.Left);
            listView1.Columns.Add("Model", -2, HorizontalAlignment.Left);

            listView1.Items.AddRange(new ListViewItem[] { model });
        }

        private void edytujDanePolaczeniaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }

        private void informacjeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.ShowDialog();
        }
    }
}