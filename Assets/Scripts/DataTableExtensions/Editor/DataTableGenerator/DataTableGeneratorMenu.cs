

using GameFramework;
using UnityEditor;
using UnityEngine;
using UGFDataTableProcessor =  UnityGameFramework.Editor.DataTableTools.DataTableProcessor;

namespace DE.Editor
{
    public sealed class DataTableGeneratorMenu
    {
        private static string[] DataTableNames = new []
        {
            "Test"
        };
        [MenuItem("DataTable/Generate DataTables")]
        private static void GenerateDataTables()
        {
            foreach (string dataTableName in DataTableNames)
            {
                UGFDataTableProcessor dataTableProcessor = DataTableGenerator.CreateDataTableProcessor(dataTableName);
                if (!DataTableGenerator.CheckRawData(dataTableProcessor, dataTableName))
                {
                    Debug.LogError(Utility.Text.Format("Check raw data failure. DataTableName='{0}'", dataTableName));
                    break;
                }

                DataTableGenerator.GenerateDataFile(dataTableProcessor, dataTableName);
                DataTableGenerator.GenerateCodeFile(dataTableProcessor, dataTableName);
            }
            AssetDatabase.Refresh();
        }
    }
}
