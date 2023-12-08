using HKW.HKWUtils.Observable;
using HKW.Models;
using System.Collections.ObjectModel;
using System.Windows.Media.Imaging;
using VPet.House.Resources;

namespace VPet.House.ViewModels;

public class MainWindowVM : ObservableClass<MainWindowVM>
{
    private HouseModel _house;
    public HouseModel House
    {
        get => _house;
        set => SetProperty(ref _house, value);
    }

    public MainWindowVM()
    {
        House = new()
        {
            Room = new()
            {
                LeftWall = Utils.LoadImageToMemoryStream(
                    NativeResources.GetStream(NativeResources.Wall)
                ),
                RightWall = Utils.LoadImageToMemoryStream(
                    NativeResources.GetStream(NativeResources.Wall)
                ),
                Roof = Utils.LoadImageToMemoryStream(
                    NativeResources.GetStream(NativeResources.Floor)
                ),
                Floor = Utils.LoadImageToMemoryStream(
                    NativeResources.GetStream(NativeResources.Floor)
                ),
            }
        };
    }
}

/// <summary>
/// 房子模型
/// </summary>
public class HouseModel : ObservableClass<HouseModel>
{
    private BitmapImage _background;

    /// <summary>
    /// 背景
    /// </summary>
    public BitmapImage Background
    {
        get => _background;
        set => SetProperty(ref _background, value);
    }

    private RoomModel _room;

    /// <summary>
    /// 房间
    /// </summary>
    public RoomModel Room
    {
        get => _room;
        set => SetProperty(ref _room, value);
    }

    /// <summary>
    /// 关闭
    /// </summary>
    public void Close()
    {
        Room.Close();
    }
}

/// <summary>
/// 房间模型
/// </summary>
public class RoomModel : ObservableClass<RoomModel>
{
    private BitmapImage _backgroundWall;

    /// <summary>
    /// 背景墙
    /// </summary>
    public BitmapImage BackgroundWall
    {
        get => _backgroundWall;
        set => SetProperty(ref _backgroundWall, value);
    }

    private BitmapImage _leftWall;

    /// <summary>
    /// 左墙
    /// </summary>
    public BitmapImage LeftWall
    {
        get => _leftWall;
        set => SetProperty(ref _leftWall, value);
    }

    private BitmapImage _rightWall;

    /// <summary>
    /// 右墙
    /// </summary>
    public BitmapImage RightWall
    {
        get => _rightWall;
        set => SetProperty(ref _rightWall, value);
    }

    private BitmapImage _roof;

    /// <summary>
    /// 屋顶
    /// </summary>
    public BitmapImage Roof
    {
        get => _roof;
        set => SetProperty(ref _roof, value);
    }

    private BitmapImage _floor;

    /// <summary>
    /// 地板
    /// </summary>
    public BitmapImage Floor
    {
        get => _floor;
        set => SetProperty(ref _floor, value);
    }

    /// <summary>
    /// 全部家具
    /// </summary>
    public ObservableCollection<FurnitureModel> AllFurniture { get; } = new();

    /// <summary>
    /// 关闭
    /// </summary>
    public void Close()
    {
        LeftWall.CloseStream();
        RightWall.CloseStream();
        Roof.CloseStream();
        Floor.CloseStream();
        foreach (var furniture in AllFurniture)
            furniture.Close();
    }
}

/// <summary>
/// 家具模型
/// </summary>
public class FurnitureModel : ObservableClass<FurnitureModel>
{
    private FurnitureType _type;

    /// <summary>
    /// 家具类型
    /// </summary>
    public FurnitureType Type
    {
        get => _type;
        set => SetProperty(ref _type, value);
    }

    private BitmapImage _image;

    /// <summary>
    /// 图片
    /// </summary>
    public BitmapImage Image
    {
        get => _image;
        set => SetProperty(ref _image, value);
    }

    /// <summary>
    /// 关闭
    /// </summary>
    public void Close()
    {
        Image.CloseStream();
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
