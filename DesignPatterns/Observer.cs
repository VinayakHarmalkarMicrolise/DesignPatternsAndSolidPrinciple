using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public interface Notify
    {
        public void AddDevice(IDevice d);
        public void RemoveDevice(IDevice d);
        public void NotifyAllDevice();
    }

    public class NotificationObserver : Notify
    {
        List<IDevice> d = new List<IDevice> ();

        public void AddDevice(IDevice source)
        {
            d.Add(source);
        }

        public void RemoveDevice(IDevice device)
        {
            d.Remove(device);
        }

        public void NotifyAllDevice()
        {
            foreach (IDevice device in d)
            {
                device.NotifyDevice();
            }
        }
    }

    public interface IDevice
    { 
        public void NotifyDevice();
    } 

    public class Phone : IDevice
    {
        public Phone() { }

        public void NotifyDevice()
        {
            Console.WriteLine("Notified the Phone");
        }
    }

    public class Laptop : IDevice
    {
        public Laptop() { }

        public void NotifyDevice()
        {
            Console.WriteLine("Notified the Laptop");
        }
    }

    public class Ipad : IDevice
    {
        public Ipad() { }

        public void NotifyDevice()
        {
            Console.WriteLine("Notified the Ipad");
        }
    }
}
