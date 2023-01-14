namespace Learning02
{
    public class Resume
    {
        public string _name { get; private set; }
        public List<Job> _jobs { get; private set; }

        public Resume(string name, List<Job> jobs)
        {
            this._name = name;
            this._jobs = jobs;
        }

        public void Display()
        {
            Console.WriteLine();
            Console.WriteLine($"Name: {_name}");
            Console.WriteLine("Jobs:");
            foreach (Job job in _jobs)
            {
                job.Display();
            }
        }
    }
}