using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollegeEntities
{
    public class Room:IRoom
    {
        private string name;
        private int capacity;
        private string type;

        public Room(string name, int capacity, string type)
        {
            this.name = name;
            this.capacity = capacity;
            this.type = type;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }
        public int Capacity
        {
            get
            {
                return this.capacity;
            }
            set
            {
                this.capacity = value;
            }
        }
        public string Type
        {
            get
            {
                return this.type;

            }
            set
            {
                this.type = value;
            }

        }



    }
}
