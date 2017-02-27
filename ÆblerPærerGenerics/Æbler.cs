using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ÆblerPærerGenerics
{
    public class Æbler : IComparable<Æbler>
    {
        public string Navn { get; set; }
        public decimal Pris { get; set; }
        public int Lager { get; set; }

        public override bool Equals(object obj)
        {

            Æbler æble = obj as Æbler;

            if (this.Navn == æble.Navn && this.Pris == æble.Pris)
                return true;
            else
                return false;
            //return base.Equals(obj);
        }
        public override int GetHashCode()
        {
            return this.Navn.GetHashCode() ^ this.Pris.GetHashCode() ^ this.Lager.GetHashCode();

        }

        public int CompareTo(Æbler other)
        {
            if (this.Pris < other.Pris)
                return -1;
            else if (this.Pris == other.Pris)
                return 0;
            else
                return 1;
            //throw new NotImplementedException();
        }

        private class sortLagerDown : IComparer<Æbler>
        {
            public int Compare(Æbler x, Æbler y)
            {
                if (x.Lager > y.Lager)
                    return 1;
                else if (x.Lager == y.Lager)
                    return 0;
                else
                    return -1;
                //throw new NotImplementedException();
            }
        }
        private class sortPriserUp : IComparer<Æbler>
        {
            public int Compare(Æbler x, Æbler y)
            {
                if (x.Pris < y.Pris)
                    return 1;
                else if (x.Pris == y.Pris)
                    return 0;
                else
                    return -1;
            }
        }

        private class sortPriserDown : IComparer<Æbler>
        {
            public int Compare(Æbler x, Æbler y)
            {
                if (x.Pris > y.Pris)
                    return 1;
                else if (x.Pris == y.Pris)
                    return 0;
                else
                    return -1;
            }
        }

        private class sortPriserogNavnDown : IComparer<Æbler>
        {
            public int Compare(Æbler x, Æbler y)
            {
                if (x.Pris > y.Pris)
                    return 1;
                else if (x.Pris == y.Pris)
                    return 0;
                else
                    return -1;
            }
        }

        public static IComparer<Æbler> sortLagerDescending()
        {
            return new sortLagerDown();
        }

        public static IComparer<Æbler> sortPrisAccending()
        {
            return new sortPriserUp();
        }
        public static IComparer<Æbler> sortPrisDescending()
        {
            return new sortPriserDown();
        }
        public override string ToString()
        {
            return $"Navn {this.Navn} pris {this.Pris} lager {this.Lager}";
        }
    }

}
