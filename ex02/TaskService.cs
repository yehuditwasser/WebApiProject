using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace ex02
{
    public class TaskService : ITaskService
    {
        public List<Task1> getAllTask()
        {
            return Tasks.tasks;
        }

        public void addProduct(Task1 t)
        {
            Tasks.tasks.Add(t);
        }

        public void PutProductById(int id, string title, string description, DateTime date, preference p)
        {
            Task1 t = Tasks.tasks.Find(e => e.Id == id);
            t.Title = title;
            t.Description = description;
            t.Date = date;
            t.MyPreference = p;
        }

        public void DeleteTaskById(int id)
        {
            Task1 t = Tasks.tasks.Find(e => e.Id == id);
            Tasks.tasks.Remove(t);
        }

    }
}
