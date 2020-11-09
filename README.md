# UGFDataTableExtension
对[UnityGameFramework](https://github.com/EllanJiang/UnityGameFramework)中DataTable模块的扩展  支持List,数组,字典  不支持嵌套   只支持一维
新增对枚举的支持

# 使用教程
使用本工具需要熟悉[UnityGameFramework](https://github.com/EllanJiang/UnityGameFramework) 框架中DataTable模块 
## 配置数据表
使用如(Microsoft Excel,Wps)等工具编辑表格 保存时文件类型选择 文本文件(制表符分隔)(*.txt) 格式也可以自定义 如使用自定义分隔符分隔 需修改 [DataTableProcessor.cs](./Assets/Scripts/DataTableExtensions/Editor/DataTableGenerator/DataTableProcessor.cs)文件中的DataSplitSeparators。

List在数据表中的类型为配置 list\<type> （不区分大小写） type为实现了GenericDataProcessor的类型 list
内置类型使用 ,进行分割   其他类型使用 | 进行分割
例：list\<int> 1,2,3   
list\<vector3> 12.34,23.22,34.22|12.34,23.22,34.22|12.34,23.22,34.22

数组在数据表中的类型为配置 type[] （不区分大小写） type为实现了GenericDataProcessor的类型
内置类型使用 ,进行分割   其他类型使用 | 进行分割
例：int[] 1,2,3   
vector3[]   12.34,23.22,34.22|12.34,23.22,34.22|12.34,23.22,34.22

Dictionary在数据表中的类型为配置 dictionary\<keyType,valueType> （不区分大小写） 键值类型为实现了GenericDataProcessor的类型 不同元素在表中使用 | 进行分割 key value 使用# 进行分割
例：dictionary\<int,int> {1#1}|{2#2}|{3#3}     dictionary\<int,vector3>
 {1#0.2,1.5,100}|{2#222,444,111}|{3#3.15,385.123,123}

枚举类型在数据表中的类型为 枚举名称 值为枚举对应的int值 不支持使用枚举元素名
例: TestEnum  1

<font color=#FF0000>注意:string类型不能在字符串中出现分隔符 不然会导致分割出错。</font>

<font color=#FF0000>枚举类型在作为集合中的元素时 需要生成Extension 否则会导致找不到解析函数问题</font>

GF中实现了GenericDataProcessor的类型有22中 为Boolean,Byte,Char,Color,Color32,DateTime,Decimal,Double,Single,Int32,Int64,Quaternion,Rect,SByte,Int16,String,UInt32,UInt64,UInt16,Vector2,Vector3,Vector4 
自定义类型可以自行扩展。

## 生成数据实体类
配置好的数据表放入Assets/Res/DataTables 文件夹中   文件夹路径定义再[DataTableGeneratorMenu.cs](./Assets/Scripts/DataTableExtensions/Editor/DataTableGenerator/DataTableGeneratorMenu.cs) 和 [DataTableGenerator.cs](./Assets/Scripts/DataTableExtensions/Editor/DataTableGenerator/DataTableGenerator.cs) 中DataTablePath字段 可自行修改。

如果添加了自定义类型Processor 需要先执行Unity菜单栏中 DataTable/GenerateExtension 生成解析扩展类否则无法解析自定义类型  扩展类存放位置[DataTableGenerator.cs](./Assets/Scripts/DataTableExtensions/Editor/Extensions/ExtensionsGenerate.cs) ExtensionDirectoryPath字段。
其中 [BinaryReaderExtension.cs](./Assets/Scripts/DataTableExtensions/Runtime/Extensions/BinaryReaderExtension.cs) 和 [DataTableExtension.cs](./Assets/Scripts/DataTableExtensions/Runtime/Extensions/DataTableExtension.cs) 为默认解析类 不会自动生成 如更改扩展类路径 请自行拷贝。

使用Unity菜单栏中 DataTable/Generate DataTables 生成数据实体类 数据实体类存放路径为[DataTableGenerator.cs](./Assets/Scripts/DataTableExtensions/Editor/DataTableGenerator/DataTableGenerator.cs) CSharpCodePath字段。

## 加载使用 
请自行查看[UnityGameFramework](https://github.com/EllanJiang/UnityGameFramework) 中DataTable模块使用方法
