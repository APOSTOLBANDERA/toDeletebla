using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    public class Worker
    {
        public string Surname { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public double SalaryPerDay { get; set; }
        public bool IsOfficial { get; set; }
        public double SalaryPerMonth
        {
            get
            {
                if (IsOfficial)
                {
                    return (SalaryPerDay * 30) - ((SalaryPerDay * 30) * 19.5) / 100;
                }
                else
                {
                    return (SalaryPerDay * 30);
                }
            }
        }
        public bool IsPension
        {
            get
            {
                if(Age > 60)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public Worker(string surname, string name, int age, double salaryPerDay, bool isOfficial)
        {
            Surname = surname;
            Name = name;
            Age = age;
            SalaryPerDay = salaryPerDay;
            IsOfficial = isOfficial;
        }
        public override string ToString()
        {
            return $"Surname: {Surname}, Name: {Name}, Age: {Age}, Salary Per Day: {SalaryPerDay}, IsOfficial: {IsOfficial}, Salary Per Month: {SalaryPerMonth}, IsPension: {IsPension}";
        }
    }
}
