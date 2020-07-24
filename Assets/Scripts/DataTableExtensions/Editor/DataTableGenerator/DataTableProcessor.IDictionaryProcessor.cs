using System;

namespace DE.Editor
{
    public interface IDictionaryProcessor
    {
        Type KeyType { get; }
        Type ValueType { get; }
        string KeyLanguageKeyword { get; }
        string ValueLanguageKeyword { get; }
    }
}