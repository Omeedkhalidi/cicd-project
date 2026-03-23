var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

var tasks = new List<TaskItem>
{
    new(1, "Plugga CI/CD", false),
    new(2, "Testa Swagger", true)
};

app.MapGet("/", () => "API is running");

app.MapGet("/test", () => "swagger should work");

app.MapGet("/tasks", () => tasks);

app.MapGet("/tasks/{id}", (int id) =>
{
    var task = tasks.FirstOrDefault(t => t.Id == id);

    return task is not null
        ? Results.Ok(task)
        : Results.NotFound();
});

app.MapPost("/tasks", (TaskItem newTask) =>
{
    tasks.Add(newTask);
    return Results.Created($"/tasks/{newTask.Id}", newTask);
});

app.MapPut("/tasks/{id}", (int id, TaskItem updatedTask) =>
{
    var task = tasks.FirstOrDefault(t => t.Id == id);

    if (task is null)
        return Results.NotFound();

    task.Title = updatedTask.Title;
    task.IsDone = updatedTask.IsDone;

    return Results.Ok(task);
});

app.MapDelete("/tasks/{id}", (int id) =>
{
    var task = tasks.FirstOrDefault(t => t.Id == id);

    if (task is null)
        return Results.NotFound();

    tasks.Remove(task);
    return Results.NoContent();
});

app.Run();

class TaskItem
{
    public int Id { get; set; }
    public string Title { get; set; }
    public bool IsDone { get; set; }

    public TaskItem(int id, string title, bool isDone)
    {
        Id = id;
        Title = title;
        IsDone = isDone;
    }
}