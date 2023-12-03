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

        public void TurnOn(LightContext context)
        {
            Console.WriteLine("Lamba açılıyor.");
            context.SetState(new OnState());
        }

        // Lamba zaten kapalı olduğunda çağrılan metot
        public void TurnOff(LightContext context)
        {
            
            Console.WriteLine("Lamba zaten kapalı.");
            
        }

        // Lambanın parlaklığını arttırma metodu (kapalı durumda parlaklık arttırılamaz)
        public void Brighten(LightContext context)
        {
            Console.WriteLine("Lamba parlaklığı arttırılamaz, lamba kapalı.");
        }
    }
}
