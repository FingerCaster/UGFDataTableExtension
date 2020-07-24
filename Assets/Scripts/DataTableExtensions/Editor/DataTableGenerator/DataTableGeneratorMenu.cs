﻿﻿//------------------------------------------------------------
// Game Framework
// Copyright © 2013-2020 Jiang Yin. All rights reserved.
// Homepage: https://gameframework.cn/
// Feedback: mailto:ellan@gameframework.cn
//------------------------------------------------------------

 using System.IO;
 using System.Linq;
 using GameFramework;
using UnityEditor;
using UnityEngine;

namespace DE.Editor.DataTableTools
{
    public sealed class DataTableGeneratorMenu
    {
        private const string DataTablePath = "Assets/Res/DataTables";
        private static string[] DataTableNames;
        static DataTableGeneratorMenu()
        {
            DirectoryInfo folder = new DirectoryInfo(DataTablePath);
            DataTableNames = folder.GetFiles("*.txt").Select(file => Path.GetFileNameWithoutExtension(file.Name)).ToArray();
        }
        [MenuItem("DataTable/Generate DataTables")]
        private static void GenerateDataTables()
        {
            foreach (string dataTableName in DataTableNames)
            {
                DataTableProcessor dataTableProcessor = DataTableGenerator.CreateDataTableProcessor(dataTableName);
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
