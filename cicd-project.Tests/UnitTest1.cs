using Xunit;

namespace cicd_project.Tests;

public class UnitTest1
{
    [Fact]
    public void True_Should_Be_True()
    {
        Assert.True(true);
    }

    [Fact]
    public void Title_Should_Not_Be_Empty()
    {
        var title = "Plugga CI/CD";

        Assert.False(string.IsNullOrWhiteSpace(title));
    }

    [Fact]
    public void Task_Can_Be_Created()
    {
        var task = new TestTaskItem
        {
            Id = 1,
            Title = "Test task",
            IsDone = false
        };

        Assert.Equal(1, task.Id);
        Assert.Equal("Test task", task.Title);
        Assert.False(task.IsDone);
    }
}

public class TestTaskItem
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public bool IsDone { get; set; }
}