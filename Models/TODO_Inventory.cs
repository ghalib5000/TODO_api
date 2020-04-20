using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TOD_Api.Models
{
    public class TODO_Inventory
    {
        public int id { get; set; }
        public string subject { get; set; }
        public string date_created { get; set; }
        public enum Status
        {
            completed,notcompleted,deleted
        }
        public Status status { get; set; }


        public TODO_Inventory()
        {
            status = Status.notcompleted;
        }

    }
}
