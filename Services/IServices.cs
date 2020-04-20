using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TOD_Api.Models;

namespace TOD_Api.Services
{
    public interface IServices
    {
        TODO_Inventory AddTODO(TODO_Inventory items);
        Dictionary<String, TODO_Inventory> GetTODO();
        void UpdateTODO(TODO_Inventory items);
        void DeleteTODO(TODO_Inventory items);
        TODO_Inventory UpdateStatus(TODO_Inventory items);
    }
}
