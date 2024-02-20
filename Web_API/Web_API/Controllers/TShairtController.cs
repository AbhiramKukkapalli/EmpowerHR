using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web_API.BLL;
using Web_API.Models;
using Web_API.Models.List;

namespace Web_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TShairtController : Controller
    {
        
        public readonly HRMContext _context; // import the EF context class
        public TShairtController(HRMContext context)
        {    
            _context = context;
        }

        [HttpGet]
        [Route("GetTStock")]
        public IActionResult Notice() // get the t_shirt all stock data
        {
            try
            {
                TStockList dto = new TStockList();
                dto = TShairt_BLL.GetStock();
                return Ok(dto.TStock_List); // retuen to tha data 
            }
            catch (Exception )
            {

                return Ok("Api Error");
            }
            
        }

        [HttpGet]
        [Route("TName")]
        public IActionResult T_Name() // lode tha t_shirt name and id 
        {
            try
            {
                Tshart_Name_Size name_size_dto = new Tshart_Name_Size();
                name_size_dto = TShairt_BLL.Get_T_Name();
                return Ok(name_size_dto.T_Name_List);
            }
            catch (Exception)
            {
                return Ok("Api Error");

            }

        }

        [HttpGet]
        [Route("TSize")]
        public IActionResult TSize() // lode thi t_shirt size and id
        {
            try
            {
                Tshart_Name_Size name_size_dto = new Tshart_Name_Size();
                name_size_dto = TShairt_BLL.Get_T_Size();
                return Ok(name_size_dto.T_Size_List);
            }
            catch (Exception)
            {
                return Ok("Api Error");   
            }
        }

        [HttpPost]
        [Route("GetMyStock")]
        public IActionResult Get_My_oder(EmpWorkInfo user)
        {
            int EmpId = Convert.ToInt32(user.EmpId);
            int Pending_Tshirt = 1;

            var userWork_Info = _context.EmpWorkInfo.Where(u => u.EmpId == EmpId).FirstOrDefault(); // check the werk_info tabel position id and athe

            if(userWork_Info != null)
            {
                TStockList dto = new TStockList();

                dto = TShairt_BLL.My_Oders(Convert.ToInt32(userWork_Info.EmpId), Convert.ToInt32(Pending_Tshirt));


                return Ok(dto.TStock_List);
            }
            else
            {
                return Ok("Error");
            }
   
        }
        [HttpPost]
        [Route("getNew")]
        public IActionResult GetNew(SaleTShirt user) 
        {
            // set the Fron end passing values to varible  Type of int values convert to 32 bit 
            int userId = Convert.ToInt32(user.EmpId); 
            int tName = Convert.ToInt32(user.TSNId);
            int tSize = Convert.ToInt32(user.TSSizeId);
            int quantity = Convert.ToInt32(user.Quantity);
            string ReciptNo = user.ResiptNo;
            int Oder_is_Online = 1; // thi is the ststic varible. oder is not procceing (2) is the proccessing method

            
            var get_branch = _context.EmpWorkInfo.Where(x => x.EmpId == userId).First(); // get the branch id 
            var get_Oder_Id = _context.TShirtStock.Where(x => x.TSNId == tName && x.TSSizeId == tSize).First(); // thi method get the TShirtStock ID to save. Its wont to delete or update this table and reduce the stock

            if (quantity == 0) 
            {
                return Ok("EmptyQUantity");
            }
            else
            {
                if(ReciptNo != null)
                {
                    if (get_Oder_Id != null)
                    {
                        SaleTShirt set = new SaleTShirt();
                        set.TSNId = tName;
                        set.TSSizeId = tSize;
                        set.EmpId = userId;
                        set.Date = DateTime.Now;
                        set.BId = get_branch.BId;
                        set.ResiptNo = ReciptNo;
                        set.States = Oder_is_Online;
                        set.Quantity = quantity;
                        set.OderId = get_Oder_Id.Id;
                        TShairt_BLL.Set_data(set);
                        return Ok("Success");

                    }
                    else
                    {
                        return Ok("Error");
                    }
                   
                }
                else
                {
                    return Ok("ReciptNumberEmpty");
                }
               
               
            }

           
        }
    }
}
