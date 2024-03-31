using Inheritance.Models;

namespace Inheritance
{
    internal class Program
    {
        static void Main()
        {
            Device device= new Device(10,20,30);
            device.OpenDevice();
            device.OpenDevice();
            device.OpenDevice();
            device.CloseDevice();
            device.CloseDevice();
            device.CloseDevice();
            Mobile mobile = new Mobile(10,20,30,"5");
            mobile.AddSimCard("0502030124");
            mobile.AddSimCard("0556775775");
            mobile.AddSimCard("0502020202");
            mobile.ShowArray();
            mobile.GetNumbers("0502030124");
            mobile.RemoveNumb("0502030124");
            mobile.ShowArray();

        }
    }
}
