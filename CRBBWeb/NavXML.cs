using CRBBWeb.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace CRBBWeb
{
    public class NavXML
    {
        private static string _XmlPath = "NavSetting.xml";
        public static List<NavItemViewModel> GetXMLNodes()
        {
            XmlDocument xml = new XmlDocument();
            xml.Load(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, _XmlPath));
            var element = xml.DocumentElement;
            var xmlNodes = element.SelectNodes(@"/Nav/NavItems/NavItem");
            List<NavItemViewModel> list = new List<NavItemViewModel>();
            foreach (XmlNode xn in xmlNodes)
            {
                bool isSelected = bool.Parse(xn.ChildNodes.Item(3).InnerText);
                NavItemViewModel ni = new NavItemViewModel();
                ni.ID = int.Parse(xn.ChildNodes.Item(0).InnerText);
                ni.Name = xn.ChildNodes.Item(1).InnerText;
                ni.Fixed = bool.Parse(xn.ChildNodes.Item(2).InnerText);
                ni.IsSelected = isSelected;
                ni.Url = xn.ChildNodes.Item(4).InnerText;
                ni.Active = bool.Parse(xn.ChildNodes.Item(6).InnerText);
                ni.ImgUrl = xn.ChildNodes.Item(5).InnerText;
                list.Add(ni);
            }
            return list;
        }

        public static List<NavItemViewModel> GetSelectedXMLNodes()
        {
            XmlDocument xml = new XmlDocument();
            xml.Load(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, _XmlPath));
            var element = xml.DocumentElement;
            var xmlNodes = element.SelectNodes(@"/Nav/NavItems/NavItem");
            List<NavItemViewModel> list = new List<NavItemViewModel>();
            foreach (XmlNode xn in xmlNodes)
            {
                bool isSelected = bool.Parse(xn.ChildNodes.Item(3).InnerText);
                if (!isSelected)
                {
                    continue;
                }
                NavItemViewModel ni = new NavItemViewModel();
                ni.ID = int.Parse(xn.ChildNodes.Item(0).InnerText);
                ni.Name = xn.ChildNodes.Item(1).InnerText;
                ni.Fixed = bool.Parse(xn.ChildNodes.Item(2).InnerText);
                ni.IsSelected = isSelected;
                ni.Url = xn.ChildNodes.Item(4).InnerText;
                ni.Active = bool.Parse(xn.ChildNodes.Item(6).InnerText);
                ni.ImgUrl = xn.ChildNodes.Item(5).InnerText;
                list.Add(ni);
            }
            return list;
        }

        public static bool WriteXmlNode(List<NavItemViewModel> niList)
        {
            XmlDocument xml = new XmlDocument();
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, _XmlPath);
            xml.Load(filePath);
            var element = xml.DocumentElement;
            var xmlNodes = element.SelectNodes(@"/Nav/NavItems/NavItem");
            foreach (XmlNode xn in xmlNodes)
            {
                NavItemViewModel ni = niList.Where(m => m.ID == int.Parse(xn.ChildNodes.Item(0).InnerText)).FirstOrDefault();
                if (ni == null)
                {
                    continue;
                }
                //xn.ChildNodes.Item(1).InnerText = ni.Name;
                xn.ChildNodes.Item(2).InnerText = ni.Fixed.ToString();
                xn.ChildNodes.Item(3).InnerText = ni.IsSelected.ToString();
                xn.ChildNodes.Item(4).InnerText = ni.Url;
                xn.ChildNodes.Item(6).InnerText = ni.Active.ToString();
            }
            xml.Save(filePath);
            return true;
        }
    }
}