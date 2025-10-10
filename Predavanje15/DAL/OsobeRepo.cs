using System;
using System.Buffers;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    // Remove one of the duplicate DohvatiOsobe method declarations to resolve ambiguity
    public class OsobeRepo
    {
        public static readonly List<Osoba> osobe;
        public static List<Osoba> DohvatiOsobe()
        {
            // Implementation here
            return osobe;
        }
    }

