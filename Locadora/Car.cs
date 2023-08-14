using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Locadora
{
    public class Car
    {
        public int id;
        public string model;
        
        public Car(int id, string model){
            this.id = id;
            this.model = model;
        }

    }
}