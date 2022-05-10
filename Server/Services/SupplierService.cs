using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lynxoma.Server.Models;
using Lynxoma.Shared.DTO;


namespace Lynxoma.Server.Services
{
    public class SupplierService : ISupplierService
    {
        private readonly DataContext dataContext;

        public SupplierService(DataContext dataContext)
        {
            this.dataContext = dataContext;
        }

        
        public bool  AddSupplier(SupplierDTO newSupplierDto)
        {
            bool itemCreated = false;

            Supplier newSupplier = new Supplier();
            newSupplier.Name = newSupplierDto.Name;
            newSupplier.Address1 = newSupplierDto.Address1;
            newSupplier.Address2 = newSupplierDto.Address2;
            newSupplier.City = newSupplierDto.City;
            newSupplier.PostalCode = newSupplierDto.PostalCode;
            newSupplier.State = newSupplierDto.State;

            try
            {
                dataContext.Suppliers.Add(newSupplier);
                dataContext.SaveChanges();
                itemCreated = true;
            }
            catch
            {
                itemCreated = false;
            }

            return itemCreated;
        }

        public Supplier[]  DeleteSupplierById(int id)
        {
            Supplier supplier = dataContext.Suppliers.FirstOrDefault(f => f.Id == id);
            dataContext.Suppliers.Remove(supplier);
            dataContext.SaveChanges();

            return dataContext.Suppliers.ToArray<Supplier>();
        }

        public Supplier  GetSupplierById(int id)
        {
            return  dataContext.Suppliers.FirstOrDefault(f => f.Id == id);
        }

        public Supplier[]  GetSuppliers()
        {

            return dataContext.Suppliers.ToArray<Supplier>();
        }

        public bool UpdateSupplier(SupplierDTO updatedSupplierDto)
        {
            bool itemUpdated = false;

            Supplier supplier=dataContext.Suppliers.FirstOrDefault(f => f.Id == updatedSupplierDto.Id);

            supplier.Name = updatedSupplierDto.Name;
            supplier.Address1 = updatedSupplierDto.Address1;
            supplier.Address2 = updatedSupplierDto.Address2;
            supplier.City = updatedSupplierDto.City;
            supplier.PostalCode = updatedSupplierDto.PostalCode;
            supplier.State = updatedSupplierDto.State;

            try
            {
                dataContext.SaveChanges();
                itemUpdated = true;
            }
            catch
            {
                itemUpdated = false;
            }

            return itemUpdated;

        }
    }
}
