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
            //��toc���л�ȡ
            IFeatureLayer pLayer = axMapControl1.Map.get_Layer(0) as IFeatureLayer;
            IFeatureClass pFclass = pLayer.FeatureClass;
            int indexResult = pFclass.FindField("result");
            int indexX = pFclass.FindField("X");
            int indexY = pFclass.FindField("Y");

            //null������ȫ��
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
            MessageBox.Show("��ɸ�ֵ");
            
        }

        private void btn_addData_Click(object sender, EventArgs e)
        {
            //�������
            ICommand addData = new ControlsAddDataCommand();
            addData.OnCreate(axMapControl1.Object);
            addData.OnClick();
        }

        private void btn_addField_Click(object sender, EventArgs e)
        {
            //һά��������ֶ�
            ArrayList pList = new ArrayList();
            pList.Add("�ֶ�1");
            pList.Add("�ֶ�2");
            pList.Add("�ֶ�3");

            IFeatureLayer pLayer = axMapControl1.Map.get_Layer(0) as IFeatureLayer;
            IFeatureClass pfclass = pLayer.FeatureClass;
            
            foreach (string name in pList)
            {
                //�½����ֶ�
                IFieldEdit pEdit = new FieldClass();
                pEdit.Type_2 = esriFieldType.esriFieldTypeString;
                pEdit.Name_2 = name;
                pEdit.Length_2 = 20;
                IField fd = pEdit as IField;
                pfclass.AddField(fd);

            }
            MessageBox.Show("����ֶ����");
            

        }

        private void btn_traversal_Click(object sender, EventArgs e)
        {
            //����ͼ���ֶ�����
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
            //��������ʾ���µĴ���
            string path = @"C:\Users\czy\Desktop\XYTest\GeophySvyFaultPoint-��������̽��ϵ�-��.xls";
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
            string path = @"C:\Users\czy\Desktop\XYTest\GeophySvyFaultPoint-��������̽��ϵ�-��.xls";
            DataTable dt1 = ExcelTool.ReadExcelTool(path, "GeophySvyFaultPoint");
            DataTable dt = dt1.removeEmpty();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow dw = dt.Rows[i];
                string fdName = Convert.ToString(dw["�ֶ�����"]);
            }
        }

        private void btn_deleteField_Click(object sender, EventArgs e)
        {
            //��ȡ���ݣ��������
            string path = @"D:\�������Ŀ\20191029\20191029.gdb\Export_Output";
            string[] arrayPath = path.Split('\\');
            string GDBPath = arrayPath.GetGDBPath();
            string FileName = arrayPath.GetFeatureName();
            IFeatureClass pFclass = AddFeatureTool.GetFeatureClass(GDBPath, FileName);

            //�����ⲿ���������Ҳ�������ı���index�����֪��Ҫɾ�����ֶλ���
            IFields fds = pFclass.Fields;
            int startIndex = 0;
            int endIndex = fds.FieldCount;

            startIndex = 3;
            //���幦�ܣ�����
            AttributeEditTool.DeleteField(pFclass, startIndex, endIndex);

            MessageBox.Show("����ֶε�ɾ��");
        }

        private void btn_modifyAttribute_Click(object sender, EventArgs e)
        {
            IFeatureLayer myLayer = axMapControl1.Map.get_Layer(0) as IFeatureLayer;
            IFeatureClass pFeaclass = myLayer.FeatureClass;
            IFeatureCursor pCursor = pFeaclass.Search(null, false);
            IFeature fea = pCursor.NextFeature();

            //�ⲿ����
            string fieldName = "FieldID";
            int fieldIndex = pFeaclass.FindField(fieldName);

            while (fea != null)
            {
                //��ȡÿһ��featureÿһ�е�����ֵ
                string fieldValue = Convert.ToString(fea.get_Value(fieldIndex));

                string str = "test";
                //���ö�Ӧ���ֶ���һ���ƣ�����������
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
            //1�ǵ����
            if (e.button == 2 && item == esriTOCControlItem.esriTOCControlItemLayer)
            {
                popmenu.PopupMenu(e.x, e.y, axTOCControl1.hWnd);
            }
        }

        //�򿪳���ĳ�ʼ��
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
                //�����ⲿ����
                if (areaDouble < 1)
                {
                    //ɾ��feature
                    pfeature.Delete();
                }
                pfeature = pCursor.NextFeature();
            }
            axMapControl1.Refresh();
            MessageBox.Show("ɾ�����");
        }
    }
}