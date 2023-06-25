using Microsoft.AspNetCore.Mvc;
using API.Handlers;
using API.Models;

namespace API.Controllers;

[ApiController]
[Route("api")]
public class dataController : ControllerBase
{
    static DataHandler handler = new DataHandler();

    [HttpGet]
    [Route("getData")]
    public ActionResult GetData()
    {
        try
        {
            var data = handler.GetData();
            return Ok(data);
        }
        catch (Exception error)
        {
            Console.WriteLine(error);
            return BadRequest(error.Message);
        }
    }

    [HttpPost]
    [Route("setData")]
    public ActionResult SetData([FromBody] Data data)
    {
      Console.WriteLine(data.phoneNumber.ToString() + " " + data.firstKmCost.ToString() + " " + data.secondKmCost.ToString());
        try
        {
            handler.SetData(data.phoneNumber, data.firstKmCost, data.secondKmCost);
            return Ok("Data saved successfully");
        }
        catch (Exception error)
        {
            Console.WriteLine(error);
            return BadRequest(error.Message);
        }
    }
}
