using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateDesignPattern
{
    public interface ILightState
    {

        // Lambayı açma operasyonu
        void TurnOn(LightContext context);

        // Lambayı kapatma operasyonu
        void TurnOff(LightContext context);

        // Lambanın parlaklığını arttırma operasyonu
        void Brighten(LightContext context);
    }
}
