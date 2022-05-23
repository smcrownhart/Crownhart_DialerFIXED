using System;

namespace Crownhart_DialerFIXED
{
    class Program
    {
        static void Main(string[] args)
        {
            //creating list
            Phone[] List = new Phone[10];
            List[0] = new HomePhone("CompuTest", "(303) 985-5060", 1);
            List[1] = new CellPhone("Curtis Manufacturing", "(603) 532-4123", 2);
            List[2] = new HomePhone("Data Functions", "(800) 876-2524", 1);
            List[3] = new HomePhone("Donnay Repair", "(708) 397-3330", 1);
            List[4] = new HomePhone("ErgoNomic Inc", "(360) 434-3894", 1);
            List[5] = new HomePhone("ErgoSource", "(800) 969-4374", 1);
            List[6] = new CellPhone("Fox Bay Industries", "(800) 874-8527", 2);
            List[7] = new CellPhone("Glare - Guard", "(800) 545-6254", 2);
            List[8] = new CellPhone("Hazard Comm Specialists", "(407) 783-6641", 2);
            List[9] = new CellPhone("Komfort Support", "(714) 472-4409", 2);

            //for loop to write the list and call up dial
            for (int i = 0; i < List.Length; i++)
            {
                Console.WriteLine(List[i].Dial());
            }
        }
    }
}
