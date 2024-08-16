namespace ReactTodoApp.Server.Model
{
    public class TodoItem
    {
        public Guid Id { get; set; }
        public string Task { get; set; }
        public bool IsCompleted { get; set; }

        public TodoItem(string task)
        {
            Id = Guid.NewGuid();
            Task = task;
            IsCompleted = false;
        }

        public TodoItem()
        {
            
        }
    }
}
