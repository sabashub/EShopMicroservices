using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ordering.Domain.ValueObjects
{
    public record Address
    {
        public string FirstName { get; } = default!;
        public string LastName { get; } = default!;
        public string? EmailAddress { get; } = default!;
        public string AddressLine { get; } = default!;
        public string Country { get; } = default!;
        public string State { get; } = default!;
        public string ZipCode { get; } = default!;

        protected Address()
        {

        }
        private Address(string firstName, string lastname, string emailAdress, string addressLine, string country, string state, string zipcode)
        {
            FirstName = firstName;
            LastName = lastname;
            EmailAddress = emailAdress;
            AddressLine = addressLine;
            Country = country;
            State = state;
            ZipCode = zipcode;
        }


        public static Address Of(string firstName, string lastname, string emailAdress, string addressLine, string country, string state, string zipcode)
        {
            ArgumentException.ThrowIfNullOrWhiteSpace(emailAdress);
            ArgumentException.ThrowIfNullOrWhiteSpace(addressLine); 
            
            
            return new Address(firstName, lastname, emailAdress, addressLine, country, state, zipcode);
        }
    }
    
}
