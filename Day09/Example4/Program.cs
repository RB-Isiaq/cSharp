using Example4;

MyTask task = new MyTask();
task.Id = "1";
task.Name = "Go Visit";
task.Description = "Go Visit an Old school friend in my Neighbourhood";

ShowTasks(task);

static void ShowTasks(MyTask kk)
{
    Console.WriteLine($"Task Id is { kk.Id }" );
    Console.WriteLine($"Task Name is { kk.Name }" );
    Console.WriteLine($"Task Description is { kk.Description }" );
}
