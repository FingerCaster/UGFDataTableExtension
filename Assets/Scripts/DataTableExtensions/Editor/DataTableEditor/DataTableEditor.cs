using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditorInternal;
using System.IO;
using System.Text;
using System;
using System.Reflection;
using UnityEditor;

namespace DE.Editor
{
    public class DataTableUtility
    {
        public static Vector2 GetMiddlePosition(float windowWidth, float windowHeight)
        {
            return new Vector2(Screen.currentResolution.width / 2 - windowWidth / 2,
                Screen.currentResolution.height / 2 - windowHeight / 2);
        }

        public static Vector2 GetMiddlePosition(Vector2 windowSize)
        {
            return new Vector2(Screen.currentResolution.width / 2 - windowSize.x / 2,
                Screen.currentResolution.height / 2 - windowSize.y / 2);
        }

        //模板
        public static List<DataTableRowData> DataTableTemplate = new List<DataTableRowData>
        {
            new DataTableRowData()
            {
                Data = new List<string>()
                {
                    "#", "配置", "", ""
                }
            },
            new DataTableRowData()
            {
                Data = new List<string>()
                {
                    "#", "ID", "", ""
                }
            },
            new DataTableRowData()
            {
                Data = new List<string>()
                {
                    "#", "int", "", ""
                }
            },
            new DataTableRowData()
            {
                Data = new List<string>()
                {
                    "", "0", "", ""
                }
            },
        };

        /// <summary>
        /// 新建表格
        /// </summary>
        /// <returns>新建表格文件路径</returns>
        public static string NewDataTableFile()
        {
            string path = EditorUtility.SaveFilePanel("保存文件", "", "template.txt", "txt");

            if (string.IsNullOrEmpty(path) == false)
                SaveDataTableFile(path, DataTableTemplate);

            return path;
        }

        /// <summary>
        /// 保存表格文件
        /// </summary>
        /// <param name="path">保存文件路径</param>
        /// <param name="data">数据信息</param>
        /// <returns>保存是否成功</returns>
        public static bool SaveDataTableFile(string path, List<DataTableRowData> data)
        {
            using (StreamWriter sw = new StreamWriter(path, false, new UnicodeEncoding()))
            {
                for (int i = 0; i < data.Count; i++)
                {
                    for (int j = 0; j < data[i].Data.Count; j++)
                    {
                        sw.Write(data[i].Data[j]);

                        if (j != data[i].Data.Count - 1)
                        {
                            sw.Write("\t");
                        }
                    }

                    if (i != data.Count - 1)
                    {
                        sw.WriteLine();
                    }
                }
            }

            EditorUtility.DisplayDialog("提示", "保存成功!", "ojbk");

            AssetDatabase.Refresh();

            return true;
        }

        /// <summary>
        /// 加载数据表文件
        /// </summary>
        /// <param name="path">表格文件路径</param>
        /// <returns>保存的信息数据</returns>
        public static List<DataTableRowData> LoadDataTableFile(string path)
        {
            if (File.Exists(path) == false)
            {
                EditorUtility.DisplayDialog("提示", "文件路径不存在", "确定");
                return null;
            }

            List<DataTableRowData> data = new List<DataTableRowData>();
            UTF8Encoding utf8 = new UTF8Encoding();
            using (StreamReader sr = new StreamReader(path, utf8))
            {
                while (sr.EndOfStream == false)
                {
                    string line = sr.ReadLine();
                    string[] splited = line.Split('\t');
                    DataTableRowData row = new DataTableRowData();

                    for (int i = 0; i < splited.Length; i++)
                    {
                        row.Data.Add(splited[i]);
                    }

                    data.Add(row);
                }
            }

            return data;
        }
    }

    public class DataTableRowData
    {
        public List<string> Data { get; set; }

        public DataTableRowData()
        {
            Data = new List<string>();
        }
    }

    public class DataTableEditor : EditorWindow
    {
        public static float ButtonHeight = 50;
        public static DataTableEditor Instance;

        [MenuItem("DataTable/DataTableEditor &1", priority = 2)]
        public static void OpenWindow()
        {
            if (DataTableEditingWindow.Instance != null)
            {
                DataTableEditingWindow.Instance.Close();
            }

            if (Instance != null)
            {
                Instance.Close();
                return;
            }

            Instance = DataTableEditor.CreateWindow<DataTableEditor>("数据表编辑器");
            Instance.Show();
        }

        private void OnGUI()
        {
            if (GUILayout.Button("新建", GUILayout.Height(ButtonHeight)))
                ButtonNew();

            if (GUILayout.Button("加载", GUILayout.Height(ButtonHeight)))
                ButtonLoad();
        }

        private void ButtonNew()
        {
            DataTableEditingWindow.OpenWindow(DataTableUtility.NewDataTableFile());
            this.Close();
        }

        private void ButtonLoad()
        {
            DataTableEditingWindow.OpenWindow(EditorUtility.OpenFilePanel("加载数据表格文件", "", "txt"));
            this.Close();
        }
    }

    public class DataTableEditingWindow : EditorWindow
    {
        public static DataTableEditingWindow Instance { get; private set; }
        public static List<DataTableRowData> RowDatas { get; private set; }
        private static List<DataTableRowData> RowDatasTemp;
#if UNITY_2020_1_OR_NEWER
        private UnityInternalBridge.ReorderableList reorderableList;
#else
        private ReorderableList reorderableList;
#endif
        public static string FilePath { get; private set; }
        public static int LightMode = 0;
        public string Theme = "LODCameraLine";
        private Vector2 m_scrollViewPos;

