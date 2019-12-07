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
            IFields fds = feaClass.Fields;
            for (int i = 0;  i < fds.FieldCount; i++)
            {
                string fdName = fds.get_Field(i).Name;
                dt.Columns.Add(fdName);

            }
                while (pfea != null)
            {


                pfea = pCursor.NextFeature();
            }
        }
    }
}
