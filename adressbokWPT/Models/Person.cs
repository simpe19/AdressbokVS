﻿
using adressbokWPT.Interfaces;
using System;

namespace adressbokWPT.Models
{
    internal class Person : IPerson
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string FirstName { get; set; } = null!;

        public string LastName { get; set; } = null!;

        public string Email { get; set; } = null!;

        public string Number { get; set; } = null!;

        public string Adress { get; set; } = null!;

        public string DisplayName => $"{FirstName} {LastName}";
        
    }

}
