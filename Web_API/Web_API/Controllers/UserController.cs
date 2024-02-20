using Microsoft.ApplicationInsights.Extensibility.Implementation;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Web_API.BLL;
using Web_API.DAL;
using Web_API.Models;
using Web_API.Models.List;

namespace Web_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IConfiguration _config; // Import the _configaration JWT
        public readonly HRMContext _context; // import the EF context class
        public readonly ILogger<UserController> _logger;
        public UserController(IConfiguration config, HRMContext context , ILogger<UserController> logger)
        {
            _logger = logger;
            _config = config;
            _context = context;
        }
       

        [HttpPost("Notice")] // Input ID 
        [HttpPost("NoticeGet")]  // get user detail url
        public IActionResult Notice(EmpWorkInfo user)
        {
            _logger.LogInformation("Notice Page");
            try
            {
                int User_ID = Convert.ToInt32(user.EmpId);
                var userWork_Info = _context.EmpWorkInfo.Where(u => u.EmpId == User_ID).FirstOrDefault(); // check the werk_info tabel position id and athe

                NoticeListView notice = new NoticeListView();

                if (userWork_Info != null)
                {
                    notice = User_BLL.Get_Notice(Convert.ToInt32(user.EmpId), Convert.ToInt32(userWork_Info.PId), Convert.ToInt32(userWork_Info.DId));

                    return Ok(notice.Notice);

                }
                else
                {
                    return Ok("Failure");
                }
            }
            catch (Exception ex)
            {

                _logger.LogError( "This Exception From Notice Page", ex);
            }           
                Log.CloseAndFlush();
                return Ok("Failure");
        }

        //Get the user todo list
        [HttpPost("UserTodoList")] // return the user to do lists wating 
        public IActionResult getwatingtodo(EmpToDoList todolist)
        {
            int UserID = Convert.ToInt32(todolist.EmpId);
            var usertodolist = _context.Pass.Where(x => x.EmpId == UserID).FirstOrDefault();
            int wating = 1; // states is wating

            ToDoListView emptodolist = new ToDoListView();

            if(usertodolist != null)
            {
                emptodolist = User_BLL.Get_Emp_TodoList(UserID, wating);

                return Ok(emptodolist.EmpToDoList);
            }
            else
            {
                return Ok("Failure");
            }
        }

        [HttpPost("UserTodoComplite")] // return the user to do lists complite
        public IActionResult getCompliteToDoList(EmpToDoList todolist)
        {
            int UserID = Convert.ToInt32(todolist.EmpId);
            var usertodolist = _context.Pass.Where(x => x.EmpId == UserID).FirstOrDefault();
            int wating = 2; // states is wating

            ToDoListView emptodolist = new ToDoListView();

            if (usertodolist != null)
            {
                emptodolist = User_BLL.Get_Emp_TodoList(UserID, wating);

                return Ok(emptodolist.EmpToDoList);
            }
            else
            {
                return Ok("Failure");
            }
        }

        [AllowAnonymous]
        [HttpPost("LoginUser")] // login user url 
        [HttpPost("LoginGet")]  // get user detail url

        public IActionResult Login(Pass user)
        {
           
            int User_ID = Convert.ToInt32(user.EmpId);

            _logger.LogInformation("Login_By  " +  User_ID);
            try
            {
                
                int userIn = 1;
                int UserOut = Convert.ToInt32(user.LogInOut);
                
                

                var userAvailable = _context.Pass.Where(u => u.EmpId == User_ID && u.Pass1 == Get_Sha_Data(user.Pass1)).FirstOrDefault(); // check the Pass tabel user id and user password

               
               
                if (userAvailable != null)
                {

                        var checkUserLogin = _context.Pass.Where(x => x.EmpId == User_ID && x.LogInOut == userIn).FirstOrDefault();

                        if (checkUserLogin != null)
                        {
                            List<Position_Name> t_oder = new List<Position_Name>();
                            Position_Name dto = new Position_Name();



                            List<NoticeView> N_View = new List<NoticeView>();
                            NoticeView n_dto = new NoticeView();

                            //var userAvailable = _context.Pass.Where(u => u.EmpId == User_ID && u.Pass1 == Get_Sha_Data(user.Pass1)).FirstOrDefault(); // check the Pass tabel user id and user password

                            var userWork_Info = _context.EmpWorkInfo.Where(u => u.EmpId == User_ID).FirstOrDefault(); // check the werk_info tabel position id and athe


                            /*Get Position Name to show */
                            var userPostion = (from a in _context.EmpWorkInfo
                                               where a.EmpId == User_ID
                                               join p in _context.Position on a.PId equals p.PId
                                               select new
                                               {
                                                   PositionName = p.PositionName

                                               });
                            foreach (var item in userPostion)
                            {

                                dto.positionName = item.PositionName;
                                t_oder.Add(dto);
                            }
                            /*Get Position Name to show */

                            int position_ID = Convert.ToInt32(userWork_Info.PId); // set the position id 
                            int Department_ID = Convert.ToInt32(userWork_Info.DId); // set the department id

                            /*Get the notice to show web*/
                            var Notice = (from n in _context.NoticeView
                                          where n.EmpId == User_ID || n.PId == position_ID || n.DId == Department_ID
                                          select new
                                          {
                                              Notice_Titel = n.NTitel,
                                              Notice_body = n.NBody,

                                          }
                                          );

                            foreach (var item in Notice)
                            {
                                n_dto.NTitel = item.Notice_Titel;
                                n_dto.NBody = item.Notice_body;
                                N_View.Add(n_dto);

                            }

                            /*Get the notice to show web*/

                            int count = N_View.Count(); // count the how many notice have


                            if (userAvailable.Path != null) // check the image path pass tabel
                            {


                                return Ok(new JWTService(_config).GenerateToken(
                                userAvailable.EmpId.ToString(),
                                userAvailable.UserName,

                                dto.positionName,
                                userAvailable.Path,
                                n_dto.NTitel,
                                n_dto.NBody,
                                count.ToString()
                             ));
                            }
                            userAvailable.Path = "Uplode Image"; // set the null value to string 
                            return Ok(new JWTService(_config).GenerateToken(
                                  userAvailable.EmpId.ToString(),
                                  userAvailable.UserName,
                                  dto.positionName,
                                  userAvailable.Path,
                                  n_dto.NTitel,
                                  n_dto.NBody,
                                  count.ToString()
                               ));
                        


                        }
                        return Ok("already_login");
                  

                }
                else
                {
                    return Ok("User not found!");
                }

            }
            catch (Exception ex)
            {
                _logger.LogError("Login Error", ex); // Write the logs serilog system login errors
                Log.CloseAndFlush();
                return Ok("Failure");
            }
          
        }


       // [HttpPost("Notice")] // Input ID 
        [HttpPost("UserLogout")]  // get user detail url
        public IActionResult LogOut_User(Pass user)
       {
            int userID = Convert.ToInt32(user.EmpId); // thi is the Front end pass EmpId
            
            int UserOut = Convert.ToInt32(user.LogInOut) ;  // this is the Login Or Logout

            var checkUserLogin = _context.Pass.Where(x => x.EmpId == userID).FirstOrDefault(); // checked empid already hawe

            if (checkUserLogin != null) // checked
            {
                

                Pass Logout = new Pass();
                Logout.EmpId = userID;
                Logout.LogInOut = UserOut;  
                Logout.LastLDateTime =Convert.ToDateTime(DateTime.Now.ToString("hh:mm:ss tt"));  // Update the last login date pass tabel


                User_BLL.Update_User_Logout(Logout); // update the Pass Table LOG_IN_OUT
                return Ok("Success");
            }

            return Ok("already_login"); 

        }
        
        public static string Get_Sha_Data(string data) // Pass tabel password Hashed to SHA1 alogrithem 
        {
            SHA1 sha = SHA1.Create();
            Byte[] hasData = sha.ComputeHash(Encoding.Default.GetBytes(data));
            StringBuilder returnvalue = new StringBuilder();
            int i;
            for (i = 0; i < hasData.Length - 1; i++)
            {
                returnvalue.Append(hasData[i].ToString());

            }
            return returnvalue.ToString();
        }

        [HttpPost("userProfile")]
        public IActionResult UserProfile(EmpWorkInfo user) // list and return the user details
        {

            int UserID = Convert.ToInt32(user.EmpId);

            var User_Detail = _context.EmpInfo.Where(x => x.EmpId == UserID).FirstOrDefault();

            if(User_Detail != null)
            {
                User_Info_List dto = new User_Info_List();
                dto = User_BLL.User_Detail_Get(User_Detail.EmpId);

                return Ok(dto.uInfoList);
            }
            return Ok("Error");

        }

        [HttpPost("workProfile")]
        public IActionResult workProfile (EmpWorkInfo user) // List the user work info detail
        {
            int UserID = Convert.ToInt32(user.EmpId);
            var User_Work_Info = _context.EmpWorkInfo.Where(x => x.EmpId == UserID).FirstOrDefault();

            if(User_Work_Info != null)
            {
                User_Info_List dto = new User_Info_List();
                dto = User_BLL.Work_Detail_Get(User_Work_Info.EmpId);
                return Ok(dto.work_Info);
            }
            return Ok("Error");
        }

        [HttpPost("PassChange")]
        public IActionResult Change_Password (Pass user) //Change Password 
        {
            int UserId = Convert.ToInt32(user.EmpId);
            string Password = user.Pass1;

            var  user_chack = _context.Pass.Where(x => x.EmpId == UserId).FirstOrDefault();

            if(user_chack != null)
            {
                Pass changePass = new Pass();
                changePass.EmpId = UserId;
                changePass.Pass1 = Get_Sha_Data(Password);
                User_BLL.Change_Password(changePass);
                return Ok("Success");

            }
            return Ok("Error");

        }
        [HttpPut("InsertToDoList")]
        public IActionResult Insert_ToDoList(EmpToDoList ToDoList)
        {
            int userId = Convert.ToInt32(ToDoList.EmpId);
            int states = 1;

            var chackUser = _context.EmpToDoList.Where(x => x.EmpId == userId).FirstOrDefault();

            if(chackUser != null)
            {
                EmpToDoList add = new EmpToDoList();
                add.EmpId = userId;
                add.Note = ToDoList.Note;
                add.StartDate = DateTime.Now;
                add.EndDate = ToDoList.EndDate;
                add.Status = states;
                User_BLL.Add_ToDoList(add);
                return Ok("200");


            }
            return Ok("NotFound");
        }

    }
}
