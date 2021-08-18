using System;

namespace ZooManagement
{
    public class Zoo
    {
        public Cage[] CageList = new Cage[0];

        public void AddCage()
        {
            Cage mycage = new Cage();
            Array.Resize(ref CageList, CageList.Length + 1);
            CageList[CageList.Length - 1] = mycage;
            mycage.CageNumber = Array.IndexOf(CageList, mycage) + 1;
        }

        public void RemoveCage()
        {
            Console.Write("Enter cage number: ");
            int cage = int.Parse(Console.ReadLine());
            int position = -1;
            for (int i = 0; i < CageList.Length; i++)
            {
                if (CageList[i].CageNumber == cage)
                {
                    position = i;
                    break;
                }
            }
            if (position == -1)
            {
                Console.WriteLine("Not found");
            }
            else
            {
                for (int i = position; i < CageList.Length - 1; i++)
                {
                    CageList[i] = CageList[i + 1];
                }
                Array.Resize(ref CageList, CageList.Length - 1);
            }

        }

        public void ShowZooInfo()
        {
            Console.WriteLine("Zoo information");
            foreach (Cage cage in CageList)
            {
                Console.WriteLine($"Cage: {cage.CageNumber}");
                cage.IterateAnimal();
            }
        }
    }
}