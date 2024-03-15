using System;


namespace C__HW_modul_05
{
    public class Journal
    {
        public string Title { get; set; }
        public string Owner { get; set; }
        public int _employees { get; set; }

        public Journal(int employes) { _employees = employes; }
        public Journal() { }

        public static Journal operator +(Journal journal, int numEmployees)
        {
            journal._employees += numEmployees;
            return journal;
        }

        public static Journal operator -(Journal journal, int numEmployees)
        {
            journal._employees = numEmployees;
            return journal;
        }

        public static bool operator ==(Journal journal1, Journal journal2)
        {
            return journal1._employees == journal2._employees;
        }

        public static bool operator !=(Journal journal1, Journal journal2)
        {
            return !(journal1 == journal2);
        }

        public static bool operator <(Journal journal1, Journal journal2)
        {
            return journal1._employees < journal2._employees;
        }

        public static bool operator >(Journal journal1, Journal journal2)
        {
            return journal1._employees > journal2._employees;
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;

            Journal other = (Journal)obj;
            return _employees == other._employees;
        }
    }
}
