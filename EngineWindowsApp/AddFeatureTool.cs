
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

            IFields pFields = new FieldsClass();
            IFieldsEdit pFieldsEdit = pFields as IFieldsEdit;

            //IFieldEdit提供了添加字段名称类型的方法
            IField pField = new FieldClass();
            IFieldEdit pFieldEdit = pField as IFieldEdit;
            pFieldEdit.Name_2 = "shape";
            pFieldEdit.Type_2 = esriFieldType.esriFieldTypeGeometry;

            //定义了矢量数据是点矢量
            IGeometryDef pGeomtryDef = new GeometryDefClass();
            IGeometryDefEdit pGeomtryDefEdit = pGeomtryDef as IGeometryDefEdit;
            pGeomtryDefEdit.GeometryType_2 = esriGeometryType.esriGeometryPoint;

            //坐标系统的创建
            ISpatialReferenceFactory pSpatialReferenceFactory = new SpatialReferenceEnvironment();

            //esri自身能够支持的强制数据类型装换。
            IGeographicCoordinateSystem pGeographicCoordinateSystem = pSpatialReferenceFactory.CreateGeographicCoordinateSystem((int)esriSRGeoCSType.esriSRGeoCS_WGS1984);
            pGeomtryDefEdit.SpatialReference_2 = pGeographicCoordinateSystem as ISpatialReference;


            //将坐标系参数传回到属性字段
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
