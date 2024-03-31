namespace Inheritance.Models
{
    //Width, Height, Weight field-ları olur.
    internal class Device
    {
        public int Width;   
        public int Height;
        public int Weight;
        public bool IsOpen;
        public Device(int width, int height, int weight)
        {

            Width = width;
            Height = height;
            Weight = weight;


        }
        public void OpenDevice()
        {
            if (!IsOpen)
            {
                IsOpen = true;
                Console.WriteLine("Device Opening...");
            }
            else
            {
                Console.WriteLine("Device Already Opened...");
            }
        }
        public void CloseDevice()
        {
            if (IsOpen)
            {
                IsOpen = false;
                Console.WriteLine("Device Closing...");
            }
            else
            {
                Console.WriteLine("Device Already Closed...");
            }
        }

        
    }
}
