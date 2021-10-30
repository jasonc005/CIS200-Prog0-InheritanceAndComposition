/**
 * Student ID: 1778666
 * Program #: 0
 * Due Date: 9/9/21
 * Course Section: 50
 * Description: This is an abstract base class that holds the base requirements for any type of Parcel:
 *      Origin and Destination Addresses (using composition) 
 *      and a method that must be implemented to calculate and return cost
**/

using System;

namespace Program0
{
    public abstract class Parcel
    {
        private Address _originAddress; // Backing field for OriginAddress property
        private Address _destinationAddress; // Backing field for DestinationAddress property

        // Precondition: originAddress != null, destinationAddress != null
        // Postcondition: New Parcel object created and returned
        public Parcel(Address originAddress, Address destinationAddress)
        {
            OriginAddress = originAddress;
            DestinationAddress = destinationAddress;
        }

        // Represents the sender's address
        public Address OriginAddress
        {
            // Precondition: None
            // Postcondition: Address object representing sender's address is returned
            get
            {
                return _originAddress;
            }
            // Precondition: value != null
            // Postcondition: The Address representing sender's address is updated/saved
            set
            {
                if (value == null)
                {
                    throw new ArgumentOutOfRangeException(nameof(OriginAddress), value, $"{nameof(OriginAddress)} must not be null");
                }

                _originAddress = value;
            }
        }

        // Represents the recipient's address
        public Address DestinationAddress
        {
            // Precondition: None
            // Postcondition: Address object representing recipient's address is returned
            get
            {
                return _destinationAddress;
            }
            // Precondition: value != null
            // Postcondition: The Address representing recipient's address is updated/saved
            set
            {
                if (value == null)
                {
                    throw new ArgumentOutOfRangeException(nameof(DestinationAddress), value, $"{nameof(DestinationAddress)} must not be null");
                }

                _destinationAddress = value;
            }
        }

        // Precondition: None
        // Postcondition: The cost to send the parcel is returned
        public abstract decimal CalcCost();

        // Precondition: None
        // Postcondition: Formatted string with to and from addresses is returned
        public override string ToString()
        {
            string result;

            result = $"Origin Address:\n{OriginAddress}";
            result += $"\nDestination Address:\n{DestinationAddress}";

            return result;
        }
    }
}
