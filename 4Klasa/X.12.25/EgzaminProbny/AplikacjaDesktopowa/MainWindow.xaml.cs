using System.Collections;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;

namespace AplikacjaDesktopowa;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    private readonly List<string> _lengthUnits = ["Centrymentry", "Cale", "Stopy", "Metry", "Kilometry", "Mile"];
    private readonly List<string> _weightUnits = ["Gramy", "Funty", "Kilogramy", "Tony"];
    private readonly List<string> _temperatureUnits = ["Celsjusz", "Fahrenheit", "Kelwin"];
    
    public MainWindow()
    {
        InitializeComponent();
    }

    private void TabControl_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        var selectedType = TabControl.SelectedIndex;
        BaseComboBox.Items.Clear();
        TargetComboBox.Items.Clear();
        
        switch (selectedType)
        {
            case 0:
                AddItemsToComboBox(_lengthUnits);
                break;
            case 1:
                AddItemsToComboBox(_weightUnits);
                break;
            case 2:
                AddItemsToComboBox(_temperatureUnits);
                break;
        }

        BaseComboBox.SelectedIndex = 0;
        TargetComboBox.SelectedIndex = 0;
    }

    private void ConvertBtn_OnClick(object sender, RoutedEventArgs e)
    {
        var selectedUnit = TabControl.SelectedIndex;

        double inputValue;
        if (selectedUnit < 2)
        {
            if (!double.TryParse(BaseValue.Text, out inputValue) || inputValue < 0)
            {
                MessageBox.Show("Wprowadź poprawną wartość liczbową i dodatnia.", "Błąd");
                return;
            }
        }
        else
        {
            if (!double.TryParse(BaseValue.Text, out inputValue))
            {
                MessageBox.Show("Wprowadź poprawną wartość liczbową.", "Błąd");
                return;
            }
        }
        
        var baseUnit = BaseComboBox.SelectedIndex;
        var targetUnit = TargetComboBox.SelectedIndex;
        
        List<double> values;
        switch (selectedUnit)
        {
            case 0:
                values = [1.0, 2.54, 30.48, 100.0, 100000.0, 160934.0];
                CalculateAndAddToList(inputValue, values, baseUnit, targetUnit, _lengthUnits);
                break;
            case 1:
                values = [1.0, 454.54, 1000.0, 1_000_000.0];
                CalculateAndAddToList(inputValue, values, baseUnit, targetUnit, _weightUnits);
                break;
            case 2:
                values = [1.0, 0.5556, 274.15];
                CalculateAndAddToList(inputValue, values, baseUnit, targetUnit, _temperatureUnits);
                break;
        }

        if (ListBox.Items.Count > 5)
        {
            ListBox.Items.RemoveAt(5);
        }
    }

    private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
    {
        BaseValue.Text = "0";
        ConvertedText.Content = "0";
    }

    private void AddItemsToComboBox(List<string> list)
    {
        foreach (var unit in list)
        {
            BaseComboBox.Items.Add(unit);
            TargetComboBox.Items.Add(unit);
        }
    }

    private void CalculateAndAddToList(double inputValue, List<double> values, int baseUnit, int targetUnit, List<string> units)
    {
        var valueInBase = inputValue * values[baseUnit];
        var converted = valueInBase / values[targetUnit];
        
        ConvertedText.Content = converted;

        ListBoxItem itm = new ListBoxItem
        {
            Content = $"{inputValue} {units[baseUnit]} = {converted} {units[targetUnit]}"
        };
        
        ListBox.Items.Insert(0, itm);
    }
}