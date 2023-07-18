using Casgem.BusinessLayer.Abstract;
using Casgem.DataAccessLayer.Abstract;
using Casgem.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casgem.BusinessLayer.Concrete
{
    public class CustomerManager : ICustomerService
    {
        readonly ICustomerDal  _customerDal;

        public CustomerManager(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }
        public void TDelete(Customer t)
        {
            throw new NotImplementedException();
        }

        public Customer TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Customer> TGetList()
        {
            throw new NotImplementedException();
        }

        public void TInsert(Customer t)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Customer t)
        {
            throw new NotImplementedException();
        }
    }
}
