using System.Windows.Media.Imaging;

namespace VPet.House.Models;

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
