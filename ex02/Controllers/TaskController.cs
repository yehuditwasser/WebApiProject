using Microsoft.AspNetCore.Mvc;
using System.Runtime.CompilerServices;

namespace ex02.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TaskController : ControllerBase
    {
        private readonly ITaskService taskService;
        private readonly ILogger<TaskController> logger;

        public TaskController(ITaskService taskService, ILogger<TaskController> logger)
        {
            this.taskService = taskService;
            this.logger = logger;
        }

        [HttpGet("GetAllTask")]
        public List<Task1> getAllTask()
        {
            logger.LogInformation("get ");
            List<Task1> a=taskService.getAllTask();
            return a;
        }

        [HttpPost("AddNewTask")]
        public void addProduct(Task1 t)
        {
            logger.LogInformation("post ");

            taskService.addProduct(t);
        }

        [HttpPut("PutTaskById/{id}")]
        public void PutProductById(int id, string title, string description, DateTime date, preference p)
        {
            logger.LogInformation("put ");

            taskService.PutProductById(id, title, description, date, p);
        }

        [HttpDelete("DeleteTaskById{id}")]
        public void DeleteTaskById(int id)
        {
            logger.LogInformation("delete ");

            taskService.DeleteTaskById(id);
        }
    }
}