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
        public BankControllerTest() 
        {
            apiContext = A.Fake<ApiContext>(); 
        }
    }
}
