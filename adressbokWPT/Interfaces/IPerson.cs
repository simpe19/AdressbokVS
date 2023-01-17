

using System;

namespace adressbokWPT.Interfaces;


    internal interface IPerson
    {
        Guid Id { get; set; }
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string Number { get; set; }

        public string Adress { get; set; }
    }
