using ReactTodoApp.Server.Model;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

var inMemoryDb = new List<TodoItem>
{
    new TodoItem("Clean Kitchen"),
    new TodoItem("Eat shit")
};

app.MapGet("/todoapp", () =>
{
    return inMemoryDb;
});

app.Run();

