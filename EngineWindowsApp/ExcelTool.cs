using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EngineWindowsApp
{
    class ExcelTool
    {
        //如何从属性表中读取excel返回到datatable
        public static DataTable ReadExcelTool(string dbpath, string SheetName)
        {
            //打开excel,
            //string dbpath = path;
            string constr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + dbpath + ";Extended Properties='Excel 8.0;HDR=Yes;IMEX=1;'";
            //HDR = Yes表头不作为行数，即不为第一行

            OleDbConnection oledbecon = new OleDbConnection(constr);

            #region
            //打开连接
            oledbecon.Open();

            //存到临时内存datatable
            DataSet ds = new DataSet();

            //外部传入SheetName
            //string select = "SELECT * FROM[Sheet1$]";
            string select = "SELECT * FROM[" + SheetName + "$]";
            
            OleDbDataAdapter adpt = new OleDbDataAdapter(select, oledbecon);

            adpt.Fill(ds, "xd");
            DataTable dt = ds.Tables["xd"];
            
            //关闭连接
            oledbecon.Close();
            #endregion

            return dt;
        }

        //消除空行
        public static DataTable moveEmpty(DataTable dt)
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
