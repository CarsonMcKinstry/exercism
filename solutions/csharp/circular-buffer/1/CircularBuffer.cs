public class CircularBuffer<T>
{

    private readonly int _capacity;
    private Queue<T> _buffer;
    
    public CircularBuffer(int capacity)
    {
        _capacity = capacity;
        _buffer = new Queue<T>(capacity);
    }

    public T Read()
    {
        if (_buffer.Count == 0)
        {
            throw new InvalidOperationException("Buffer is empty.");
        }

        return _buffer.Dequeue();
    }

    public void Write(T value)
    {
        if (_buffer.Count == _capacity)
        {
            throw new InvalidOperationException("Buffer is full.");
        }
        
        _buffer.Enqueue(value);
    }

    public void Overwrite(T value)
    {
        if (_buffer.Count == _capacity)
        {
            _buffer.Dequeue();
        }

        Write(value);
    }

    public void Clear() => _buffer.Clear();
}