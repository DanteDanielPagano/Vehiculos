// See https://aka.ms/new-console-template for more information
using Vehiculos.Implementtions;

Car car = new Car();
car.Accelerate();
Console.WriteLine($"La velocidad actual es: {car.SpeedValue}");
Console.WriteLine($"Su caja de cambio de encuentra en: {car.GearValue}");

Console.WriteLine($"El vehiculo esta en el estado: {car.Start()}");

car.Accelerate();
Console.WriteLine($"La velocidad actual es: {car.SpeedValue}");
Console.WriteLine($"Su caja de cambio de encuentra en: {car.GearValue}");

car.Accelerate();
Console.WriteLine($"La velocidad actual es: {car.SpeedValue}");
Console.WriteLine($"Su caja de cambio de encuentra en: {car.GearValue}");
car.Accelerate();
Console.WriteLine($"La velocidad actual es: {car.SpeedValue}");
Console.WriteLine($"Su caja de cambio de encuentra en: {car.GearValue}");
car.Decelerate();
Console.WriteLine($"La velocidad actual es: {car.SpeedValue}");
Console.WriteLine($"Su caja de cambio de encuentra en: {car.GearValue}");
car.Decelerate();
Console.WriteLine($"La velocidad actual es: {car.SpeedValue}");
Console.WriteLine($"Su caja de cambio de encuentra en: {car.GearValue}");
car.Brake();
Console.WriteLine($"La velocidad actual es: {car.SpeedValue}");
Console.WriteLine($"Su caja de cambio de encuentra en: {car.GearValue}");