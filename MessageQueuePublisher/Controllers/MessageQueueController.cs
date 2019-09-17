using MessageQueuePublisher.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace MessageQueuePublisher.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MessageQueueController : ControllerBase
    {
        public MessageQueueController(IQueueRouting queueRouting)
        { }

        // GET api/values
        [HttpGet]
        public ActionResult<bool> TestQueueACK(string message)
        {
            return true;
        }

        // GET api/values
        [HttpGet]
        public ActionResult<bool> TestQueue(string message)
        {
            return true;
        }
    }
}