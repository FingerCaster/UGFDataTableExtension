namespace DE.Editor
{
    public interface ICollectionProcessor
    {
        System.Type ItemType { get; }

        string ItemLanguageKeyword { get; }
    }
}