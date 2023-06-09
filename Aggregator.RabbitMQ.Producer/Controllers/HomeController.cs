using System.Text;
using Aggregator.RabbitMQ.Producer.Services;
using Microsoft.AspNetCore.Mvc;
using RabbitMQ.Client;

namespace Aggregator.RabbitMQ.Producer.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        [HttpPost]
        public IActionResult SendMessage()
        {
            //using var connection = _rabbitMqService.CreateChannel();
            using var connection = RabbitMqService.CreateChannel();
            using var model = connection.CreateModel();
            var body = Encoding.UTF8.GetBytes("Hi, I was waiting in queue");
            model.BasicPublish("ListAmExchange",
                                 string.Empty,
                                 basicProperties: null,
                                 body: body);

            return Ok();
        }
    }
}
