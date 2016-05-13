using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Library.Api.Authentication.AuthenFilters
{
    public class AlphaClaimTypes
    {
        public const string EntityTypeId = "http://schema.alphacansend.com/EntityTypeId";
        public const string UserRoleId = "http://schema.alphacansend.com/UserRoleId";
        /// <summary>
        /// Employee = EmployeeId, Customer="99999999" (Replace EnitityId with "99999999" in case customer)
        /// Use for update BookingBy, GetBy, EditBy, QRCodeDetail.EmployeeId
        /// </summary>
        public const string EntityId = "http://schema.alphacansend.com/EntityId";
        /// <summary>
        /// Real EntityId in system.
        /// </summary>
        public const string CustomerId = "http://schema.alphacansend.com/RealId";//Add by Ma

        public const string Fistname = "http://schema.alphacansend.com/Fistname";
        public const string Lastname = "http://schema.alphacansend.com/Lastname";
        public const string Username = "http://schema.alphacansend.com/Username";
        public const string SecurityCode = "http://schema.alphacansend.com/SecurityCode";
        public const string Language = "http://schema.alphacansend.com/Language";
    }
}