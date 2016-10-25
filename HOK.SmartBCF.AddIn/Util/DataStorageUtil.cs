using Autodesk.Revit.DB;
using Autodesk.Revit.DB.ExtensibleStorage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HOK.SmartBCF.AddIn.Util
{
    /// <summary>
    /// Methods for extensible Storage in Revit projects
    /// </summary>
    public static class DataStorageUtil
    {
        public static Guid settingSchemaId = new Guid("62822B99-C436-44CD-AC63-4F1A2C420C85");
        public static Schema settingSchema = Schema.Lookup(settingSchemaId);

        private static string s_linkedDBName = "LinkedDBName";

        /// <summary>
        /// Read linked database from the data storage
        /// </summary>
        /// <param name="doc"></param>
        /// <returns></returns>
        public static string ReadLinkedDatabase(Document doc)
        {
            string databaseName = "";
            try
            {
                if (null == settingSchema)
                {
                    settingSchema = CreateSettingSchema();
                }

                if (null != settingSchema)
                {
                    IList<DataStorage> savedStorage = GetDataStorage(doc, settingSchema);
                    if (savedStorage.Count > 0)
                    {
                        DataStorage storage = savedStorage.First();
                        Entity entity = storage.GetEntity(settingSchema);
                        databaseName = entity.Get<string>(settingSchema.GetField(s_linkedDBName));
                    }
                }
            }
            catch (Exception ex)
            {
                string message = ex.Message;
            }
            return databaseName;
        }

        /// <summary>
        /// Update the linked database
        /// </summary>
        /// <param name="doc"></param>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public static bool UpdateLinkedDatabase(Document doc, string fileName)
        {
            bool updated = false;
            try
            {
                if (null == settingSchema)
                {
                    settingSchema = CreateSettingSchema();
                }

                if (null != settingSchema)
                {
                    IList<DataStorage> savedStorage = GetDataStorage(doc, settingSchema);
                    if (savedStorage.Count > 0)
                    {
                        foreach (DataStorage ds in savedStorage)
                        {
                            doc.Delete(ds.Id);
                        }
                    }

                    DataStorage storage = DataStorage.Create(doc);
                    Entity entity = new Entity(settingSchemaId);
                    entity.Set<string>(s_linkedDBName, fileName);

                    storage.SetEntity(entity);
                    updated = true;
                }
                
            }
            catch (Exception ex)
            {
                string message = ex.Message;
            }
            return updated;
        }
    

        /// <summary>
        /// Create the setting schema
        /// </summary>
        /// <returns></returns>
        public static Schema CreateSettingSchema()
        {
            Schema schema = null;
            try
            {
                SchemaBuilder schemaBuilder = new SchemaBuilder(settingSchemaId);
                schemaBuilder.SetSchemaName("LinkedBCFDatabase");
                schemaBuilder.AddSimpleField(s_linkedDBName, typeof(string));
                schema = schemaBuilder.Finish();
            }
            catch (Exception ex)
            {
                string message = ex.Message;
            }
            return schema;
        }

        /// <summary>
        /// Get data storage of interest
        /// </summary>
        /// <param name="doc"></param>
        /// <param name="schema"></param>
        /// <returns></returns>
        private static IList<DataStorage> GetDataStorage(Document doc, Schema schema)
        {
            FilteredElementCollector collector = new FilteredElementCollector(doc);
            collector.OfClass(typeof(DataStorage));
            Func<DataStorage, bool> hasTargetData = ds => (ds.GetEntity(schema) != null && ds.GetEntity(schema).IsValid());

            return collector.Cast<DataStorage>().Where<DataStorage>(hasTargetData).ToList<DataStorage>();
        }
    }
}
