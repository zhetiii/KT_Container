namespace KT_Container
{
    public class CountingContainer<T> : Container<T>
    {
        public int TotalAdded { get; private set; } = 0;

        public override void Add(T item)
        {
            base.Add(item);
            TotalAdded++;
        }
    }
}