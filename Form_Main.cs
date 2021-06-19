using System;
using System.Windows.Forms;

namespace mycontracts
{
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();
            initcontracts();

        }
        void initheadtitle()
        {
            dataGridView1.Columns[0].HeaderText = "访客编号";
            dataGridView1.Columns[1].HeaderText = "访客姓名";
            dataGridView1.Columns[2].HeaderText = "访客性别";
            dataGridView1.Columns[3].HeaderText = "手机号码";
            dataGridView1.Columns[4].HeaderText = "来访时间";
            dataGridView1.Columns[5].HeaderText = "来访原因";
            dataGridView1.Columns[6].HeaderText = "离开时间";

        }
        void initcontracts()
        {

            if (System.IO.File.Exists(AppDomain.CurrentDomain.SetupInformation.ApplicationBase + @"\xml\Visitors.xml"))
            {

                dataGridView1.DataSource = VisitorinfoBLL.getAllVisitorInfo();
                initheadtitle();
            }
            else
            {
                VisitorinfoBLL.CreateVisitorXml();
                dataGridView1.DataSource = VisitorinfoBLL.getAllVisitorInfo();
                initheadtitle();
            }
        }
     

        private void add_Click(object sender, EventArgs e)
        {
            Form_add formadd = new Form_add();
            formadd.ShowDialog();
            initcontracts();

        }

        private void search_Click(object sender, EventArgs e)
        {
            Form_search formsearch = new Form_search();
            formsearch.ShowDialog();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                if (MessageBox.Show("确定要删除此访客的信息？", "确认信息", MessageBoxButtons.YesNo, MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    int selectrow = Int32.Parse(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0]
                        .Value.ToString());
                    if (VisitorinfoBLL.DeleteVisitorInfo(selectrow))
                        MessageBox.Show("删除成功！");
                    else
                        MessageBox.Show("删除失败，请检查是否选中访客信息！");
                    initcontracts();
                }
            }
            else
                MessageBox.Show("请选中后再点击删除按钮");
        }

        private void edit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                int selectrow = Int32.Parse(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex]
                    .Cells[0].Value.ToString());
                Form_edit formedit = new Form_edit();
                formedit.visitorId_edit = selectrow;
                formedit.ShowDialog();
                initcontracts();
            }
            else
                MessageBox.Show("请选中一行后再点击编辑按钮！");
        }

  
    }
}
