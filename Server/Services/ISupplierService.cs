using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lynxoma.Server.Models;
using Lynxoma.Shared.DTO;

namespace Lynxoma.Server.Services
{
    public interface ISupplierService
    {
        Supplier[] GetSuppliers();

        Supplier GetSupplierById(int id);

        bool AddSupplier(SupplierDTO newSupplier);

        bool UpdateSupplier(SupplierDTO updatedSupplier);

        Supplier[] DeleteSupplierById(int id);

    }
}
