namespace SolidSample.ISP.Good
{
    public class TeamLead : IProgrammer, ILead
    {
        public void AssignTask()
        {
            Console.WriteLine("TeamLead assigned a task!");
        }

        public void CreateSubTask()
        {
            Console.WriteLine("TeamLead created a sub task!");
        }

        public void WorkOnTask()
        {
            Console.WriteLine("TeamLead working on a task!");
        }
    }
}
