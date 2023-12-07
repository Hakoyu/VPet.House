using HKW.HKWUtils.Observable;
using System.ComponentModel;

namespace HKW.Models;

/// <summary>
/// 可观察的范围
/// </summary>
/// <typeparam name="T">类型</typeparam>
public class ObservableRange<T> : ObservableClass<ObservableRange<T>>
{
    private T _min;
    public T Min
    {
        get => _min;
        set => SetProperty(ref _min, value);
    }

    private T _max;
    public T Max
    {
        get => _max;
        set => SetProperty(ref _max, value);
    }

    private string _info;
    public string Info
    {
        get => _info;
        set => SetProperty(ref _info, value);
    }

    private readonly PropertyChangeListener _listener;

    public ObservableRange()
    {
        _listener = new(this);
        _listener.PropertyNames.Add(nameof(Min));
        _listener.PropertyNames.Add(nameof(Max));
        _listener.PropertyChanged += Listener_PropertyChanged;
    }

    private void Listener_PropertyChanged(object sender, PropertyChangedEventArgs e)
    {
        Info = $"({Min} ~ {Max})";
    }

    public ObservableRange(T min, T max)
        : this()
    {
        _min = min;
        _max = max;
    }

    /// <summary>
    /// 复制
    /// </summary>
    /// <returns></returns>
    public ObservableRange<T> Copy()
    {
        return new(Min, Max);
    }
}
