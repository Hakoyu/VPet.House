﻿using HKW.HKWUtils.Observable;
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

    public ObservableRange() { }

    public ObservableRange(T min, T max)
    {
        _min = min;
        _max = max;
    }
}
