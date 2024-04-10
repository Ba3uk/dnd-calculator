using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts.MainLogic
{
    public class Character
    {
        public int id { get; set; }
        public string name { get; set; }

        public Character(int id, string name)
        {
            this.id = id;
            this.name = name;
        }
    }
}
