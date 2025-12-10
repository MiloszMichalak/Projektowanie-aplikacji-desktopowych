using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;

namespace ViewModelDevices;

public partial class DeviceViewModel : ObservableObject
{
    public ObservableCollection<Device> Devices { get; set; } = new();
    
    [ObservableProperty] private int _amount;

    public DeviceViewModel()
    {
        Devices.Add(new Device(0, "nazwa1", 5.6, 6.7, 67));
        Devices.Add(new Device(1, "nazwa2", 3.4, 7.5, 96));
    }
}