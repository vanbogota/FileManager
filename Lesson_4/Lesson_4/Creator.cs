using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Lesson_4
{
    public class Creator
    {
        static Hashtable hashtable = new Hashtable();
        private Creator()
        {            
        }
       public static Building CreateBuild(int height)
        {
            Building newBuilding = new Building() { Height = height };
            hashtable.Add(newBuilding.GetId(), newBuilding);
            return newBuilding;
        }
       public static Building CreateBuild(int height, int floors)
        {
            Building newBuilding = new Building() { Height = height, Floors = floors };
            hashtable.Add(newBuilding.GetId(), newBuilding);
            return newBuilding;
        }
       public static Building CreateBuild(int height, int floors, int entrancies)
        {
            Building newBuilding = new Building()
            {
                Height = height,
                Floors = floors,
                Entrancies = entrancies
            };
            hashtable.Add(newBuilding.GetId(), newBuilding);
            return newBuilding;
        }
       public static Building CreateBuild(int height, int floors, int entrancies, int flats)
        {
            Building newBuilding = new Building() 
            { 
                Height = height, 
                Floors = floors,
                Entrancies = entrancies,
                Flats = flats
            };
            int id = newBuilding.GetId();
            hashtable.Add(id, newBuilding);
            return newBuilding;
        }

       public static void DeleteBuildFromBase(int id)
        {
            if(hashtable != null || hashtable.ContainsKey(id))
            {
                hashtable.Remove(id);
            }
            else
            {
                Console.WriteLine("Build is not exist");
            }
        }        
    }
}
