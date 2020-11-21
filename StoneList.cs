using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;

namespace FruitIshido
{
    [Serializable]
    public class StoneList: IEnumerable<Stone>
    {
        public List<Stone> stones;

        public List<Stone> Stones
        {
            get { return stones; }
            set { stones = value; }
        }

        public StoneList()
        {
            Stones = new List<Stone>();
        }

        // Methods to add stone to list
        public void AddStone(Stone p)
        {
            Stones.Add(p);            
        }

        // Methods to get stone by name
        public Stone GetStone(string name)
        {
            return stones.Where(i => i.Name == name).FirstOrDefault();             
        }

        public IEnumerator<Stone> GetEnumerator()
        {
            return stones.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return stones.GetEnumerator();
        }
    }
}
