using System.Threading.Tasks;

namespace ServerManagement.Models
{
    public class TasksRepository
    {
        private static List<ToDoTask> _tasks = [
            new() {Id = 1, Name = "Item 1", },
            new() {Id = 2, Name = "Item 2", },
            new() {Id = 3, Name = "Item 3", },
            new() {Id = 4, Name = "Item 4", },
            new() {Id = 5, Name = "Item 5", },];

        public static void AddTask()
        {
            var maxId = _tasks.Max(t => t.Id);
            _tasks.Add(new() { Id = maxId + 1 });
        }

        public static List<ToDoTask> GetTasks() 
        {
            return _tasks.OrderByDescending(task => task.Completed).ThenByDescending(t => t.Id)
                        .GroupBy(task => task.IsCompleted)
                        .OrderBy(group => group.Key) // Group with true (completed) first, then false
                        .SelectMany(group => group).ToList(); // Flatten the grouped items
        }
    }
}
