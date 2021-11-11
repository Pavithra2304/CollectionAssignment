using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobsDetails
{
    class Program
    {
       public static void Main(string[] args)
        {
            int count_job;
            Console.WriteLine("Please Enter the jobs do you want to Enter:");
            count_job = Convert.ToInt32(Console.ReadLine());
            List<Job> j1 = new List<Job>();
            int press = 0;

            for (int i = 0; i < count_job; i++)
            {
                Console.WriteLine("Enter the Job Details as follows:Role,Location,Experience,Salary");
                string job = Console.ReadLine();
                string[] job1 = job.Split(',');
                Job job_Details = new Job(job1[0], job1[1], int.Parse(job1[2]), double.Parse(job1[3]));
                j1.Add(job_Details);


            }
            Console.WriteLine("Press 1 for sorting based on Location:Press 2 for sorting based on Salary:");
            press = Convert.ToInt32(Console.ReadLine());
            JobFilter j = new JobFilter();
            List<Job> sort = new List<Job>();
            switch (press)
            {
                case 1:
                    Console.WriteLine("Please Enter the Location");
                    sort = j.findJob(j1, Console.ReadLine());
                    break;
                case 2:
                    Console.WriteLine("Enter the Salary:");
                    sort = j.findJob(j1, Convert.ToDouble(Console.ReadLine()));
                    break;

            }
            foreach (var item in sort)
            {
                Console.WriteLine(item);
            }

        }
    }
}
