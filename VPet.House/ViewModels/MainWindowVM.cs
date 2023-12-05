using HKW.HKWUtils.Observable;
using System.Collections.ObjectModel;
using System.Windows.Media.Imaging;

namespace VPet.House.ViewModels;

public class MainWindowVM { }

public class House
{
    public ObservableValue<BitmapImage> Background { get; } = new();
}

public class Room
{
    public ObservableValue<BitmapImage> BackgroundWall { get; } = new();
    public ObservableValue<BitmapImage> LeftWall { get; } = new();
    public ObservableValue<BitmapImage> RightWall { get; } = new();
    public ObservableValue<BitmapImage> Roof { get; } = new();
    public ObservableValue<BitmapImage> Floor { get; } = new();
    public ObservableCollection<Furniture> Furnitures { get; } = new();
}

public class Furniture
{
    public ObservableValue<FurnitureType> FurnitureType { get; } = new();
}

/// <summary>
/// 家具类型
/// </summary>
public enum FurnitureType
{
    /// <summary>
    /// 普通
    /// </summary>
    Normal,

    /// <summary>
    /// 墙饰
    /// </summary>
    WallDecoration,

    /// <summary>
    /// 顶饰
    /// </summary>
    RoofDecoration,
}
