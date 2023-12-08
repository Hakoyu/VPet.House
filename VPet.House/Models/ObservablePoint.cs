using HKW.HKWUtils.Observable;

namespace HKW.Models;

public class ObservablePoint<T> : ObservableClass<ObservablePoint<T>>
{
    private T _x;
    public T X
    {
        get => _x;
        set => SetProperty(ref _x, value);
    }

    private T _y;
    public T Y
    {
        get => _y;
        set => SetProperty(ref _y, value);
    }

    public ObservablePoint() { }

    public ObservablePoint(T x, T y)
    {
        X = x;
        Y = y;
    }
}
