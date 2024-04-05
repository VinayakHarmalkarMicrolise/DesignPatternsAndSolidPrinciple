using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    
    public class Facade
    {
        public void OrderFood()
        {
            Starter s = new Starter();
            s.CookFood();

            MainCourse m = new MainCourse();
            m.CookFood();

            Desert d = new Desert();
            d.CookFood();
        }

    }

    public interface IKitchen
    {
        public void CookFood();
    }

    public class Starter : IKitchen
    {
        public void CookFood()
        {
            throw new NotImplementedException();
        }
    }

    public class MainCourse : IKitchen
    {
        public void CookFood()
        {
            throw new NotImplementedException();
        }
    }

    public class Desert : IKitchen
    {
        public void CookFood()
        {
            throw new NotImplementedException();
        }
    }

}
