using FakeItEasy;
using BelgiumBankAPI.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests.Controller
{
    public class BankControllerTest
    {
        private ApiContext apiContext;
        private BankAccountsController bankController;
        public BankControllerTest() 
        {
            apiContext = A.Fake<ApiContext>();
            bankController = A.Fake<BankAccountsController>();
            
        }
        [Fact]
        public void BankControllerGetAccountSuccess()
        {
            var accounts = A.Fake();
            A.CallTo(() => bankController.GetAccount()).Returns();
        }
    }
}
