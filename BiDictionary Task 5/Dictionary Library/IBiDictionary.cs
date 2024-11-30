namespace Dictionary_Library
{
    public interface IBiDictionary<T1, T2> : IDictionary<T1, T2>
    {
        public IReadOnlyDictionary<T2, T1> Inverse { get; }
    }
}
