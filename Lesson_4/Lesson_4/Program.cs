using System;

namespace Lesson_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //test Creator
           var building0 = Creator.CreateBuild(10,3,0,10);
           var building1 = Creator.CreateBuild(15, 3, 5, 300);

            Console.WriteLine(
                $"Number {building0.GetId()}\n" +
                $"Heigh {building0.Height}\n" +
                $"Entrance {building0.Entrancies}\n" +
                $"Floors {building0.Floors}\n" +
                $"Flats {building0.Flats}\n" +
                $"FloorHeight {building0.GetHeightOfFloor()}\n" +
                $"Flats per Enter {building0.GetNumberOfFlatsPerEntrancies()}\n" +
                $"Flats per floor {building0.GetNumberOfFlatsPerFloor()}");
            Console.WriteLine();
            
            Console.WriteLine(
                $"Number {building1.GetId()}\n" +
                $"Heigh {building1.Height}\n" +
                $"Entrance {building1.Entrancies}\n" +
                $"Floors {building1.Floors}\n" +
                $"Flats {building1.Flats}\n" +
                $"FloorHeight {building1.GetHeightOfFloor()}\n" +
                $"Flats per Enter {building1.GetNumberOfFlatsPerEntrancies()}\n" +
                $"Flats per floor {building1.GetNumberOfFlatsPerFloor()}");
        }
    }
}
