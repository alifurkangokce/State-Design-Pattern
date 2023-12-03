using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateDesignPattern
{
    public class OffState : ILightState
    {
        // Lambayı açma metodu
        public void TurnOn()
        {
            Console.WriteLine("Lamba açılıyor.");
        }

        // Lamba zaten kapalı olduğunda çağrılan metot
        public void TurnOff()
        {
            Console.WriteLine("Lamba zaten kapalı.");
        }

        // Lambanın parlaklığını arttırma metodu (kapalı durumda parlaklık arttırılamaz)
        public void Brighten()
        {
            Console.WriteLine("Lamba parlaklığı arttırılamaz, lamba kapalı.");
        }
    }
}
