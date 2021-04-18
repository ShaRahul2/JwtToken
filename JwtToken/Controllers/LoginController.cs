//using JwtToken.tokenclass;
//using Microsoft.AspNetCore.Mvc;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;

//// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

//namespace JwtToken.Controllers
//{
//    [Route("Api/Login")]
//    [ApiController]
//    public class LoginController : ControllerBase
//    {
//        // GET: api/<LoginController>
//        [HttpGet]
//        public IEnumerable<string> Get()
//        {
//            return new string[] { "value1", "value2" };
//        }

//        // GET api/<LoginController>/5
//        [HttpGet("{id}")]
//        public string Get(int id)
//        {
//            int UserId = new UserRepository().GetUser(username);
//            if (UserId == 0) return new ResponseVM { Status = "Invalid", Message = "Invalid User." };
//            string tokenUsername = TokenManager.ValidateToken(token);
//            if (username.Equals(tokenUsername))
//            {
//                return new ResponseVM
//                {
//                    Status = "Success",
//                    Message = "OK",
//                };
//            }
//            return new ResponseVM { Status = "Invalid", Message = "Invalid Token." };
//        }

//        // POST api/<LoginController>
//        [HttpPost]
//        public void Post([FromBody] string value)
//        {
//            var objlst = wmsEN.Usp_Login(objVM.UserName, UtilityVM.Encryptdata(objVM.Passward), "").ToList<Usp_Login_Result>().FirstOrDefault();
//            if (objlst.Status == -1)
//                return new ResponseVM { Status = "Invalid", Message = "Invalid User." };
//            //if (objlst.Status == 2)
//            //    return new ResponseVM { Status = "Invalid", Message = "Already Logged In." };
//            if (objlst.Status == 0)
//                return new ResponseVM { Status = "Inactive", Message = "User Inactive." };
//            else
//                return new ResponseVM { Status = "Success", Message = TokenManager.GenerateToken(objVM.UserName) };
//        }

//        // PUT api/<LoginController>/5
//        [HttpPut("{id}")]
//        public void Put(int id, [FromBody] string value)
//        {
//        }

//        // DELETE api/<LoginController>/5
//        [HttpDelete("{id}")]
//        public void Delete(int id)
//        {
//        }
//    }
//}
