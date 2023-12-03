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
        private ILightState currentState = new OffState(); // Şuanki durumu tutan değişken

        // Başlangıç durumu olarak lambanın kapalı olduğunu belirten constructor

        // Durumu değiştiren metot
        public void SetState(ILightState state)
        {
            currentState = state;
        }

        // Lambayı açan metot
        public void TurnOn()
        {
            currentState.TurnOn(this);
        }

        // Lambayı kapatan metot
        public void TurnOff()
        {
            currentState.TurnOff(this);
        }

        // Lambanın parlaklığını arttıran metot
        public void Brighten()
        {
            currentState.Brighten(this);
        }
    }
}
