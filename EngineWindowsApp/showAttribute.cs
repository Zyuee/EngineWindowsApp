using ESRI.ArcGIS.ADF.BaseClasses;
using ESRI.ArcGIS.Carto;
using ESRI.ArcGIS.Controls;
using ESRI.ArcGIS.Geodatabase;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EngineWindowsApp
{
    class showAttribute : BaseCommand
    {
        private IMapControl4 pMapControl;
        public showAttribute()
        {
            base.m_caption = "显示属性表";
        }

        public override void OnCreate(object hook)
        {
            pMapControl = hook as IMapControl4;
        }

        public override void OnClick()
        {
            ILayer pLayer = null;
            pLayer = pMapControl.CustomProperty as ILayer;
            IFeatureLayer pflayer = pLayer as IFeatureLayer;
            IFeatureClass feaClass = pflayer.FeatureClass;
            IFeatureCursor pCursor = feaClass.Search(null, false);
            IFeature pfea = pCursor.NextFeature();

            DataTable dt = new DataTable();
            //先添加列名
            IFields fds = feaClass.Fields;
            for (int i = 0;  i < fds.FieldCount; i++)
            {
                string fdName = fds.get_Field(i).Name;
                dt.Columns.Add(fdName);
            }

            //表赋值
            string fdValue = "";
                while (pfea != null)
            {
                DataRow dr = dt.NewRow();
                for (int j = 0; j < fds.FieldCount; j++)
                {

                    //能够保留原始的数据type？
                    //fdValue = Convert.ToString(pfea.get_Value(j));
                    //polygon等shape字段没法获取值
                    
                    string fdName = Convert.ToString(fds.get_Field(j).Name);
                    if (fdName == "Shape")
                    {
                        var fdv = pfea.ShapeCopy.GeometryType;
                        //MessageBox.Show(Convert.ToString(fdv));
                        dr[j] = fdv;
                    }
                    else
                    {
                        var fdv = pfea.get_Value(j);
                        //MessageBox.Show(Convert.ToString(fdv));
                        dr[j] = fdv;
                    }
                    
                    
                }

                dt.Rows.Add(dr);

                pfea = pCursor.NextFeature();
            }
            var frm = new AttrTable();
            frm.setValue(dt);
            frm.ShowDialog();
            //MessageBox.Show("显示属性表");
        }



    }
}
