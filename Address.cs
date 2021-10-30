/**
 * Student ID: 1778666
 * Program #: 0
 * Due Date: 9/9/21
 * Course Section: 50
 * Description: This class stores address data and displays it nicely by overriding ToString()
**/

using System;

namespace Program0
{
    public class Address
    {
        private string _name; // Backing field for Name property
        private string _address1; // Backing field for Address1 property
        private string _address2; // Backing field for Address2 property
        private string _city; // Backing field for City property
        private string _state; // Backing field for State property
        private int _zip; // Backing field for Zip property

        // Precondition: name, address1, city, and state all not null or whitespace
        //               0 <= zip <= 99999
        // Postcondition: New Address object created and returned
        public Address(string name, string address1, string address2, string city, string state, int zip)
        {
            Name = name;
            Address1 = address1;
            Address2 = address2;
            City = city;
            State = state;
            Zip = zip;
        }

        // Precondition: name, address1, city, and state all not null or whitespace
        //               0 <= zip <= 99999
        // Postcondition: New Address object created and returned with empty Address2
        public Address(string name, string address1, string city, string state, int zip)
            : this(name, address1, string.Empty, city, state, zip) { }

        // The name of the person/business associated with the address
        public string Name
        {
            // Precondition: None
            // Postcondition: String with person/business name is returned
            get
            {
                return _name;
            }
            // Precondition: value not null or whitespace
            // Postcondition: Trimmed value is set as new name
            set
            {
                if (string.IsNullOrWhiteSpace(value?.Trim()))
                {
                    throw new ArgumentOutOfRangeException(nameof(Name), value, $"{nameof(Name)} must not be null or empty");
                }

                _name = value.Trim();
            }
        }

        // First street address line
        public string Address1
        {
            // Precondition: None
            // Postcondition: String with first street address line returned
            get
            {
                return _address1;
            }
            // Precondition: value not null or whitespace
            // Postcondition: Trimmed value is set as new first street address line
            set
            {
                if (string.IsNullOrWhiteSpace(value?.Trim()))
                {
                    throw new ArgumentOutOfRangeException(nameof(Address1), value, $"{nameof(Address1)} must not be null or empty");
                }

                _address1 = value.Trim();
            }
        }

        // Second street address line
        public string Address2
        {
            // Precondition: None
            // Postcondition: String with second street address line returned, may be null or empty
            get
            {
                return _address2;
            }
            // Precondition: None
            // Postcondition: Trimmed or null value is set as new second street address line
            set
            {
                _address2 = value?.Trim();
            }
        }

        // The city name associated with the address
        public string City
        {
            // Precondition: None
            // Postcondition: String with city name is returned
            get
            {
                return _city;
            }
            // Precondition: value not null or whitespace
            // Postcondition: Trimmed value is set as new city name
            set
            {
                if (string.IsNullOrWhiteSpace(value?.Trim()))
                {
                    throw new ArgumentOutOfRangeException(nameof(City), value, $"{nameof(City)} must not be null or empty");
                }

                _city = value.Trim();
            }
        }

        // The state associated with the address
        public string State
        {
            // Precondition: None
            // Postcondition: String with state name is returned
            get
            {
                return _state;
            }
            // Precondition: value not null or whitespace
            // Postcondition: Trimmed value is set as new state name
            set
            {
                if (string.IsNullOrWhiteSpace(value?.Trim()))
                {
                    throw new ArgumentOutOfRangeException(nameof(State), value, $"{nameof(State)} must not be null or empty");
                }

                _state = value.Trim();
            }
        }

        // The ZIP code associated with the address
        public int Zip
        {
            // Precondition: None
            // Postcondition: ZIP code returned as integer
            get
            {
                return _zip;
            }
            // Precondition: 0 <= value <= 99999
            // Postcondition: value is set as new ZIP code
            set
            {
                if (value < 0 || value > 99999)
                {
                    throw new ArgumentOutOfRangeException(nameof(Zip), value, $"{nameof(Zip)} must be between 0 and 99999");
                }

                _zip = value;
            }
        }

        // Precondition: None
        // Postcondition: Formatted string with all address
        public override string ToString()
        {
            string result;

            result = Name;
            result += $"\n{Address1}";

            if (!string.IsNullOrWhiteSpace(Address2))
                result += $"\n{Address2}";

            result += $"\n{City}, {State} {Zip:D5}";
            
            return result;
        }
    }
}
