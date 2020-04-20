using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TOD_Api.Models;

namespace TOD_Api.Services
{
    public class Services : IServices
    {
        private readonly Dictionary<string, TODO_Inventory> dict;


        public Services()
        {
            dict = new Dictionary<string, TODO_Inventory>();
        }

        public TODO_Inventory AddTODO(TODO_Inventory items)
        {
            items.date_created = DateTime.Now.ToString("f");
            dict.Add(items.id.ToString(), items);
            return items;
        }
       
        public void DeleteTODO(TODO_Inventory items)
        {
            throw new NotImplementedException();
        }

        public Dictionary<String, TODO_Inventory> GetTODO()
        {
            return dict;
        }

        public TODO_Inventory UpdateStatus(TODO_Inventory items)
        {

            if (dict.ContainsKey(items.id.ToString()))
            {
                dict.Remove(items.id.ToString());
                dict.Add(items.id.ToString(), items);
            }
            return items;

        }


        public void UpdateTODO(TODO_Inventory items)
        {
            throw new NotImplementedException();
        }

    }
}
