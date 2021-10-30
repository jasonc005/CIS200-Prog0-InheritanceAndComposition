/**
 * Student ID: 1778666
 * Program #: 0
 * Due Date: 9/9/21
 * Course Section: 50
 * Description: This class inherits from Parcel, adding a private readonly property for Fixed Cost.
 *      It also overrides and implements the CalcCost method from Parcel to return the value of FixedCost
**/

using System;

namespace Program0
{
    public class Letter : Parcel
    {
        private decimal FixedCost { get; } // Read-only property to store the fixed cost to send a letter

        // Precondition: originAddress != null, destinationAddress != null, fixedCost >= 0
        // Postcondition: New Letter object created and returned
        public Letter(Address originAddress, Address destinationAddress, decimal fixedCost)
            : base(originAddress, destinationAddress)
        {
            if (fixedCost < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(fixedCost), fixedCost, $"{nameof(fixedCost)} must not be negative");
            }

            FixedCost = fixedCost;
        }

        // Precondition: None
        // Postcondition: The cost to send the letter is returned
        public override decimal CalcCost() => FixedCost;

        // Precondition: None
        // Postcondition: Formatted string with to and from addresses and fixed cost is returned
        public override string ToString()
        {
            string result = base.ToString();

            result += $"\nFixed Cost: {FixedCost:C}";

            return result;
        }
    }
}
