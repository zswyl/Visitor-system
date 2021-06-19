using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
namespace mycontracts
{
    class VisitorinfoBLL
    {
        //创建访客文档
        private static string _basePath = AppDomain.CurrentDomain.SetupInformation.ApplicationBase + @"\xml\Visitors.xml";
        public static void CreateVisitorXml()
        {
            XDocument visitorDoc = new XDocument();
            XDeclaration xDeclaration = new XDeclaration("1.0", "utf-8", "yes");
            visitorDoc.Declaration = xDeclaration;
            XElement xElement = new XElement("visitorcontract");
            visitorDoc.Add(xElement);
            visitorDoc.Save(_basePath);
        }
        //增加访客信息
        public  static bool AddVisitorInfo(Visitorinfo param)
        {
            XElement xml = XElement.Load(_basePath);
            XmlDocument doc = new XmlDocument();
            doc.Load(_basePath);
            int visitorId = doc.SelectSingleNode("visitorcontract").ChildNodes.Count+1;
            XElement visitorXml = new XElement("visitor");
            visitorXml.Add(new XAttribute("visitorId", visitorId));
            visitorXml.Add(new XElement("name", param.Name));
            visitorXml.Add(new XElement("sex",param .Sex));
            visitorXml.Add(new XElement("phone", param.Phone));
            visitorXml.Add(new XElement("visitTime", param.VisitTime.ToString("G")));
            visitorXml.Add(new XElement("visitCase", param.VisitCase));
            visitorXml.Add(new XElement("leaveTime", param.LeaveTime.ToString("G")));
            xml.Add(visitorXml);
            xml.Save(_basePath);
            return true;
        }
        //修改访客信息
        public static bool UpdateVisitorInfo(Visitorinfo param)
        {
            bool result=false;
            if(param .VisitorId>0)
            {
                XElement xml=XElement .Load (_basePath);
                XElement visitorXml= (from db in xml.Descendants("visitor")
                                     where db.Attribute ("visitorId").Value ==param .VisitorId.ToString()
                                     select db).Single ();
                visitorXml.SetElementValue("name",param .Name);
                visitorXml.SetElementValue ("sex",param .Sex);
                visitorXml.SetElementValue("phone", param.Phone);
                visitorXml.SetElementValue("visitTime", param.VisitTime.ToString("G"));
                visitorXml.SetElementValue("visitCase", param.VisitCase);
                visitorXml.SetElementValue("leaveTime", param.LeaveTime.ToString("G"));
                xml.Save (_basePath);
                result =true;
            }
            return result;
        }
            //删除信息
        public static bool DeleteVisitorInfo(int visitorId)
        {
            bool result = false;
            if (visitorId > 0)
            {
                XElement xml = XElement.Load(_basePath);
                XElement visitorXml = (from db in xml.Descendants("visitor")
                                       where db.Attribute("visitorId").Value == visitorId.ToString()
                                       select db).Single();
                visitorXml.Remove();
                xml.Save(_basePath);
                result = true;
            }
            return result;
        }
        //查询全部
        public static List<Visitorinfo> getAllVisitorInfo()
        {
     
             List<Visitorinfo> visitorList = new List<Visitorinfo>();
             XElement xml = XElement.Load(_basePath);
             visitorList = (from visitor in xml.Descendants("visitor")
                            select new  Visitorinfo 
                                {
                                   VisitorId = Int32.Parse(visitor.Attribute("visitorId").Value),
                                   Name = visitor.Element("name").Value,
                                   Sex = visitor.Element("sex").Value,
                                   Phone = visitor.Element("phone").Value,
                                   VisitTime = DateTime.Parse(visitor.Element("visitTime").Value),
                                   VisitCase = visitor.Element("visitCase").Value,
                                   LeaveTime = DateTime.Parse(visitor.Element("leaveTime").Value)
                            }).ToList();  
            return visitorList;
        }
        //根据访客编号查询
        public static Visitorinfo getVisitorInfo(int visitorId)
        {
            Visitorinfo visitorInfo = new Visitorinfo();
            XElement xml = XElement.Load(_basePath);
            visitorInfo = (from visitor in xml.Descendants("visitor")
                           where visitor.Attribute("visitorId").Value == visitorId.ToString()
                           select new Visitorinfo
                           {
                               VisitorId = Int32.Parse(visitor.Attribute("visitorId").Value),
                               Name = visitor.Element("name").Value,     
                               Sex = visitor.Element("sex").Value,                             
                               Phone = visitor.Element("phone").Value,
                               VisitTime = DateTime.Parse(visitor.Element("visitTime").Value),
                               VisitCase = visitor.Element("visitCase").Value,
                               LeaveTime = DateTime.Parse(visitor.Element("leaveTime").Value)
                           }).Single();
            return visitorInfo;
        }
        //根据姓名查询
        public static Visitorinfo getVisitorInfo(string name)
        {
            Visitorinfo visitorInfo = new Visitorinfo();
            XElement xml = XElement.Load(_basePath);
            visitorInfo = (from visitor in xml.Descendants("visitor")
                           where visitor.Attribute("name").Value == name
                           select new Visitorinfo
                           {
                               VisitorId = Int32.Parse(visitor.Attribute("visitorId").Value),
                               Name = visitor.Element("name").Value,
                               Sex = visitor.Element("sex").Value,
                               Phone = visitor.Element("phone").Value,
                               VisitTime = DateTime.Parse(visitor.Element("visitTime").Value),
                               VisitCase = visitor.Element("visitCase").Value,
                               LeaveTime = DateTime.Parse(visitor.Element("leaveTime").Value)
                           }).Single();
            return visitorInfo;
        }
        //获取列表
        public static List<Visitorinfo> getVisitorInfoList(Visitorinfo param)
        {
            List<Visitorinfo> visitorList = new List<Visitorinfo>();
            XElement xml = XElement.Load(_basePath);
            var visitorVar = xml.Descendants("visitor");
            if (param.VisitorId != 0)
            {
                visitorVar = xml.Descendants("visitor").Where(a => a.Attribute("visitorId").Value
                    == param.VisitorId.ToString());
            }
            else if (!string.IsNullOrEmpty(param.Name))
            {
                visitorVar = xml.Descendants("visitor").Where(b => b.Element("name").Value
                    == param.Name);
            }
            visitorList = (from visitor in visitorVar
                           select new Visitorinfo
                               {
                               VisitorId = Int32.Parse(visitor.Attribute("visitorId").Value),
                               Name = visitor.Element("name").Value,
                               Sex = visitor.Element("sex").Value,
                               Phone = visitor.Element("phone").Value,
                               VisitTime = DateTime.Parse(visitor.Element("visitTime").Value),
                               VisitCase = visitor.Element("visitCase").Value,
                               LeaveTime = DateTime.Parse(visitor.Element("leaveTime").Value)
                           }).ToList();
            return visitorList;
        }
   }
}
