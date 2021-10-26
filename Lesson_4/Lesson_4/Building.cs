using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson_4
{
    public class Building
    {        
        private int id;
        private int height;
        private int floors;
        private int flats;
        private int entrancies;
        private static int lastId;

        public Building()
        {
            CreateId();
        }
        
        public int GetId()
        {
            return id;
        }

        public int Height
        {
            get
            {
                return height;
            }
            set
            {
                if (value > 0)
                {
                    height = value;
                }
            }
        }

        public int Floors
        {
            get
            {
                return floors;
            }
            set
            {
                if (value > 0)
                {
                    floors = value;
                }
            }
        }
        public int Flats
        {
            get
            {
                return flats;
            }
            set
            {
                if (value >= 0)
                {
                    flats = value;
                }
            }
        }
        public int Entrancies
        {
            get
            {
                return entrancies;
            }
            set
            {
                if (value > 0)
                {
                    entrancies = value;
                }
            }
        }
        public float GetHeightOfFloor()
        {
            if(floors > 0)
            {
                return height / floors;
            }
            else
            {
                return -1;
            }
        }
        public int GetNumberOfFlatsPerEntrancies()
        {
            if(entrancies >0)
            {
                return flats / entrancies;
            }
            else
            {
                return -1;
            }
        }

        public int GetNumberOfFlatsPerFloor()
        {
            if (floors > 0)
            {
                return flats / floors;
            }
            else
            {
                return -1;
            }             
        }

        private void CreateId()
        {
            id = lastId + 1;
            lastId = id;            
        }
    }
}
