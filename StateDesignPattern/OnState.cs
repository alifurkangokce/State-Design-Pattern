using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateDesignPattern
{
    public class OnState : ILightState
    {

        // Lamba zaten açık olduğunda çağrılan metod

        public void TurnOn(LightContext context)
        {
            
            Console.WriteLine("Lamba zaten açık.");
            
            
        }

        // Lambayı kapatma metodu
        public void TurnOff(LightContext context)
        {
            Console.WriteLine("Lamba kapatılıyor.");
            context.SetState(new OffState());
            
        }

        // Lambanın parlaklığını arttırma metodu
        public void Brighten(LightContext context)
        {
            Console.WriteLine("Lamba parlaklığı arttırılıyor.");
        }
    }
}
