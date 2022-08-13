using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ToDoFluentValidation.Models;

namespace ToDoFluentValidation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TasksController : ControllerBase
    {

        [HttpPost]
        public TaskItem Post(TaskItem model)
        {
            return model;
        }
    }
}
