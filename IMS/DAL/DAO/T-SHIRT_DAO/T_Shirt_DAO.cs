using DAL.DTO.T_SHIRT_DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DAO.T_SHIRT_DAO
{
    public class T_Shirt_DAO : HRMSContext
    {
        public static List<T_SHIRT_NAME> Get_t_name()
        {
            return db.T_SHIRT_NAMEs.ToList();
        }

        public static List<T_SHIRT_SIZE> Get_t_Size()
        {
            return db.T_SHIRT_SIZEs.ToList();
        }

        public static List<T_SHIRT_STOCK> Check_Stock(int v1, int v2)
        {
            List<T_SHIRT_STOCK> list = db.T_SHIRT_STOCKs.Where(x => x.T_S_N_ID == v1 && x.T_S_SIZE_ID == v2).ToList();
            return list;
        }

        public static List<T_Shirt_Oder_Ditail_DTO> T_Oder()
        {
            List<T_Shirt_Oder_Ditail_DTO> t_oder = new List<T_Shirt_Oder_Ditail_DTO>();
            var list = (from oder_tb in db.SALE_T_SHIRTs
                        join t_name in db.T_SHIRT_NAMEs on oder_tb.T_S_N_ID equals t_name.ID
                        join t_size in db.T_SHIRT_SIZEs on oder_tb.T_S_SIZE_ID equals t_size.SIZE_ID
                        join emp_name in db.EMP_INFOs on oder_tb.EMP_ID equals emp_name.EMP_ID
                        join branch in db.BRANCHes on oder_tb.B_ID equals branch.B_ID
                        join states in db.T_SHIRT_STATEs on oder_tb.STATES equals states.ID
                        select new {
                            id= oder_tb.ID,
                            t_name = t_name.T_NAME,
                            t_size = t_size.SIZE_NAME,
                            emp_name = emp_name.NAME_SURENAME,
                            oder_date = oder_tb.DATE,
                            branch = branch.BRANCH_NAME,
                            recipt_no = oder_tb.RESIPT_NO,
                            states = states.T_STATES,
                            quntity = oder_tb.QUANTITY,
                            price = t_name.PRICE * oder_tb.QUANTITY,
                            oder_id = oder_tb.ODER_ID
                        });
            foreach(var item in list)
            {
                T_Shirt_Oder_Ditail_DTO dto = new T_Shirt_Oder_Ditail_DTO();
                dto.id = item.id;
                dto.t_name = item.t_name;
                dto.t_size = item.t_size;
                dto.emp_name = item.emp_name;
                dto.oder_date = item.oder_date;
                dto.emp_branch = item.branch;
                dto.recipt_no = item.recipt_no;
                dto.states = item.states;
                dto.quntity = item.quntity;
                dto.price = item.price;
                dto.oder = item.oder_id;
                t_oder.Add(dto);
            }
            return t_oder;
        }

        public static List<T_Shirt_Oder_Ditail_DTO> Pending_Oders(int v)
        {
            List<T_Shirt_Oder_Ditail_DTO> t_oder = new List<T_Shirt_Oder_Ditail_DTO>();
            var list = (from oder_tb in db.SALE_T_SHIRTs
                        where oder_tb.STATES == v
                        join t_name in db.T_SHIRT_NAMEs on oder_tb.T_S_N_ID equals t_name.ID
                        join t_size in db.T_SHIRT_SIZEs on oder_tb.T_S_SIZE_ID equals t_size.SIZE_ID
                        join emp_name in db.EMP_INFOs on oder_tb.EMP_ID equals emp_name.EMP_ID
                        join branch in db.BRANCHes on oder_tb.B_ID equals branch.B_ID
                        join states in db.T_SHIRT_STATEs on oder_tb.STATES equals states.ID
                        select new
                        {
                            id = oder_tb.ID,
                            t_name = t_name.T_NAME,
                            t_size = t_size.SIZE_NAME,
                            emp_name = emp_name.NAME_SURENAME,
                            oder_date = oder_tb.DATE,
                            branch = branch.BRANCH_NAME,
                            recipt_no = oder_tb.RESIPT_NO,
                            states = states.T_STATES,
                            quntity = oder_tb.QUANTITY,
                            price = t_name.PRICE * oder_tb.QUANTITY,
                            oder_id = oder_tb.ODER_ID
                        });
            foreach (var item in list)
            {
                T_Shirt_Oder_Ditail_DTO dto = new T_Shirt_Oder_Ditail_DTO();
                dto.id = item.id;
                dto.t_name = item.t_name;
                dto.t_size = item.t_size;
                dto.emp_name = item.emp_name;
                dto.oder_date = item.oder_date;
                dto.emp_branch = item.branch;
                dto.recipt_no = item.recipt_no;
                dto.states = item.states;
                dto.quntity = item.quntity;
                dto.price = item.price;
                dto.oder = item.oder_id;
                t_oder.Add(dto);
            }
            return t_oder;
        }

        public static void Update_State(SALE_T_SHIRT update_complete)
        {
            try
            {

                SALE_T_SHIRT up_stock = db.SALE_T_SHIRTs.First(x => x.ID == update_complete.ID);
                up_stock.STATES = update_complete.STATES;
                db.SubmitChanges();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public static void Update_Stock_quntity(T_SHIRT_STOCK update_stock)
        {
            try
            {

                T_SHIRT_STOCK up_stock = db.T_SHIRT_STOCKs.First(x => x.ID == update_stock.ID );
                up_stock.T_STOCK_QUANTITY = update_stock.T_STOCK_QUANTITY;
                db.SubmitChanges();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public static List<T_SHIRT_STOCK> Check_Stock_quntity(int v)
        {
            List<T_SHIRT_STOCK> list = db.T_SHIRT_STOCKs.Where(x => x.ID == v).ToList();
            return list;
        }

        public static List<T_SHIRT_STOCK> Get_Stock_ID(int v1, int v2)
        {
            //check the tshirt 
            List<T_SHIRT_STOCK> List = db.T_SHIRT_STOCKs.Where(x => x.T_S_N_ID == v1 && x.T_S_SIZE_ID == v2).ToList();
            return List;
        }

        public static List<T_Shirt_Oder_Ditail_DTO> My_Oder(int v1, int v2)
        {
            List<T_Shirt_Oder_Ditail_DTO> t_oder = new List<T_Shirt_Oder_Ditail_DTO>();
            var list = (from oder_tb in db.SALE_T_SHIRTs where oder_tb.EMP_ID ==v1 && oder_tb.STATES == v2
                        join t_name in db.T_SHIRT_NAMEs on oder_tb.T_S_N_ID equals t_name.ID
                        join t_size in db.T_SHIRT_SIZEs on oder_tb.T_S_SIZE_ID equals t_size.SIZE_ID
                        join emp_name in db.EMP_INFOs on oder_tb.EMP_ID equals emp_name.EMP_ID
                        join branch in db.BRANCHes on oder_tb.B_ID equals branch.B_ID
                        join states in db.T_SHIRT_STATEs on oder_tb.STATES equals states.ID
                        select new
                        {
                            id = oder_tb.ID,
                            t_name = t_name.T_NAME,
                            t_size = t_size.SIZE_NAME,
                            emp_name = emp_name.NAME_SURENAME,
                            oder_date = oder_tb.DATE,
                            branch = branch.BRANCH_NAME,
                            recipt_no = oder_tb.RESIPT_NO,
                            states = states.T_STATES,
                            quntity = oder_tb.QUANTITY,
                            price = t_name.PRICE * oder_tb.QUANTITY
                        });
            foreach (var item in list)
            {
                T_Shirt_Oder_Ditail_DTO dto = new T_Shirt_Oder_Ditail_DTO();
                dto.id = item.id;
                dto.t_name = item.t_name;
                dto.t_size = item.t_size;
                dto.emp_name = item.emp_name;
                dto.oder_date = item.oder_date;
                dto.emp_branch = item.branch;
                dto.recipt_no = item.recipt_no;
                dto.states = item.states;
                dto.quntity = item.quntity;
                dto.price = item.price;
                t_oder.Add(dto);
            }
            return t_oder;
        }

        // get the t_shirt stock
        public static List<T_Shirt_Detail_DTO> Get_Stock()
        {
            List<T_Shirt_Detail_DTO> t_stock_detail = new List<T_Shirt_Detail_DTO>();
            var list = (from s_table in db.T_SHIRT_STOCKs
                        join t_name in db.T_SHIRT_NAMEs on s_table.T_S_N_ID equals t_name.ID
                        join t_size in db.T_SHIRT_SIZEs on s_table.T_S_SIZE_ID equals t_size.SIZE_ID
                        select new { 
                        
                            t_name = t_name.T_NAME,
                            t_size = t_size.SIZE_NAME,
                            t_quntity = s_table.T_STOCK_QUANTITY,
                            t_price = t_name.PRICE,
                            All_T_Price = s_table.T_STOCK_QUANTITY * t_name.PRICE ,


                        });
            foreach(var item in list)
            {
                T_Shirt_Detail_DTO dto = new T_Shirt_Detail_DTO();
                dto.t_shirt_name = item.t_name;
                dto.t_shirt_size = item.t_size;
                dto.T_shirt_q = item.t_quntity;
                dto.T_Price = item.t_price;
                dto.All_T_Price = item.All_T_Price;
                t_stock_detail.Add(dto);
            }
            return t_stock_detail;
        }

        public static void Get_T_Shirt(SALE_T_SHIRT get_t)
        {
            try
            {
                db.SALE_T_SHIRTs.InsertOnSubmit(get_t);
                db.SubmitChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void Add_Stock(T_SHIRT_STOCK stock)
        {
            try
            {
                db.T_SHIRT_STOCKs.InsertOnSubmit(stock);
                db.SubmitChanges();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public static void update_Stock(T_SHIRT_STOCK update_stock)
        {
            try
            {

                T_SHIRT_STOCK up_stock = db.T_SHIRT_STOCKs.First(x => x.T_S_N_ID == update_stock.T_S_N_ID && x.T_S_SIZE_ID == update_stock.T_S_SIZE_ID);
                up_stock.T_STOCK_QUANTITY = update_stock.T_STOCK_QUANTITY;
                db.SubmitChanges();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public static void Add_Name_Price(T_SHIRT_NAME name)
        {
            try
            {
                db.T_SHIRT_NAMEs.InsertOnSubmit(name);
                db.SubmitChanges();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        
    }
}
