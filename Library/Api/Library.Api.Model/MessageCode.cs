using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Api.Model
{
    public enum MessageCode
    {
        OK = 10,
        Fail = 20,
        Unauthorized = 30,
        WrongSecurityCode = 40,
        DataNotFound = 50,
        MissingParameter = 60,
        InvalidVersion = 70,
        UnkonwError = 99
    }
}
