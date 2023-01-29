using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks.Task5
{
    public class sale1
    {
        double salary = 0, bonus = 0;
        public void sale(double salary)
        {
            this.salary = salary;
            bonus = (salary * 20) / 100;
            double total = salary + bonus;
            Console.WriteLine("Salary is " + salary);
            Console.WriteLine("Bonus is " + bonus);
            Console.WriteLine("Total is " + total);
        }
    }
    class prod1 : sale1 
    {
        double salary = 0, bonus = 0;
        public void prod(double salary)
        {
            this.salary = salary;
            bonus = (salary * 10) / 100;
            double total = salary + bonus;
            Console.WriteLine("Salary is " + salary);
            Console.WriteLine("Bonus is " + bonus);
            Console.WriteLine("Total is " + total);
        }
    }
    internal class Task5b
    {
        
        
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter EmployeeID");
            int em = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Employee Name");
            string na=Console.ReadLine();
            Console.WriteLine("Enter gender");
            string ge=Console.ReadLine();
            Console.WriteLine("Enter Years of experience");
            int ye = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Salary");
            int sa = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the department\n1.Sales\n2.Production");
            int d=Convert.ToInt32(Console.ReadLine());
            prod1 obj= new();
            switch (d)
            {
                case 1:
                    Console.WriteLine("Employee ID " + em);
                    Console.WriteLine("Employee Name " + na);
                    Console.WriteLine("Gender " + ge);
                    Console.WriteLine("Years of Experience " + ye);
                    obj.sale(sa); 
                break;
                case 2:
                    Console.WriteLine("Employee ID " + em);
                    Console.WriteLine("Employee Name " + na);
                    Console.WriteLine("Gender " + ge);
                    Console.WriteLine("Years of Experience " + ye);
                    obj.prod(sa);
                    break;
                default:
                    Console.WriteLine("Enter valid department");
                    break;
            }
        }
    }
}
