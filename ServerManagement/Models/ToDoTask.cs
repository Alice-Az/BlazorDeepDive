namespace ServerManagement.Models
{
    public class ToDoTask
    {
        public int Id { get; set; }
        public string Name { get; set; } = "New Task";
        private bool _isCompleted;
        public bool IsCompleted { get => _isCompleted; set
            {
                _isCompleted = value;
                if (value)
                {
                    Completed = DateTime.Now;
                }
            }
        }
        public DateTime? Completed { get; set; }
    }
}
