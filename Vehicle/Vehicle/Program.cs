public interface IVehicle
{
    void Drive();
}
public class car : IVehicle
{
    public
        void Drive()
    {
        Console.WriteLine("Car is Moving");
    }

}
public class truck : IVehicle
{
    public
        void Drive()
    {
        Console.WriteLine("Truck is Moving");
    }

}
public sealed class VehicleLogger{
    private VehicleLogger() { }
    private static VehicleLogger instance = null;
    public static VehicleLogger Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new VehicleLogger();
            }
            return instance;
        }
    }
    public static void Log(string message)
    {
        Console.WriteLine("Message");
    }
}
public abstract class VehicleFactory
{
    public abstract IVehicle CreateVehicle();
   public void DoSomethingWithVehicle()
    {
        Console.WriteLine("msg");
    }
}
public class carFactory : VehicleFactory
{
    public override IVehicle CreateVehicle()
    {
        throw new NotImplementedException();
    }
}
public class truckFactory : VehicleFactory
{
    public override IVehicle CreateVehicle()
    {
        throw new NotImplementedException();
    }
}

public interface IRepository<T> {
    T GetById(int id); 
IEnumerable<T> GetAll(); 
void Add(T entity); 
void Update(T entity); 
void Delete(T entity);
    
}

public class VehicleRepository : IRepository<IVehicle>
{


}