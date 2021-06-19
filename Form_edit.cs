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
    public partial class Form_edit : Form
    {
        public int visitorId_edit = 0;
        public Form_edit()
        {
            InitializeComponent();
            
        }
        public void initcontrol()
        {
            Visitorinfo visitorInfo = VisitorinfoBLL.getVisitorInfo(visitorId_edit);
            if (visitorInfo != null)
            {
                txt_visitorId.Text = visitorInfo.VisitorId.ToString();
                txt_name.Text = visitorInfo.Name;
                if (visitorInfo.Sex == "男")
                {
                    rb_man.Checked = true;
                    rb_woman.Checked = false;
                }
                else
                {
                    rb_woman.Checked = true;
                    rb_man.Checked = false;
                }
                dt_visitTime.Text = visitorInfo.VisitTime.ToString();
                txt_phone.Text = visitorInfo.Phone;
                txt_visitCase.Text = visitorInfo.VisitCase;
                dt_leaveTime.Text = visitorInfo.LeaveTime.ToString();
            }
         }
     

        private void btn_update_Click(object sender, EventArgs e)
        {
            Visitorinfo visitorInfo = VisitorinfoBLL.getVisitorInfo(visitorId_edit);
            visitorInfo.VisitorId = Int32.Parse(txt_visitorId.Text);
            visitorInfo.Name = txt_name.Text;
            if (rb_man.Checked)
                visitorInfo.Sex = "男";
            else if (rb_woman.Checked)
                visitorInfo.Sex = "女";
            visitorInfo.VisitTime = DateTime.Parse(dt_visitTime.Text);
            visitorInfo.Phone = txt_phone.Text;
            visitorInfo.VisitCase = txt_visitCase.Text;
            visitorInfo.LeaveTime = DateTime.Parse(dt_leaveTime.Text);
            if (VisitorinfoBLL.UpdateVisitorInfo(visitorInfo))
                MessageBox.Show("修改成功！");
        }

     
    }
    }

