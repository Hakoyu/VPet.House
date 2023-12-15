using System.Collections.ObjectModel;
using System.Windows.Media.Imaging;

namespace VPet.House.Models;

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
