using System;

namespace Fan
{
    public class MyFan
    {
        public int slow;
        public int medium;
        public int fast;

        private int speed;
        private bool onOff;
        private double radius;
        private string color;

        // public int getSlow()
        // {
        //     return this.slow;
        // }

        // public void setSlow(int slow)
        // {
        //     this.slow = slow;
        // }

        // public int getMedium()
        // {
        //     return this.medium;
        // }

        // public void setMedium(int medium)
        // {
        //     this.medium = medium;
        // }

        // public int getFast()
        // {
        //     return this.fast;
        // }

        // public void setFast(int fast)
        // {
        //     this.fast = fast;
        // }

        // public int getSpeed()
        // {
        //     return this.speed;
        // }

        // public void setSpeed(int speed)
        // {
        //     this.speed = speed;
        // }

        // public bool isOnOff()
        // {
        //     return this.onOff;
        // }

        // public void setOnOff(bool onOff)
        // {
        //     this.onOff = onOff;
        // }

        // public double getRadius()
        // {
        //     return this.radius;
        // }

        // public void setRadius(double radius)
        // {
        //     this.radius = radius;
        // }

        // public string getColor()
        // {
        //     return this.color;
        // }

        // public void setColor(string color)
        // {
        //     this.color = color;
        // }




        public MyFan()
        {

        }

        public int Speed
        {
            set => speed = value; 
            get => speed;
        }

        public bool OnOff
        {
            set => onOff = value; 
            get => onOff;
        }

        public double Radius
        {
            set => radius = value; 
            get => radius;
        }


        public string Color
        {
            set => color = value; 
            get => color;
        }

        public void tostring()
        {
            if(onOff == true)
            {
                Console.WriteLine($"fan is on: speed: {speed} color: {color} radius: {radius}");
            }
            else
            {
                Console.WriteLine($"fan is off: speed: {speed} radius: {radius} color: {color}");
            }
        }
    }
}