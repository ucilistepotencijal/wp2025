using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebShopDAL
{
    public class Proizvodi: CollectionBase
    {
        public int Add(Proizvod p)
        {
            return InnerList.Add(p);
        }

        public void Remove(Proizvod p)
        {
            InnerList.Remove(p);
        }
        public Proizvod this[int index]
        {
            get
            {
                return (Proizvod)InnerList[index];
            }
        }
    }
}
