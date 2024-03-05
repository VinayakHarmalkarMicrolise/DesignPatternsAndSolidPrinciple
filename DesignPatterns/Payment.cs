using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public interface IPayment
    {
        public void DoPayment(int amount);
    }

    public class UPI : IPayment
    {
        public void DoPayment(int amount)
        {

        }
    }

    public class NetBanking : IPayment
    {
        public void DoPayment(int amount)
        {
            throw new NotImplementedException();
        }
    }

    public class Card : IPayment
    {
        public void DoPayment(int amount)
        {
            throw new NotImplementedException();
        }
    }

    public class MakePayment
    {
        public IPayment paymentType ;
        public void makePayment(IPayment paymentType)
        {
            paymentType.DoPayment(1000);
        }
    }
}
