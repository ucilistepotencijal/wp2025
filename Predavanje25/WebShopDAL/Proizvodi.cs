using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebShopDAL
{
    public class Proizvodi : CollectionBase
    {
        public int Add(Proizvod proizvod)
        {
            return InnerList.Add(proizvod);
        }

        public void Remove(Proizvod proizvod)
        {
            InnerList.Remove(proizvod);
        }

        public object this[int index]
        {
            get
            {
                return (Proizvod)InnerList[index];
            }

        }
    }
}
