using HKW.HKWUtils.Observable;
using HKW.HKWUtils;
using VPet.House.Resources;
using VPet.House.Models;

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
