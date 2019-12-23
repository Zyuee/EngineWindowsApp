using ESRI.ArcGIS.Geodatabase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EngineWindowsApp
{
    public partial class FormExcel2Pt : Form
    {
        private DataTable dt;
        public FormExcel2Pt()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_createPt_Click(object sender, EventArgs e)
        {
            //获取矢量路径
            string featureBox = FeatureBox.Text;
            string[] featureBoxArr = featureBox.Split('\\');
            string filepath = featureBoxArr.GetGDBPath();
            string ptname = featureBoxArr.GetFeatureName();
            //创建新的矢量数据
            IFeatureClass pFeatureClass = AddFeatureTool.CreatePtTest(filepath, ptname);

            //获取excel路径            
            string excelPath = ExcelBox.Text;
            string sheetName = "sheet1";
            //获取excel表格
            DataTable excelDt = ExcelTool.ReadExcelTool(excelPath, sheetName);
            dt = excelDt.removeEmpty();

            //填写表头
            AttributeEditTool.CreateAttrTable(dt, pFeatureClass);
            MessageBox.Show("创建表头完成");

            //填写属性表

        }

        private void btn_browserExcel_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Excel 97-2003 |*.xls";
            openFileDialog1.Title = "Excel";
            openFileDialog1.InitialDirectory = Application.StartupPath;
            openFileDialog1.ShowDialog();
            if (openFileDialog1.FileName != "")
            {
                ExcelBox.Text = openFileDialog1.FileName;
            }
        }

        private void btn_browserFeature_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = " File Geodatabase(*.gdb) | *.gdb | All Files(*.*) | *.* ";
            openFileDialog1.Title = "打开Geodatabase文件";
            openFileDialog1.InitialDirectory = Application.StartupPath;
            openFileDialog1.ShowDialog();
            if (openFileDialog1.FileName != "")
            {
                FeatureBox.Text = openFileDialog1.FileName;
            }
        }
    }
}
