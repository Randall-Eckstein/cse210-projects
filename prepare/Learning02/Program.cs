using System;
namespace Learning02;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job("Better Butter Buyers", "Sales Assosciate", 1974, 1985);


        Job job2 = new Job("Tim's Duck Pond", "Senior Shooter", 1986, 0);

        List<Job> jobs = new List<Job>(){job1, job2};

        Resume resume = new Resume("Sexy Samantha", jobs);

        resume.Display();
    }
}