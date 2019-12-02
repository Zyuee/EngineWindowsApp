using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ESRI.ArcGIS.Geodatabase;
using ESRI.ArcGIS.Carto;

namespace EngineWindowsApp
{
    class AttributeEditTool
    {
        public static void DeleteField(IFeatureClass pfeaclass, int n1, int n2)
        {
            //删除索引范围
            
            IFields fds = pfeaclass.Fields;
            List <IField> deletefds = new List<IField>();
            for (int i = 0; i < fds.FieldCount; i++)
            {
                IField pFd = fds.get_Field(i);
                //包含头尾
                if (i >= n1 && i <= n2) 
                {
                    deletefds.Add(pFd);
                }
            }
            foreach (IField deletefd in deletefds)
            {
                pfeaclass.DeleteField(deletefd);
            }
        }

        public static void DeleteField(IFeatureClass pfeaclass, string fieldName)
        {
            //重载删除指定字段
            int deleteIndex = pfeaclass.FindField(fieldName);
            IFields fds = pfeaclass.Fields;
            IField deletefield = fds.get_Field(deleteIndex);
            pfeaclass.DeleteField(deletefield);

        }

    }
}
