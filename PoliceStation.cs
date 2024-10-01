using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice1
{
    internal class PoliceStation
    {
        private bool activeAlarm;
        public List<PoliceCar> PoliceCarsList { get; private set; }

        public PoliceStation()
        {
            activeAlarm = false;
            PoliceCarsList = new List<PoliceCar>();
        }

        public void NotifyPlate()
        {
            if (activeAlarm)
            {
                foreach (PoliceCar PoliceCar in PoliceCarsList)
                {

                }
            }

            else
            {

            }
        }
    }
}
