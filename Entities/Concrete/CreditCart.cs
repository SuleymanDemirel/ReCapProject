using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class CreditCart:IEntity
    {
        public int CreditCartId { get; set; }

        public string FirstNameAndLastName { get; set; }

        public int Cvv { get; set; }

        public string Date { get; set; }

        public string CartNumber { get; set; }

    }
}
