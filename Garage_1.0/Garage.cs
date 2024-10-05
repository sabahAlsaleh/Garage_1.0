using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Garage_1._0.vehicle;

namespace Garage_1._0
{
    // The class implements the IEnumerable<T> interface to enable iteration over  collection of vehicles

    public class Garage <T> :IEnumerable<T>  where T : Vehicle
    {
        private T[] vehicles;
        private int capacity;
        private int count;

        public Garage(int capacity)
        {
            this.capacity = capacity;
            vehicles  = new T[capacity];
            count = 0 ;
        }

        public bool Park(T vehicle)
        {
            if (count < capacity)
            {
                vehicles[count++] = vehicle;
                return true ;
            }
            return false;
        }

        public bool Remove(string registrationNumber)
        {
            for (int i = 0; i < count; i++)
            {
                if (vehicles[i].RegistrationNumber == registrationNumber)
                {
                    // replace the  vehicle with the matching registration number with the last vehicle in the array to remove it and reduce count 
                    vehicles[i] = vehicles[--count];

                    return true;
                }
            }
            return false;
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < count; i++)
            {
                yield return vehicles[i];
            }
        }

        // Implementerar den icke-generiska versionen av IEnumerable
        // och skickar vidare till den generiska versionen av GetEnumerator().
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

    }


}
