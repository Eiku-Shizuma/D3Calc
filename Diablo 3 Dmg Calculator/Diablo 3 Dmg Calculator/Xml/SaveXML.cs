using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Diablo_3_Dmg_Calculator.Models;
using System.IO;
using System.Xml;
using System.Linq.Expressions;

namespace Diablo_3_Dmg_Calculator.Xml
{
    public static class SaveXML
    {
        private static string path;
        private static Charactermodel model;
        private static bool result;

        public static void SaveChcaracter(string par_path, Charactermodel par_model){
            path = par_path;
            model = par_model;

            if (File.Exists(path))
            {
                result = SaveXmlOverwrite();
            }
            else
            {
                result = SaveXmlToPath();
            }
        }

        private static bool SaveXmlToPath()
        {
            XmlDocument doc = new XmlDocument();
            XmlNode root, childroot, childgearroot,childroot2, child;

            root = doc.CreateElement("root");
            doc.AppendChild(root);

            childroot = doc.CreateElement("characterinfo");
            root.AppendChild(childroot);

            childroot2 = doc.CreateElement("charactergear");
            root.AppendChild(childroot2);


            foreach (var stats in model.GetType().GetProperties())
            {
                if (Object.ReferenceEquals(stats.GetType(), model.Helm.GetType()) != true)
                {
                    child = doc.CreateElement(Check(() => stats));
                    child.Value = stats.GetType().GetField(Check(() => stats)).GetValue(stats).ToString();
                    childroot.AppendChild(child);
                }
                else
                {
                    childgearroot = doc.CreateElement(Check(() => stats));
                    childroot2.AppendChild(childgearroot);

                    foreach (var item in stats.GetType().GetProperties())
                    {
                        if (item.GetType().GetField(Check(() => item)).GetValue(item) != null)
                        {
                            child = doc.CreateElement(Check(() => item));
                            childgearroot.AppendChild(child);
                        }
                    }
                }
            }

            doc.Save(path);
            return true;

        }

        private static bool SaveXmlOverwrite()
        {

            return true;
        }

        private static string Check<T>(Expression<Func<T>> expr)
        {
            var body = ((MemberExpression)expr.Body);
            string name = body.Member.Name;
            return name;
        }

    }
}
