namespace SolidSample.ISP.Bad
{
    public class TeamLead : ILead
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
