using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage_1._0.UI
{
    internal interface IUserInterface
    {

        public void DisplayMenu();
        void ListAllVehicles();

        void ListVehicleTypesAndCounts();
        void AddVehicle();
        void RemoveVehicle();
        void SearchVehicle();
        public void CreateNewGarage();

    }
}
