using HW13.Task2.Models;
using HW13.Task2.Interfaces;
using HW13.Task2;
using Serilog;
{
    string applicationName = System.Reflection.Assembly.GetExecutingAssembly().GetName().Name;
    Log.Logger = new LoggerConfiguration()
    .WriteTo.Console()
    .WriteTo.File(@"../../log.txt", rollingInterval: RollingInterval.Hour)
    .CreateLogger();

    try
    {
        Log.Information($"Application {applicationName} started");

        MotorcycleRepository repository = new MotorcycleRepository();

        var moto1 = new Motorcycle(1, "Yamaha", "YBR 125", 2003, 15_000);
        var moto2 = new Motorcycle(2, "Zid", "Enduro 250", 2020, 1);
        var moto3 = new Motorcycle(3, "Honda", "SB 400", 2003, 10_000);

        repository.CreateMotorcycle(moto1);
        repository.CreateMotorcycle(moto2);
        repository.CreateMotorcycle(moto3);

        var searchMoto = repository.GetMotorcycle(1);

        repository.Update(moto3);
        var listAfterpdate = repository.GetListMotorcycle();

        repository.Delete(moto2.Id);
        var listAfterDelete = repository.GetListMotorcycle();

        repository.Delete(4);//ex

        Console.ReadLine();

        Log.Information($"Application {applicationName} finished");
    }
    catch (Exception ex)
    {
        Log.Error($"Application {applicationName} crashed");
        Log.Error(ex.StackTrace + " " + ex.Message + " " + ex.Data);
    }
   
}



