# UGFDataTableExtension
对[UnityGameFramework](https://github.com/EllanJiang/UnityGameFramework)中DataTable模块的扩展  支持List,数组,字典  不支持嵌套 只支持一维

# 使用教程
使用本工具需要熟悉[UnityGameFramework](https://github.com/EllanJiang/UnityGameFramework) 框架中DataTable模块 
## 配置数据表
使用如(Microsoft Excel,Wps)等工具编辑表格 保存时文件类型选择 文本文件(制表符分隔)(*.txt) 格式也可以自定义 如使用自定义分隔符分隔 需修改 [DataTableProcessorHelper.cs](./Assets/Scripts/DataTableExtensions/Editor/Extensions/DataTableProcessorHelper.cs)文件中的DataSplitSeparators。

List在数据表中的类型为配置 list\<type> （不区分大小写） type为实现了GenericDataProcessor的类型

数组在数据表中的类型为配置 type[] （不区分大小写） type为实现了GenericDataProcessor的类型

Dictionary在数据表中的类型为配置 dictionary\<keyType,valueType> （不区分大小写） 键值类型为实现了GenericDataProcessor的类型

GF中实现了GenericDataProcessor的类型有22中 为Boolean,Byte,Char,Color,Color32,DateTime,Decimal,Double,Single,Int32,Int64,Quaternion,Rect,SByte,Int16,String,UInt32,UInt64,UInt16,Vector2,Vector3,Vector4 
自定义类型可以自行扩展。

## 生成数据实体类
配置好的数据表放入Assets/Res/DataTables 文件夹中   文件夹路径定义再[DataTableGeneratorMenu.cs](./Assets/Scripts/DataTableExtensions/Editor/DataTableGenerator/DataTableGeneratorMenu.cs) 和 [DataTableGenerator.cs](./Assets/Scripts/DataTableExtensions/Editor/DataTableGenerator/DataTableGenerator.cs) 中DataTablePath字段 可自行修改。

如果添加了自定义类型Processor 需要先执行Unity菜单栏中 DataTable/GenerateExtension 生成解析扩展类否则无法解析自定义类型  扩展类存放位置[DataTableGenerator.cs](./Assets/Scripts/DataTableExtensions/Editor/Extensions/ExtensionsGenerate.cs) ExtensionDirectoryPath字段。
其中 [BinaryReaderExtension.cs](./Assets/Scripts/DataTableExtensions/Runtime/Extensions/BinaryReaderExtension.cs) 和 [DataTableExtension.cs](./Assets/Scripts/DataTableExtensions/Runtime/Extensions/DataTableExtension.cs) 为默认解析类 不会自动生成 如更改扩展类路径 请自行拷贝。

使用Unity菜单栏中 DataTable/Generate DataTables 生成数据实体类 数据实体类存放路径为[DataTableGenerator.cs](./Assets/Scripts/DataTableExtensions/Editor/DataTableGenerator/DataTableGenerator.cs) CSharpCodePath字段。

## 加载使用 
请自行查看[UnityGameFramework](https://github.com/EllanJiang/UnityGameFramework) 中DataTable模块使用方法