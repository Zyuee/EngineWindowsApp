using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ESRI.ArcGIS.SystemUI;
using ESRI.ArcGIS.Controls;
using ESRI.ArcGIS.Carto;
using ESRI.ArcGIS.Geodatabase;
using System.Collections;
using ESRI.ArcGIS.Geometry;

namespace EngineWindowsApp
{
    public partial class Form1 : Form
    {
        private IToolbarMenu2 popmenu;
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_calField_Click(object sender, EventArgs e)
        {
            //从toc当中获取
            IFeatureLayer pLayer = axMapControl1.Map.get_Layer(0) as IFeatureLayer;
            IFeatureClass pFclass = pLayer.FeatureClass;
            int indexResult = pFclass.FindField("result");
            int indexX = pFclass.FindField("X");
            int indexY = pFclass.FindField("Y");

            //null则搜索全部
            IFeatureCursor pCursor = pFclass.Search(null, false);
            IFeature pFeature = pCursor.NextFeature();
            double re = 0;
            while (pFeature != null)
            {
                double X = Convert.ToDouble(pFeature.get_Value(indexX));
                double Y = Convert.ToDouble(pFeature.get_Value(indexY));
                re = X + Y;
                pFeature.set_Value(indexResult, Convert.ToDouble(re));
                pFeature.Store();
                pFeature = pCursor.NextFeature();

            }
            MessageBox.Show("完成赋值");
            
        }

        private void btn_addData_Click(object sender, EventArgs e)
        {
            //添加数据
            ICommand addData = new ControlsAddDataCommand();
            addData.OnCreate(axMapControl1.Object);
            addData.OnClick();
        }

        private void btn_addField_Click(object sender, EventArgs e)
        {
            //一维数组添加字段
            ArrayList pList = new ArrayList();
            pList.Add("字段1");
            pList.Add("字段2");
            pList.Add("字段3");

            IFeatureLayer pLayer = axMapControl1.Map.get_Layer(0) as IFeatureLayer;
            IFeatureClass pfclass = pLayer.FeatureClass;
            
            foreach (string name in pList)
            {
                //新建空字段
                IFieldEdit pEdit = new FieldClass();
                pEdit.Type_2 = esriFieldType.esriFieldTypeString;
                pEdit.Name_2 = name;
                pEdit.Length_2 = 20;
                IField fd = pEdit as IField;
                pfclass.AddField(fd);

            }
            MessageBox.Show("完成字段添加");
            

        }

        private void btn_traversal_Click(object sender, EventArgs e)
        {
            //遍历图层字段名称
            IFeatureLayer pLayer = axMapControl1.Map.get_Layer(0) as IFeatureLayer;
            IFeatureClass pfeaclass = pLayer.FeatureClass;
            IFields pfields = pfeaclass.Fields;

            for (int i = 0; i < pfields.FieldCount; i++)
            {
                IField pfd = pfields.get_Field(i);
                MessageBox.Show(pfd.Name);
            }

        }

        private void btn_table_Click(object sender, EventArgs e)
        {
            //把属性显示到新的窗口
            string path = @"C:\Users\czy\Desktop\XYTest\GeophySvyFaultPoint-地球物理探测断点-点.xls";
            DataTable dt1 = ExcelTool.ReadExcelTool(path, "GeophySvyFaultPoint");
            DataTable dt = dt1.removeEmpty();
            var frm = new table();
            frm.setValue(dt);
            frm.ShowDialog();
        }

        private void btn_addXYdata_Click(object sender, EventArgs e)
        {

        }

        private void btn_addAttribute_Click(object sender, EventArgs e)
        {
            string path = @"C:\Users\czy\Desktop\XYTest\GeophySvyFaultPoint-地球物理探测断点-点.xls";
            DataTable dt1 = ExcelTool.ReadExcelTool(path, "GeophySvyFaultPoint");
            DataTable dt = dt1.removeEmpty();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow dw = dt.Rows[i];
                string fdName = Convert.ToString(dw["字段类型"]);
            }
        }

        private void btn_deleteField_Click(object sender, EventArgs e)
        {
            //获取数据，可以外接
            string path = @"D:\地震局项目\20191029\20191029.gdb\Export_Output";
            string[] arrayPath = path.Split('\\');
            string GDBPath = arrayPath.GetGDBPath();
            string FileName = arrayPath.GetFeatureName();
            IFeatureClass pFclass = AddFeatureTool.GetFeatureClass(GDBPath, FileName);

            //可以外部输入参数，也可以用文本找index（如果知道要删除的字段话）
            IFields fds = pFclass.Fields;
            int startIndex = 0;
            int endIndex = fds.FieldCount;

            startIndex = 3;
            //主体功能，重载
            AttributeEditTool.DeleteField(pFclass, startIndex, endIndex);

            MessageBox.Show("完成字段的删除");
        }

        private void btn_modifyAttribute_Click(object sender, EventArgs e)
        {
            IFeatureLayer myLayer = axMapControl1.Map.get_Layer(0) as IFeatureLayer;
            IFeatureClass pFeaclass = myLayer.FeatureClass;
            IFeatureCursor pCursor = pFeaclass.Search(null, false);
            IFeature fea = pCursor.NextFeature();

            //外部控制
            string fieldName = "FieldID";
            int fieldIndex = pFeaclass.FindField(fieldName);

            while (fea != null)
            {
                //获取每一个feature每一行的属性值
                string fieldValue = Convert.ToString(fea.get_Value(fieldIndex));

                string str = "test";
                //给该对应的字段逐一复制，或其他操作
                fea.set_Value(fieldIndex, Convert.ToString(str));                

                fea = pCursor.NextFeature(); ;
            }
        }

        private void axTOCControl1_OnMouseDown(object sender, ITOCControlEvents_OnMouseDownEvent e)
        {
            esriTOCControlItem item = esriTOCControlItem.esriTOCControlItemNone;
            IBasicMap pMap = null;
            ILayer lyr = null;
            object other = null;
            object index = null;
            axTOCControl1.HitTest(e.x, e.y, ref item, ref pMap, ref lyr, ref other, ref index);
            axMapControl1.CustomProperty = lyr;
            //1是点左键
            if (e.button == 2 && item == esriTOCControlItem.esriTOCControlItemLayer)
            {
                popmenu.PopupMenu(e.x, e.y, axTOCControl1.hWnd);
            }
        }

        //打开程序的初始化
        private void Form1_Load(object sender, EventArgs e)
        {
           
            popmenu = new ToolbarMenuClass();
            popmenu.AddItem(new removeLayer(), 0, 0, false, esriCommandStyles.esriCommandStyleTextOnly);
            popmenu.SetHook(axMapControl1.Object);
        }

        private void btn_DeleteFeature_Click(object sender, EventArgs e)
        {
            IFeatureLayer myLayer = axMapControl1.Map.get_Layer(0) as IFeatureLayer;
            IFeatureClass feaClass = myLayer.FeatureClass;

            IFeatureCursor pCursor = feaClass.Search(null, false);
            IFeature pfeature = pCursor.NextFeature();
            while (pfeature != null)
            {
                IGeometry geo = pfeature.ShapeCopy;
                IArea area = geo as IArea;
                double areaDouble = area.Area;
                //MessageBox.Show(areaDouble.ToString());
                //条件外部输入
                if (areaDouble < 1)
                {
                    //删除feature
                    pfeature.Delete();
                }
                pfeature = pCursor.NextFeature();
            }
            axMapControl1.Refresh();
            MessageBox.Show("删除完成");
        }
    }
}