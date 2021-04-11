using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
   public class UserDetailDto:IDto
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public int CustomerId { get; set; }
        public string CompanyName { get; set; }
        //public int FindeksScore { get; set; }
        public int FindeksPoint { get; set; }

        public int CreditCartId { get; set; }
        public string FirstNameAndLastName { get; set; }

        public int Cvv { get; set; }

        public string Date { get; set; }

        public string CartNumber { get; set; }
    }
}
