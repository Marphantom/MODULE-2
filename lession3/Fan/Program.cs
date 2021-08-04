using System;

namespace Fan
{
    class Program
    {
        static void Main(string[] args)
        {
            MyFan fan1 = new MyFan();
            fan1.Speed = fan1.fast;
            fan1.Radius = 10;
            fan1.Color = "Yellow";
            fan1.OnOff = true;
            fan1.tostring();
        }
    }
}
