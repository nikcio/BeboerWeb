﻿using System.Collections.Generic;

namespace BeboerWeb.Api.Domain.Models
{
    public class Address
    {
        public string Street { get; set; }
        public string Number { get; set; }

        public virtual IEnumerable<Property> Properties { get; set; }
        public virtual City City { get; set; }
    }
}