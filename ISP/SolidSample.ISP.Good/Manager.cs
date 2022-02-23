namespace SolidSample.ISP.Good
{
    public class Manager : ILead
    {
        public void AssignTask()
        {
            Console.WriteLine("Manager assigned a task!");
        }

        public void CreateSubTask()
        {
            Console.WriteLine("Manager created a sub task!");
        }
    }
}
