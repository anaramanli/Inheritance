namespace Inheritance.Models
{
    internal class Mobile : Device
    {
        public string[] SimCards = new string[2];
        public int SimCardCount;
        public string Simcard;

        public Mobile(int width, int height, int weight, string simcard) : base(width, height, weight)
        {
            Simcard = simcard;
        }

        public void AddSimCard(string newSimCard)
        {
            if (SimCardCount < 2)
            {
                SimCards[SimCardCount] = newSimCard;
                SimCardCount++;
                Console.WriteLine("Sim Card added: " + newSimCard);
            }
            else
            {
                Console.WriteLine("Maximum number of SIM cards reached. Cannot add more.");
            }
        }

        public void RemoveNumb(string delnum)
        {
            string[] newSimCards = new string[SimCards.Length - 1];
            int j = 0;
            bool found = false;
            for (int i = 0; i < SimCards.Length; i++)
            {
                if (SimCards[i] != delnum)
                {
                    newSimCards[j] = SimCards[i];
                    j++;
                }
                else
                {
                    Console.WriteLine("Number Deleted:" + delnum);
                    found = true;

                }

            }

            if (!found)
            {
                Console.WriteLine("Number not found");
            }

            SimCards = newSimCards;
        }

        public void GetNumbers(string searchednum)
        {
            bool found = false;
            for (int i = 0; i < SimCards.Length; i++)
            {
                if (SimCards[i] == searchednum)
                {
                    Console.WriteLine("Number Found:" + searchednum);
                    found = true;
                    break;
                }
            }

            if (!found)
            {
                Console.WriteLine("Number not found");
            }
        }
        public void ShowArray()
        {
            Console.WriteLine("SIM Cards:");
            foreach (string simCard in SimCards)
            {
                Console.WriteLine(simCard);
            }
        }
    }
}