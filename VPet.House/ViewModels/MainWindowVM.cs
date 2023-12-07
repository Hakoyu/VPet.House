using HKW.HKWUtils.Observable;
using System.Collections.ObjectModel;
using System.Windows.Media.Imaging;

namespace VPet.House.ViewModels;

public class MainWindowVM { }

public class House : ObservableClass<House>
{
    private BitmapImage _background;
    public BitmapImage Background
    {
        get => _background;
        set => SetProperty(ref _background, value);
    }
}

public class Room : ObservableClass<Room>
{
    private BitmapImage _backgroundWall;
    public BitmapImage BackgroundWall
    {
        get => _backgroundWall;
        set => SetProperty(ref _backgroundWall, value);
    }

    private BitmapImage _leftWall;
    public BitmapImage LeftWall
    {
        get => _leftWall;
        set => SetProperty(ref _leftWall, value);
    }

    private BitmapImage _rightWall;
    public BitmapImage RightWall
    {
        get => _rightWall;
        set => SetProperty(ref _rightWall, value);
    }

    private BitmapImage _roof;
    public BitmapImage Roof
    {
        get => _roof;
        set => SetProperty(ref _roof, value);
    }

    private BitmapImage _floor;
    public BitmapImage Floor
    {
        get => _floor;
        set => SetProperty(ref _floor, value);
    }
    public ObservableCollection<Furniture> Furnitures { get; } = new();
}

public class Furniture : ObservableClass<Furniture>
{
    private FurnitureType _type;
    public FurnitureType Type
    {
        get => _type;
        set => SetProperty(ref _type, value);
    }
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
