﻿using System;
using System.Collections.Generic;

namespace MediatR1.Models
{
    public partial class Registration
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
    }
}
