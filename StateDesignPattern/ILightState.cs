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
        void TurnOn();

        // Lambayı kapatma operasyonu
        void TurnOff();

        // Lambanın parlaklığını arttırma operasyonu
        void Brighten();
    }
}
