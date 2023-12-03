using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateDesignPattern
{
    public class OnState : ILightState
    {
        // Lamba zaten açık olduğunda çağrılan metot
        public void TurnOn()
        {
            Console.WriteLine("Lamba zaten açık.");
        }

        // Lambayı kapatma metodu
        public void TurnOff()
        {
            Console.WriteLine("Lamba kapatılıyor.");
        }

        // Lambanın parlaklığını arttırma metodu
        public void Brighten()
        {
            Console.WriteLine("Lamba parlaklığı arttırılıyor.");
        }
    }
}
