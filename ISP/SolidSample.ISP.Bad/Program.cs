using SolidSample.ISP.Bad;

var teamLeader = new TeamLead();
teamLeader.AssignTask();
teamLeader.CreateSubTask();
teamLeader.WorkOnTask();


var manager = new Manager();
manager.AssignTask();
manager.CreateSubTask();

// This behavior does not make sense. The Manager was forced to implement this behavior. Perhaps will throw an exception.
try
{
    manager.WorkOnTask();
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}