using HKW.HKWUtils.Observable;

namespace HKW.Models;

public class ObservableRect<T> : ObservableClass<ObservableRect<T>>
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

    private T _width;
    public T Width
    {
        get => _width;
        set => SetProperty(ref _width, value);
    }

    private T _heigth;
    public T Height
    {
        get => _heigth;
        set => SetProperty(ref _heigth, value);
    }

    public ObservableRect() { }

    public ObservableRect(T x, T y, T width, T hetght)
    {
        X = x;
        Y = y;
        Width = width;
        Height = hetght;
    }
}
