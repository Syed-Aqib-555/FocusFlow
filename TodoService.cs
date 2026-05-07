using FocusFlow.Models;

namespace FocusFlow.Services
{
    public class TodoService
    {
        private readonly List<TodoTask> tasks = new();

        private int nextId = 1;

        public List<TodoTask> GetTasks()
        {
            return tasks;
        }

        public void AddTask(TodoTask task)
        {
            task.Id = nextId++;
            task.CreatedAt = DateTime.Now;

            tasks.Add(task);
        }

        public void DeleteTask(int id)
        {
            var task = tasks.FirstOrDefault(x => x.Id == id);

            if (task != null)
            {
                tasks.Remove(task);
            }
        }

        public void ToggleTask(int id)
        {
            var task = tasks.FirstOrDefault(x => x.Id == id);

            if (task != null)
            {
                task.IsCompleted = !task.IsCompleted;
            }
        }
    }
}