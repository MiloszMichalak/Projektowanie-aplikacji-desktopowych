using CommunityToolkit.Mvvm.ComponentModel;

namespace OpisywaczMVVM;

public partial class DescriberViewmodel : ObservableObject
{
    public DescriberViewmodel()
    {
        _describer = new Describer();
    }
    
    [ObservableProperty]
    private string _feature1;
    [ObservableProperty]
    private string _feature2;
    [ObservableProperty]
    private string _feature3;
    
    [ObservableProperty]
    private Describer _describer;
}