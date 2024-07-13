using CrudApp.Data;
using CrudApp.Models;
using Microsoft.EntityFrameworkCore;

public class ToDoService
{
    private readonly AppDbContext _dbContext;

    public ToDoService(AppDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<List<ToDoItem>> GetToDoItemsAsync()
    {
        return await _dbContext.ToDoItems.ToListAsync();
    }

    public async Task AddToDoItemAsync(ToDoItem item)
    {
        _dbContext.ToDoItems.Add(item);
        await _dbContext.SaveChangesAsync();
    }

    public async Task UpdateToDoItemAsync(ToDoItem item)
    {
        _dbContext.ToDoItems.Update(item);
        await _dbContext.SaveChangesAsync();
    }

    public async Task DeleteToDoItemAsync(ToDoItem item)
    {
        _dbContext.ToDoItems.Remove(item);
        await _dbContext.SaveChangesAsync();
    }
}
