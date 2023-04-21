using System.Data;

namespace VisualProgrammingManik
{
    public partial class Form1 : Form
    {
        DataTable table;

        public Form1()
        {
            InitializeComponent();
        }

        private void Addbtn_Click(object sender, EventArgs e)
        {
            txttitle.Clear();
            txtmessage.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            table = new DataTable();
            table.Columns.Add("Title",typeof(String));
            table.Columns.Add("Messages", typeof(String));

            dataGridView1.DataSource = table;

            dataGridView1.Columns["Messages"].Visible = false;
            dataGridView1.Columns["Title"].Width = 178;

        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            table.Rows.Add(txttitle.Text, txtmessage.Text);

            txttitle.Clear();
            txtmessage.Clear();
        }

        private void ReadBtn_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentCell.RowIndex;

            if (index > -1)
            {
                txttitle.Text = table.Rows[index].ItemArray[0].ToString();
                txtmessage.Text = table.Rows[index].ItemArray[1].ToString();
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentCell.RowIndex;

            table.Rows[index].Delete();

        }
    }
}