using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    class institute
    {
        private string _CourseName;
        private decimal _Fees;

        public void setCourse(string cname, decimal fnum)
        {
            _CourseName = cname;
            _Fees = fnum;
        }
        public void getDiscount(decimal percentage, out decimal discount)
        {
             discount =percentage*10;
        }
        public void Updatefees(ref decimal fees, decimal discount)
        {
            fees -= discount;
        }
        public string GetCourseName()
        {
            return _CourseName;
        }
        public decimal GetCourseFees()
        {
            return _Fees;
        }

    }
    internal class Program
    {
       public static void Main(string[] args)
       {
            institute i = new institute();
            i.setCourse(".net",5000);
            string coursename =i.GetCourseName();
            decimal fees=i.GetCourseFees();

            Console.WriteLine($"Course name:{coursename}");
            Console.WriteLine($"Original course fees: {fees}");

            Console.WriteLine("Enter percentage: ");
            decimal.TryParse(Console.ReadLine(),out decimal percentage);

            i.getDiscount(percentage, out decimal discount);
            Console.WriteLine($"Discount: {discount}");
            i.Updatefees(ref fees,discount);
            Console.WriteLine($"After discount: {fees}");
            Console.ReadLine();
       }
    }
}
