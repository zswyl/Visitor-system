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
    public partial class Form_add : Form
    {
        public Form_add()
        {
            InitializeComponent();
        }

    

        private void btn_add_Click(object sender, EventArgs e)
        {
            Visitorinfo visitorInfo = new Visitorinfo();
            visitorInfo.Name = txt_name.Text;
            if (rb_man.Checked)
                visitorInfo.Sex = "男";
            else if (rb_woman.Checked)
                visitorInfo.Sex = "女";
            visitorInfo.VisitTime = DateTime.Parse(dt_visitTime.Text);
            visitorInfo.Phone = txt_phone.Text;
            visitorInfo.VisitCase = txt_visitCase.Text;
            visitorInfo.LeaveTime = DateTime.Parse(dt_leaveTime.Text);
            if (VisitorinfoBLL.AddVisitorInfo(visitorInfo))
            { MessageBox.Show("添加成功！"); }
        }

        private void bt_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
