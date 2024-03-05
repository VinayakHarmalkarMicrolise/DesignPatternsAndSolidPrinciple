using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    internal sealed class Validator
    {
        public static Validator validatorInstance; 
        private Validator() { }

        public static Validator GetInstance() {  
            if(validatorInstance==null)
            {
                validatorInstance = new Validator();
            }
            return validatorInstance; 
        }

        public void validateDetails(string message)
        {
            if (message == "order")
                this.validateOrder();
            else if(message == "sites")
                this.validateSite();
            else this.validateVehicle();
        }

        public void validateOrder() { }
        public void validateSite() { }
        public void validateVehicle() { }
    }

    

}
