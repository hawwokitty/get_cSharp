using SimpleTodoApp.Model;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

var inMemoryDb = new List<TodoItem>
{
    new TodoItem("Chores"),
    new TodoItem("Work")
};

app.MapGet("/todoapp", () =>
{
    return inMemoryDb;
});

app.Run();
