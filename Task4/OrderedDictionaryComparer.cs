using System.Collections;

namespace Task4
{
    class OrderedDictionaryComparer : IEqualityComparer
    {
        public bool Equals(DictionaryEntry x, DictionaryEntry y)
        {
            if (x.Value != null && y.Value != null)
            {
                if (x.Value == y.Value)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public new bool Equals(object x, object y)
        {
            if (x != null && y != null)
            {
                if (x == y)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public int GetHashCode(DictionaryEntry obj)
        {
            return obj.Value.GetHashCode();
        }

        public int GetHashCode(object obj)
        {
            return obj.GetHashCode();
        }
    }
}