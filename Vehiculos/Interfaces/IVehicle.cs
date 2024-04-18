using Vehiculos.Enums;

namespace Vehiculos.Interfaces;
public interface IVehicle
{
    sbyte SpeedValue { get; set; }
    GearBox GearValue { get; set; }
    StateOfVehicle Start();
    StateOfVehicle Stop();
    void Accelerate();
    void Decelerate();
    void Brake();

}
