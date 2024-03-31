namespace Inheritance.Models
{
    /*PortCount field-ı var.*/
    internal class Laptop : Device
    {
        public int PortCount;

        public Laptop(int width,int height , int weight, int portcount): base(width, height, weight)
        {
            PortCount = portcount;
        }
    }
}
