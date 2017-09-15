using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Vehicle
    {
        //Fields
        protected int seats;
        protected int carryingCapacity;
        protected string color;
        protected double movementSpeed;
        protected double distancedTraveled;



        private float gearRatio;
        private float engineSize;

        //Properties
        public int Seats
        {
            get { return this.seats; }
        }
        public int CarryingCapacity
        {
            get { return this.carryingCapacity; }
        }

        public string Color
        {
            get { return this.color; }
            set { this.color = value; }
        }

        public double DistanceTraveled
        {
            get { return this.distancedTraveled; }
        }

        //Constructors
        public Vehicle()
        {

        }

        public Vehicle(int seats, int carryingCapacity, string color, double movementSpeed)
        {
            this.seats = seats;
            this.carryingCapacity = carryingCapacity;
            this.color = color;
            this.movementSpeed = movementSpeed;

            distancedTraveled = 0.0d;
        }

        //Methods 
        public virtual void Move() //the virtual keyword gives the derived class the option to override the specific method
        {
            distancedTraveled += movementSpeed;
        }

        public virtual string GetDistanceTraveled()
        {
            return "Distance Traveled: " + distancedTraveled + "/n";
        }
    }
}
