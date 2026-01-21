namespace Studying.Day_2
{
    public readonly struct Maybe<T>
    {
        private readonly T? _value;
        public bool HasValue => _value != null;
        public T Value => HasValue ? _value! : throw new InvalidOperationException();
        public Maybe(T value)
        {
            _value = value; 
        }
    }
}
