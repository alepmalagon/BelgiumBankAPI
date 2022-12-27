using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using BelgiumBankAPI.Models;
using BelgiumBankAPI.Data;

namespace BelgiumBankAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class BankAccountsController : ControllerBase
    {
        private readonly ApiContext apiContext;

        public BankAccountsController(ApiContext context)
        { 
            apiContext = context;
            Customer customer1 = new Customer();
            customer1.Name = "John";
            customer1.Surname = "Doe";
            apiContext.Customers.Add(customer1);
            apiContext.SaveChanges();
        }

        [HttpPost]
        public JsonResult CreateEditAccount(BankAccount account) 
        {
            if (account.Id == 0)
            {
                var addedAccount = apiContext.Accounts.Add(account);
                if (account.Balance != 0) 
                { 
                    Transaction trans = new Transaction();
                    trans.Amount = account.Balance;
                    trans.OriginAccountId = 0;
                    trans.DestinationAccountId = addedAccount.Entity.CustomerId;
                    apiContext.Transactions.Add(trans);
                }

            }
            else 
            {
                var accountInDb = apiContext.Accounts.Find(account.Id);
                if (accountInDb == null) 
                {
                    return new JsonResult(NotFound());
                }
                accountInDb = account; 
            }

            apiContext.SaveChanges();
            return new JsonResult(Ok(account));
        }

        [HttpGet]
        public JsonResult GetAccount(int id) 
        { 
            var result = apiContext.Accounts.Find(id);

            if (result == null)
            {
                return new JsonResult(NotFound());
            }
            return new JsonResult(Ok(result));
        }

        [HttpGet]
        public JsonResult GetCustomerAccounts(int customerid)
        {
            var result = apiContext.Accounts.Where(x => x.CustomerId == customerid);

            return new JsonResult(Ok(result));
        }

        [HttpGet("/GetAllCustomers")]
        public JsonResult GetAllCustomers() 
        {
            var customers = apiContext.Customers.ToList();
            return new JsonResult(Ok(customers));
        }


    }
}
