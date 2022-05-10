
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lynxoma.Server.Services;
using Lynxoma.Shared.DTO;

namespace Lynxoma.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    
    public class SupplierController : ControllerBase
    {
        private readonly ISupplierService supplierService;

        public SupplierController(ISupplierService supplierService)
        {
            this.supplierService = supplierService;
        }

        public IActionResult GetSuppliers()
        {
            return Ok(supplierService.GetSuppliers());
        }

        public IActionResult GetSupplierById(int id)
        {
            return Ok(supplierService.GetSupplierById(id));
        }

        public IActionResult DeleteSupplier(int id)
        {
            return Ok(supplierService.DeleteSupplierById(id));
        }

        [HttpPost]
        
        public IActionResult AddSupplier(SupplierDTO supplierDto)
        {
            bool success=supplierService.AddSupplier(supplierDto);
            return Ok(success);
        }

        [HttpPost]
        public IActionResult UpdateSupplier(SupplierDTO supplierDto)
        {
            bool success = supplierService.UpdateSupplier(supplierDto);
            return Ok(success);
        }

    }
}
