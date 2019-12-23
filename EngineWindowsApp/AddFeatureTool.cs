
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ESRI.ArcGIS.Geodatabase;
using ESRI.ArcGIS.DataSourcesFile;
using ESRI.ArcGIS.Geometry;
using ESRI.ArcGIS.DataSourcesGDB;

namespace EngineWindowsApp
{
    class AddFeatureTool
    {
        //新建矢量要素
        public static IFeatureClass CreatePtTest(string filepath, string ptname)
        {
            //创建最后所需的点图层
            IFeatureClass feaclass = null;

            //创建工作空间
            IWorkspaceFactory pWorkspacefactory = new ShapefileWorkspaceFactoryClass();
            IWorkspace pWorkspace = pWorkspacefactory.OpenFromFile(filepath, 0);
            IFeatureWorkspace pFeaWorkspace = pWorkspace as IFeatureWorkspace;

            //IFields和IFieldsEdit同时用Fields实现，可以接口跳转
            //我们最后要的是IFieldsEdit
            //IFieldEdit提供了添加字段名称类型的方法
            IFields pFields = new FieldsClass();
            IFieldsEdit pFieldsEdit = pFields as IFieldsEdit;

            //确定一个shape字段，输入是需要添加shape的几何形状0
            IField pField = new FieldClass();
            IFieldEdit pFieldEdit = pField as IFieldEdit; 
            pFieldEdit.Name_2 = "shape";
            pFieldEdit.Type_2 = esriFieldType.esriFieldTypeGeometry;

            //对象几何类型的定义，pGeomtryDefEdit
            IGeometryDef pGeomtryDef = new GeometryDefClass();
            IGeometryDefEdit pGeomtryDefEdit = pGeomtryDef as IGeometryDefEdit;

            //将几何类型定义为点
            pGeomtryDefEdit.GeometryType_2 = esriGeometryType.esriGeometryPoint;

            ////也可以直接自定义输入的类型
            //esriGeometryType type = esriGeometryType.esriGeometryPoint;
            //pGeomtryDefEdit.GeometryType_2 = type;

            //坐标系统的创建，也是在IGeometryDef当时定义实现
            ISpatialReferenceFactory pSpatialReferenceFactory = new SpatialReferenceEnvironment();

            //esri自身能够支持的强制数据类型装换。
            IGeographicCoordinateSystem pGeographicCoordinateSystem = pSpatialReferenceFactory.CreateGeographicCoordinateSystem((int)esriSRGeoCSType.esriSRGeoCS_WGS1984);
            pGeomtryDefEdit.SpatialReference_2 = pGeographicCoordinateSystem as ISpatialReference;


            //将pGeomtryDef参数传回到属性字段pFieldEdit
            pFieldEdit.GeometryDef_2 = pGeomtryDef;

            pFieldsEdit.AddField(pField);

            feaclass = pFeaWorkspace.CreateFeatureClass(ptname, pFieldsEdit, null, null, esriFeatureType.esriFTSimple, "shape", "");

            return feaclass;
        }

        //直接获取现成的矢量要素数据
        public static IFeatureClass GetFeatureClass(string GDBpath, string FCname)
        {
            //创建最后所需的点图层
            IFeatureClass feaclass = null;

            //创建工作空间
            FileGDBWorkspaceFactory fileGDBWorkspaceFactory = new FileGDBWorkspaceFactory();
            IWorkspace workspace = fileGDBWorkspaceFactory.OpenFromFile(GDBpath, 0);
            IFeatureWorkspace featureWorkspace = workspace as IFeatureWorkspace;
            feaclass = featureWorkspace.OpenFeatureClass(FCname);

            return feaclass;
        }


    }
}
