using Microsoft.AspNetCore.Mvc;
using test.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace test.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class CheckPrimeController : ControllerBase
    {
        Factorial fac = new Factorial();
        // GET: api/CheckPrime
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/CheckPrime/5
        [HttpGet("{number}")]
        public bool Get(int number)
        {
            var result = false;
            if (number > 0)
            {
                //สมการจากทฤษฎีบทของวิลสัน
                /*จำนวนเต็ม p > 1 เป็นจำนวนเฉพาะ ก็ต่อเมื่อ (p − 1) ! + 1 หารด้วย p ลงตัว (ทฤษฎีบทของวิลสัน) ยิ่งไปกว่านั้น จำนวนเต็ม n > 4 เป็นจำนวนประกอบ ก็ต่อเมื่อ (n− 1) ! หารด้วย n ลงตัว*/
                if ((fac.factorialcal(number - 1) + 1) % number == 0)
                {
                    if (!(fac.factorialcal(number - 1) % number == 0))
                    {
                        result = true;
                    }
                }
            }
            return result;
        }

        //// POST api/CheckPrime/CheckPrimeNumber
        //[HttpPost("CheckPrimeNumber")]
        //public bool Post(int number)
        //{
        //    var result = false;
        //    if (number > 0)
        //    {
        //        //สมการจากทฤษฎีบทของวิลสัน
        //        /*จำนวนเต็ม p > 1 เป็นจำนวนเฉพาะ ก็ต่อเมื่อ (p − 1) ! + 1 หารด้วย p ลงตัว (ทฤษฎีบทของวิลสัน) ยิ่งไปกว่านั้น จำนวนเต็ม n > 4 เป็นจำนวนประกอบ ก็ต่อเมื่อ (n− 1) ! หารด้วย n ลงตัว*/
        //        if ((fac.factorialcal(number - 1) + 1) % number == 0)
        //        {
        //            if (!(fac.factorialcal(number - 1) % number == 0))
        //            {
        //                result = true;
        //            }
        //        }
        //    }
        //    return result;
        //}

        // PUT api/<CheckPrimeController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<CheckPrimeController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
