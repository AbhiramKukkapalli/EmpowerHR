using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web_API.Models
{
    public partial class ToDoListView
    {
        public List<EmpToDoList> EmpToDoList { get; set; }
    }
    public class EmpToDoList
    {
        public int Id { get; set; }
        public int EmpId { get; set; }
        public string Note { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int Status { get; set; }

       
    } 
}
