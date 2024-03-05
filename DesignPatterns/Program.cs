using DesignPatterns;

public class Program
{
    public static void Main(String[] args)
    {
        NotificationObserver n = new NotificationObserver();
        n.AddDevice(new Phone());
        n.AddDevice(new Ipad());
        n.AddDevice(new Laptop());

        n.NotifyAllDevice();

        Console.ReadLine();
    }
}