        public static void OpenWindow(string path)
        {
            FilePath = path;
            RowDatas = DataTableUtility.LoadDataTableFile(FilePath);

            if (RowDatas == null)
                return;

            RowDatasTemp = new List<DataTableRowData>();

            for (int i = 0; i < RowDatas.Count; i++)
            {
                DataTableRowData data = new DataTableRowData();

                for (int j = 0; j < RowDatas[i].Data.Count; j++)
                {
                    data.Data.Add(RowDatas[i].Data[j]);
                }

                RowDatasTemp.Add(data);
            }

            if (RowDatas == null)
                return;

            FileInfo fileInfo = new FileInfo(path);
            Instance = DataTableEditingWindow.CreateWindow<DataTableEditingWindow>(fileInfo.Name);
            Instance.Show();

            LightMode = EditorPrefs.GetInt("DataTableEditor_" + Application.productName + "_LightMode", 0);
        }

        private void OnGUI()
        {
            m_scrollViewPos = GUILayout.BeginScrollView(m_scrollViewPos);

            if (RowDatas == null || RowDatas.Count == 0)
            {
                Close();
                return;
            }

            CheckColumnCount();

            if (LightMode == 0)
            {
                Theme = "ScriptText";
            }
            else if (LightMode == 1)
            {
                Theme = "PreferencesSectionBox";
            }

            if (reorderableList == null)
            {
#if UNITY_2020_1_OR_NEWER
                 reorderableList =
                    new UnityInternalBridge.ReorderableList(RowDatas, typeof(List<DataTableRowData>), true, false, true,
                        true);
#else
                reorderableList =
                    new ReorderableList(RowDatas, typeof(List<DataTableRowData>), true, false, true,
                        true);
#endif


                reorderableList.drawHeaderCallback = (Rect rect) =>
                {
                    EditorGUI.LabelField(rect, FilePath);
                    rect.x = rect.width - 70;
                    EditorGUI.LabelField(rect, "高亮模式");
                    rect.x = rect.width - 20;

                    LightMode =
                        EditorGUI.Toggle(rect, LightMode == 0 ? true : false)
                            ? 0
                            : 1;

                    EditorPrefs
                        .SetInt("DataTableEditor_" + Application.productName + "_LightMode",
                            LightMode);
                };
                reorderableList.drawElementCallback = (Rect rect, int index, bool selected, bool focused) =>
                {
                    for (int i = 0; i < RowDatas[index].Data.Count; i++)
                    {
                        rect.width =
                            (Instance.position.width - 20) /
                            RowDatas[index].Data.Count;

                        rect.x = rect.width * i + 20;

                        RowDatas[index].Data[i] =
                            EditorGUI.TextField(rect, "", RowDatas[index].Data[i],
                                Instance.Theme);
                    }
                };

                reorderableList.onAddCallback = (list) =>
                {
                    bool result =
                        EditorUtility.DisplayDialog("提示", "添加 行 或 列", "行", "列");

                    if (result)
                    {
                        if (RowDatas.Count == 0)
                        {
                            RowDatas.Add(new DataTableRowData()
                            {
                                Data = new List<string>() {"", "", "", ""}
                            });
                        }
                        else
                        {
                            DataTableRowData data = new DataTableRowData();

                            for (int i = 0; i < RowDatas[0].Data.Count - 1; i++)
                            {
                                data.Data.Add("");
                            }

                            RowDatas.Add(data);
                        }
                    }
                    else
                    {
                        for (int i = 0; i < RowDatas.Count; i++)
                            RowDatas[i].Data.Add("");
                    }
                };

                reorderableList.onRemoveCallback = (list) =>
                {
                    bool result =
                        EditorUtility.DisplayDialog("提示", "移除 行 或 列", "行", "列");

                    if (result)
                    {
                        RowDatas.RemoveAt(list.index);
                    }
                    else
                    {
                        for (int i = 0; i < RowDatas.Count; i++)
                        {
                            RowDatas[i].Data.RemoveAt(RowDatas[i].Data.Count - 1);
                        }
                    }
                };
            }

            reorderableList.DoLayoutList();

            GUILayout.EndScrollView();
        }

        private void OnDisable()
        {
            if (!CheckDirty())
                return;

            bool result = EditorUtility.DisplayDialog("提示", "你已经对表格进行了修改，是否需要保存？", "是", "否");

            if (result)
            {
                DataTableUtility.SaveDataTableFile(FilePath, RowDatas);
            }
        }

        /// <summary>
        /// 检查列数一致性
        /// </summary>
        private void CheckColumnCount()
        {
            if (RowDatas.Count == 0)
                return;

            int count = RowDatas[0].Data.Count;

            for (int i = 0; i < RowDatas.Count; i++)
            {
                int need = count - RowDatas[i].Data.Count;

                if (need > 0)
                    for (int j = 0; j < need; j++)
                        RowDatas[i].Data.Add("");
                else if (need < 0)
                    for (int j = 0; j < Mathf.Abs(need); j++)
                        RowDatas[i].Data.RemoveAt(RowDatas[i].Data.Count - 1);
            }
        }

        /// <summary>
        /// 检查表格是否进行更改
        /// </summary>
        /// <returns></returns>
        private bool CheckDirty()
        {
            if (RowDatasTemp.Count != RowDatas.Count)
                return true;

            for (int i = 0; i < RowDatas.Count; i++)
            {
                if (RowDatasTemp[i].Data.Count != RowDatas[i].Data.Count)
                    return true;

                for (int j = 0; j < RowDatas[i].Data.Count; j++)
                {
                    if (RowDatas[i].Data[j] != RowDatasTemp[i].Data[j])
                        return true;
                }
            }

            return false;
        }
    }
}