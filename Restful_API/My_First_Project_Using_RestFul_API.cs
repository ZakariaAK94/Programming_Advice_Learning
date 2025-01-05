using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MyFirstProjectRestfulAPI.Controllers
{
    //[Route("api/[controller]")]
    [Route("api/MyFirstAPI")]
    [ApiController]
    public class MyFirstAPIController : ControllerBase
    {
        [HttpGet("koko1",Name="MyName")]
        public string GetMyName()
        {
            return "My name is Zakaria AKIL";
        }

        [HttpGet("koko2",Name ="YourName")]
        public string GetYourName()
        {
            return "Your name is Mohammad Abu Hadhoud";
        }


        [HttpGet("sum/{num1},{num2}")]
        public int Sum2Nbrs(int num1,int num2)
        {
            return num1+num2;
        }
        [HttpGet("multi/{num1},{num2}")]
        public int Multi2Nbrs(int num1,int num2)
        {
            return num1*num2;
        }

    }
}
