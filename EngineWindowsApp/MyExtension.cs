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
    }
}
