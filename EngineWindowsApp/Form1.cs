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
            ICommand addData = new ControlsAddDataCommand();
            addData.OnCreate(axMapControl1.Object);
            addData.OnClick();
        }
    }
}