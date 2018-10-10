using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlioOhjelmointiWpf
{
    public class Car
    {
        // kaksi ominaisuutta (property)
        public string Color { get; set; }
        public string Model { get; set; }

        // kenttä (field)
        public string DoorCount;

        private int maxSpeed;

        public int MaxSpeed {
            get
            {
                return maxSpeed;
            }
        set
            {
                if ((value > 0) && (value < 500))
                {
                    maxSpeed = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
        }

        public void StartEngine()
        {
        }
        public void StopEngine()
        {
        }
        
    }
}
