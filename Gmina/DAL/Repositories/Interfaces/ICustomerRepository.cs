﻿ 
 
 
 

using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DAL.Repositories.Interfaces
{
    public interface ICustomerRepository : IRepository<Customer>
    {
        IEnumerable<Customer> GetTopActiveCustomers(int count);
        IEnumerable<Customer> GetAllCustomersData();
    }
}
