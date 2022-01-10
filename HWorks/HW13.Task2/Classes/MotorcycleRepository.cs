using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HW13.Task2.Classes;
using HW13.Task2.Interfaces;
using HW13.Task2.Models;
using Serilog;


namespace HW13.Task2
{
    public class MotorcycleRepository : IMotorcycleRepository
    {
        private static List<Motorcycle> _motorcycles = new List<Motorcycle>();
        public void CreateMotorcycle(Motorcycle item)
        {
            _motorcycles.Add(item);
            Log.Information($"Create moto:id= {item.Id }");
        }
        public List<Motorcycle> GetListMotorcycle()
        {
            Log.Information($"List moto is received");
            return _motorcycles;
        }

        public Motorcycle GetMotorcycle(int id)
        {
                Log.Information($"Search moto:id= {id}");
                var moto = _motorcycles.Find(x => x.Id == id);
                if (moto is null)
                    throw new MotorcycleNotFoundException(id.ToString());
                else
                    Log.Information($"Moto:id= {id} is find");
                return moto;
        }
        public void Update(Motorcycle item)
        {
            Log.Information($"Update moto:id= {item.Id }");
        }
        public void Delete(int id)
        {
            try
            {
                var moto = GetMotorcycle(id);
                Log.Information($"Moto id= {moto.Id} is deleted");
                _motorcycles.Remove(moto);
            }
            catch (MotorcycleNotFoundException ex)
            {
                Log.Error(ex.StackTrace + " " + ex.Message + " " + ex.Data);
                return;
            }
        }
    }
}
