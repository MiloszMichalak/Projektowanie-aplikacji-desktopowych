namespace ViewModelDevices;

public class Device(int id, string name, double temperature, double voltage, int uptime)
{
    public int Id { get; set; } = id;
    public string Name { get; set; } = name;
    public double Temperature { get; set; } = temperature;
    public double Voltage { get; set; } = voltage;
    public int Uptime { get; set; } = uptime;
}