using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using VozilkaAPP;

namespace VozilkaAPP
{
    internal class Automobili : CollectionBase
    {
        public int (Automobil auto)
        {
             return InnerList.Add(auto);
        }
       public void Remove(Automobil auto)
        {
            InnerList.Remove(auto);
        }
        public Automobil this[int index]
        {
            get
            {
                return (Automobil)InnerList[index];
            }

        }


    }

}