using System;
using System.Collections.Generic;
using System.Text;

namespace Delegates
{
    class Car
    {
        private float speed;
        private float safetySpeed;
        public Car(float safety)
        {
            speed = 0;
            safetySpeed = safety;
        }
        // Define read-only property for the speed
        public float Speed { get { return speed; } }
        // Define the event
        public event EventHandler<ExcessSpeedEventArgs> OnSpeed;
        // Define a method that rises the event
        protected virtual void OnExcessSpeed(ExcessSpeedEventArgs e)
        {
            // Copy the delegate reference to a temporary field
            // for thread security
            EventHandler<ExcessSpeedEventArgs> temp = OnSpeed;
            if (temp != null) // If there are registered subscribers,
                temp(this, e); // notify them
        }
        // Define a method that publishes the event
        public void Accelerate(float accelerate)
        {
            speed += accelerate;
            if (speed <= safetySpeed)
                return;
            // Constructs an object with additional information
            ExcessSpeedEventArgs e = new ExcessSpeedEventArgs();
            e.ExcessSpeed = speed - safetySpeed;
            // Notify the subscribers that the event occurred
            OnExcessSpeed(e);
        }
    }
}
