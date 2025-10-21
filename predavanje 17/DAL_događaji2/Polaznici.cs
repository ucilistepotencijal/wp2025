using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_događaji2
{
    public class Polaznici : CollectionBase
    {
        public int Add(Polaznik p)
        {
            return InnerList.Add(p);
        }

        public Polaznik this[int index]
        {
            get
            {
                return (Polaznik)InnerList[index];
            }
        }
    }
}
