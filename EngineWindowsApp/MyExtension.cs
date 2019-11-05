using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace EngineWindowsApp
{
    //扩展方法必须在非泛型静态类中定义
    public static class MyExtension
    {
        //去除datatable的空格
        public static DataTable removeEmpty(this DataTable dt)
        {
            List<DataRow> removelist = new List<DataRow>();

            for (int i = 0; i < dt.Rows.Count; i++)

            {
                bool rowdataisnull = true;
                for (int j = 0; j < dt.Columns.Count; j++)

                {
                    if (!string.IsNullOrEmpty(dt.Rows[i][j].ToString().Trim()))

                    {
                        rowdataisnull = false;
                    }
                }

                if (rowdataisnull)
                {
                    removelist.Add(dt.Rows[i]);
                }
            }

            for (int i = 0; i < removelist.Count; i++)
            {
                dt.Rows.Remove(removelist[i]);
            }
            return dt;
        }
        //获取要素集最后一个“\”之前的路径
        public static string GetGDBPath(this string[] str)
        {
            string GDBname = "";
            string FCname = "";
            for (int i = 0; i < str.Length; i++)
            {
                if (i < str.Length - 1)
                {
                    if (i < str.Length - 2)
                        GDBname = GDBname + str[i] + "\\";
                    else
                        GDBname = GDBname + str[i];
                }
                else
                {
                    FCname = str[i];
                }
            }
            return GDBname;
        }
        //获取要素集最后一个“\”之后的路径
        public static string GetFeatureName(this string[] str)
        {
            string GDBname = "";
            string FCname = "";
            for (int i = 0; i < str.Length; i++)
            {
                if (i < str.Length - 1)
                {
                    if (i < str.Length - 2)
                        GDBname = GDBname + str[i] + "\\";
                    else
                        GDBname = GDBname + str[i];
                }
                else
                {
                    FCname = str[i];
                }
            }
            return FCname;
        }
    }
}
