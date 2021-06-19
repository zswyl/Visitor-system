using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mycontracts
{
    public partial class Form_search : Form
    {
        public Form_search()
        {
            InitializeComponent();
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



        private void btn_search_Click(object sender, EventArgs e)
        {
            if (cb_search.Text == string.Empty)
            {
                dataGridView1.DataSource = VisitorinfoBLL.getAllVisitorInfo();
                initheadtitle();
            }
            else
            {
                if (txt_searchtxt.Text != string.Empty)
                {
                    Visitorinfo visitorSearch = new Visitorinfo();
                    switch (cb_search.SelectedIndex)
                    {
                        case 0: visitorSearch.VisitorId = Int32.Parse(txt_searchtxt.Text); break;
                        case 1: visitorSearch.Name = txt_searchtxt.Text;
                          
                            break;
                    }
                    dataGridView1.DataSource = VisitorinfoBLL.getVisitorInfoList(visitorSearch);
                    initheadtitle();
                }
                else MessageBox.Show("请输入要查询的" + cb_search.Text);
            }
        }

        private void bt_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
