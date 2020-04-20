using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TOD_Api.Models;
using TOD_Api.Services;

namespace TOD_Api.Controllers
{
    [Route("v1")]
    [ApiController]
    public class TODOController : ControllerBase
    {
        private readonly IServices _service;
        public TODOController(IServices service)
        {

            _service = service;
        }

        [HttpPost]
        [Route("Addtodo")]
        public ActionResult<TODO_Inventory> AddItems(TODO_Inventory items)
        {
            var inventory = _service.AddTODO(items);
            if (inventory == null)
            {
                return NotFound();
            }
            return inventory;

        }

        [HttpPost]
        [Route("Updatestatus")]
        public ActionResult<TODO_Inventory> UpdateStatus(TODO_Inventory items)

        {
            var inventory = _service.UpdateStatus(items);
            if (inventory == null)
            {
                return NotFound();
            }
            return inventory;

        }
      
        [HttpGet]
        [Route("Gettodo")]
        public ActionResult<Dictionary<string, TODO_Inventory>> GetItems()
        {
            var inventoryitems = _service.GetTODO();
            //  if (inventoryitems.Count == 0)
            {
                //    return NotFound();
            }
            return inventoryitems;
        }
    }
}