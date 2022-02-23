namespace SolidSample.ISP.Bad
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

        public void WorkOnTask()
        {
            // We are forcing a manager to implement this method, even though it's not part of its features.
            throw new NotImplementedException("The managers don't work :) !");
        }
    }
}
