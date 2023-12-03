using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateDesignPattern
{
    // Lambanın durumlarını yöneten sınıf
    public class LightContext
    {
        private ILightState currentState; // Şuanki durumu tutan değişken

        // Başlangıç durumu olarak lambanın kapalı olduğunu belirten constructor
        public LightContext()
        {
            currentState = new OffState();
        }

        // Durumu değiştiren metot
        public void SetState(ILightState state)
        {
            currentState = state;
        }

        // Lambayı açan metot
        public void TurnOn()
        {
            currentState.TurnOn();
        }

        // Lambayı kapatan metot
        public void TurnOff()
        {
            currentState.TurnOff();
        }

        // Lambanın parlaklığını arttıran metot
        public void Brighten()
        {
            currentState.Brighten();
        }
    }
}
