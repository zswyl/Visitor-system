using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mycontracts
{
    class Visitorinfo
    {
        public int VisitorId { set; get; }//ID
        public string Name { set; get; }//姓名
        public string Sex { set; get; }//性别
        public string Phone { set; get; }//手机号码
        public DateTime VisitTime { set; get; }//来访时间
        public string VisitCase { set; get; }//来访原因
        public DateTime LeaveTime { set; get; }//离开时间
     
    }
}
