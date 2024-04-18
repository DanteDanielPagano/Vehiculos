using Vehiculos.Enums;
using Vehiculos.Interfaces;

namespace Vehiculos.Implementtions;
public class Car : IVehicle
{
    public sbyte SpeedValue { get; set; }
    public GearBox GearValue { get; set; }
    private StateOfVehicle _state;

    public Car()
    {
        SpeedValue = 0;
        GearValue = GearBox.Neutral;
        _state = StateOfVehicle.Off;
    }

    public void Accelerate()
    {
        if (_state == StateOfVehicle.On &&
            GearValue == GearBox.Neutral &&
            SpeedValue == 0)
        {
            GearValue = GearBox.Primera;
        }
        if (_state == StateOfVehicle.On && GearValue != GearBox.Neutral)
        {
            if (SpeedValue <= 120)
            {
                SpeedValue += 10;
                UpGear();
                if (SpeedValue > 120)
                {
                    SpeedValue = 120;
                }
            }

        }
    }

    public void Brake()
    {
        if (SpeedValue > 0)
        {
            SpeedValue -= 20;
            DownGear();
            if (SpeedValue < 0)
            {
                SpeedValue = 0;
                DownGear();
            }
        }


    }

    public void Decelerate()
    {
        if (SpeedValue > 0)
        {
            SpeedValue -= 10;
            DownGear();
            if (SpeedValue < 0)
            {
                SpeedValue = 0;
            }
        }
    }

    public StateOfVehicle Start()
    {
        if (_state == StateOfVehicle.Off)
        {
            _state = StateOfVehicle.On;
        }
        return _state;
    }

    public StateOfVehicle Stop()
    {
        if (_state == StateOfVehicle.On)
        {
            _state = StateOfVehicle.Off;
        }
        return _state;
    }

    private void DownGear()
    {
        switch (SpeedValue)
        {
            case 0:
                GearValue = GearBox.Neutral;
                break;
            case <= 20:
                GearValue = GearBox.Primera;
                break;
            case <= 40:
                GearValue = GearBox.Segunda;
                break;
            case <= 60:
                GearValue = GearBox.Tercera;
                break;
            case <= 80:
                GearValue = GearBox.Cuarta;
                break;
            case <= 100:
                GearValue = GearBox.Quinta;
                break;
            default:
                GearValue = GearBox.Sexta;
                break;
        }
    }
    private void UpGear()
    {
        switch (SpeedValue)
        {
            case <= 20:
                GearValue = GearBox.Primera;
                break;
            case <= 40:
                GearValue = GearBox.Segunda;
                break;
            case <= 60:
                GearValue = GearBox.Tercera;
                break;
            case <= 80:
                GearValue = GearBox.Cuarta;
                break;
            case <= 100:
                GearValue = GearBox.Quinta;
                break;
            default:
                GearValue = GearBox.Sexta;
                break;

        }
    }

}
