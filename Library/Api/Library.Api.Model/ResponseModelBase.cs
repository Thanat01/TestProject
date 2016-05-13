using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Library.Api.Model
{
    [Serializable]
    public class ResponseModelBase
    {
        public ResponseModelBase(MessageCode code, string message)
        {
            ResponseCode = code.ToString();
            ResponseMessage = message;
        }

        [Required]
        public string ResponseCode { get; set; }
        [Required]
        public string ResponseMessage { get; set; }
    }
}
