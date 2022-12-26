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
    }
}
