using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobsDetails
{
    class Job
    {
        string role;
        string location;
        int exp;
        double salary;

        public Job(string role,string location,int exp,double salary)
        {
            this.Role = role;
            this.Location = location;
            this.Exp = exp;
            this.Salary = salary;
        }

        public string Role { get => role; set => role = value; }
        public string Location { get => location; set => location = value; }
        public int Exp { get => exp; set => exp = value; }
        public double Salary { get => salary; set => salary = value; }

        public override string ToString()
        {
            return string.Format("{0,15} {1,15} {2,15} {3,15} ", Role, Location, Exp, Salary);
        }
        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
