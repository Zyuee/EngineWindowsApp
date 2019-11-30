using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ESRI.ArcGIS.ADF.BaseClasses;
using ESRI.ArcGIS.Controls;
using ESRI.ArcGIS.Carto;

namespace EngineWindowsApp
{
    class removeLayer : BaseCommand
    {
        private IMapControl4 pMapControl;
        public void remove()
        {
            //base是使用基类的属性
            base.m_caption = "以除图层";
        }
        public override void OnCreate(object hook)
        {
            pMapControl = hook as IMapControl4;

        }
        public override void OnClick()
        {
            //base.OnClick();
            ILayer pLayer = null;
            pLayer = pMapControl.CustomProperty as ILayer;
            pMapControl.Map.DeleteLayer(pLayer);
        }
    }
}
