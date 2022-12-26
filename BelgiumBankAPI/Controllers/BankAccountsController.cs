using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using BelgiumBankAPI.Models;
using BelgiumBankAPI.Data;

namespace BelgiumBankAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BankAccountsController : ControllerBase
    {
        private readonly ApiContext apiContext;

        public BankAccountsController(ApiContext context)
        { 
            apiContext = context;
        }

        [HttpPost]
        public JsonResult CreateEditAccount(BankAccount account) 
        {
            if (account.Id == 0)
            {
                apiContext.Accounts.Add(account);
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
    }
}
