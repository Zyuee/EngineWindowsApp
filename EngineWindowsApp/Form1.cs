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

namespace EngineWindowsApp
{
    public partial class Form1 : Form
    {
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
            //����ͼ���ֶ�����
            IFeatureLayer pLayer = axMapControl1.Map.get_Layer(0) as IFeatureLayer;
            IFeatureClass pfeaclass = pLayer.FeatureClass;
            IFields fds = pfeaclass.Fields;
            for (int i = 0; i < fds.FieldCount; i++)
            {
                IField deletefd = fds.get_Field(i);
                //����2�Ժ�ȫ��ɾ��
                if (i > 2)
                {
                    pfeaclass.DeleteField(deletefd);
                }
                MessageBox.Show("����ֶε�ɾ��");
            }
        }
    }
}