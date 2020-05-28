using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;
using UnityEditor;
using UnityEngine;
using Debug = UnityEngine.Debug;

namespace DE.Editor
{
    public static class DataProcessorTools
    {
        private static readonly string DataProcessorUtilityCodePath = String.Empty;
        private static readonly string t = String.Empty;

        static DataProcessorTools()
        {
            FileInformation dataProcessorUtility = DirectoryAllFiles
                .GetAllFiles(new DirectoryInfo(Application.dataPath)).Find(information =>
                    information.FileName == "DataTableProcessor.DataProcessorUtility.cs");
            DataProcessorUtilityCodePath = dataProcessorUtility.FilePath;
        }

        [MenuItem("DatableTools/CommentGetDataProcessorException")]
        static void CommentGetDataProcessorException()
        {
            if (File.Exists(DataProcessorUtilityCodePath))
            {
                string info = File.ReadAllText(DataProcessorUtilityCodePath);
                if (info.IndexOf(
                        "//throw new GameFrameworkException(Utility.Text.Format(\"Not supported data processor type '{0}'.\", type));",
                        StringComparison.Ordinal) != -1)
                {
                    return;
                }

                info = info.Replace(
                    "throw new GameFrameworkException(Utility.Text.Format(\"Not supported data processor type '{0}'.\", type));",
                    "//throw new GameFrameworkException(Utility.Text.Format(\"Not supported data processor type '{0}'.\", type));\n\t\t\t\treturn null;\n");

                using (FileStream fileStream = new FileStream(DataProcessorUtilityCodePath, FileMode.Open))
                {
                    using (StreamWriter stream = new StreamWriter(fileStream, Encoding.UTF8))
                    {
                        stream.Write(info);
                    }
                }

                AssetDatabase.Refresh();
            }
            else
            {
                EditorUtility.DisplayDialog("",
                    "项目中不存在 DataTableProcessor.DataProcessorUtility.cs文件  请检查是否已经导入UnityGameFramework 框架。", "确定");
            }
        }
        [MenuItem("DatableTools/CancelCommentGetDataProcessorException")]
        static void CancelCommentGetDataProcessorException()
        {
            if (File.Exists(DataProcessorUtilityCodePath))
            {
                string info = File.ReadAllText(DataProcessorUtilityCodePath);
                string comment =
                    "//throw new GameFrameworkException(Utility.Text.Format(\"Not supported data processor type '{0}'.\", type));";
                if (info.IndexOf(comment, StringComparison.Ordinal) != -1)
                {
                    info = info.Replace(comment, "throw new GameFrameworkException(Utility.Text.Format(\"Not supported data processor type '{0}'.\", type));");
                }
                using (FileStream fileStream = new FileStream(DataProcessorUtilityCodePath, FileMode.Open))
                {
                    using (StreamWriter stream = new StreamWriter(fileStream, Encoding.UTF8))
                    {
                        stream.Write(info);
                    }
                }

                AssetDatabase.Refresh();
            }
            else
            {
                EditorUtility.DisplayDialog("",
                    "项目中不存在 DataTableProcessor.DataProcessorUtility.cs文件  请检查是否已经导入UnityGameFramework 框架。", "确定");
            }
        }

        private static class DirectoryAllFiles
        {
            static readonly List<FileInformation> FileList = new List<FileInformation>();

            public static List<FileInformation> GetAllFiles(DirectoryInfo dir)
            {
                FileInfo[] allFile = dir.GetFiles();
                foreach (FileInfo fi in allFile)
                {
                    FileList.Add(new FileInformation {FileName = fi.Name, FilePath = fi.FullName});
                }

                DirectoryInfo[] allDir = dir.GetDirectories();
                foreach (DirectoryInfo d in allDir)
                {
                    GetAllFiles(d);
                }

                return FileList;
            }
        }

        private class FileInformation
        {
            public string FileName { get; set; }
            public string FilePath { get; set; }
        }
    }
}