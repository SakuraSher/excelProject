using Microsoft.AspNetCore.Mvc;


    using Microsoft.AspNetCore.Mvc;
    using FileProcessingAPI.Models;
    using System.Collections.Generic;
using Task = System.Threading.Tasks.Task;

namespace FileProcessingAPI.Controllers
{
    [ApiController]
        [Route("api/[controller]")]
        public class TasksController : ControllerBase
        {
            private static List<Task> _tasks = new List<Task>();

            [HttpGet]
            public ActionResult<IEnumerable<Task>> GetTasks()
            {
                return Ok(_tasks);
            }

            // Implement other CRUD operations (POST, PUT, DELETE) here...
        }
    }

  

