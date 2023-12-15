using System.Windows.Media.Imaging;

namespace VPet.House.Models;

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
