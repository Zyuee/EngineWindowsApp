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
        public  removeLayer()
        {
            //base是使用基类的属性
            base.m_caption = "移除图层";
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
            //IMapControl4当中的delete需要索引号，IMap里面的delete不需要索引号
            //所以用IMap实现的map进行delete，
            pMapControl.Map.DeleteLayer(pLayer);
        }
    }
}
