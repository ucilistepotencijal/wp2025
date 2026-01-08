using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebShopDAL;

namespace WebShopDal
{
    internal class Proizvodi : CollectionBase
    {
        public int Add(Proizvodi proizvod)
        {
            return InnerList.Add(proizvod);
        }

        public void Remove(Proizvodi proizvod)
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
