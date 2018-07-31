/// <summary>
/// This interface was setup based on Michael Fowler's Range by a colleague
/// </summary>
namespace AutomationTesting.Classes
{
    public interface IRange<T>
    {
        T Start { get; }
        T End { get; }
        bool Includes(T value);
        bool Includes(IRange<T> range);
    }
}
