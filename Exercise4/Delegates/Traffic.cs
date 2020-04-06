using System;
using System.Collections.Generic;
using System.Text;

namespace Delegates
{
    class Traffic
    {
        public Traffic(Car car)
        {
            // Add itself as a subscriber
            car.OnSpeed += Warning;
        }
        // Traffic will call the method Warning when the car speed exceeds
        // the safety speed
        private void Warning(Object sender, ExcessSpeedEventArgs e)
        {
            // Current speed
            float speed = ((Car)sender).Speed;
            Console.WriteLine("Your speed is " + speed +
            ". Warning! The safety speed is " + (speed - e.ExcessSpeed) + "!!!");
        }
    }
}
