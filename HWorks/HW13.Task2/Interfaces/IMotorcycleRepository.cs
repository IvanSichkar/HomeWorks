using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HW13.Task2.Models;

namespace HW13.Task2.Interfaces
{
    public interface IMotorcycleRepository
    {
        void CreateMotorcycle(Motorcycle item); 
        public List<Motorcycle> GetListMotorcycle(); 
        Motorcycle GetMotorcycle(int id); 
        void Update(Motorcycle item); 
        void Delete(int id); 
    }
}
