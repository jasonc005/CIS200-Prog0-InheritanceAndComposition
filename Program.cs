/**
 * Student ID: 1778666
 * Program #: 0
 * Due Date: 9/9/21
 * Course Section: 50
 * Description: This class runs a console app that tests all of the other classes.
**/

using System;
using System.Collections.Generic;

namespace Program0
{
    class Program
    {
        static void Main(string[] args)
        {
            // Test creating Address objects with both constructors
            var testAddress1 = new Address("Anonymous Student", "123 Main St", "Apt 987", "Louisville", "KY", 40208);
            var testAddress2 = new Address("Bob Barker", "6518 Hollywood Blvd", "Ste 15", "Los Angeles", "CA", 90210);
            var testAddress3 = new Address("David Ortiz", "6843 Red Sox Rd", "Boston", "MA", 00123);
            var testAddress4 = new Address("Bill Murray", "1993 Groundhog Ln", "Punxsutawney", "PA", 15767);

            // Test creating Letter objects using test Addresses
            var testLetter1 = new Letter(testAddress1, testAddress2, 1.25M);
            var testLetter2 = new Letter(testAddress3, testAddress4, 0.79M);
            var testLetter3 = new Letter(testAddress1, testAddress4, 2.33M);

            // Create List of type Parcel filled with the test Letters to verify inheritance 
            var parcelList = new List<Parcel>() { testLetter1, testLetter2, testLetter3 };

            // Output all Letters to console to test ToString of Letter, Parcel, and Address classes
            Console.WriteLine("List of Parcels to Send:");
            for (int i = 0; i < parcelList.Count; i++)
            {
                Console.WriteLine($"\nParcel {i + 1}:");
                Console.WriteLine(parcelList[i]);
            }

            // Test using invalid values in each property to create an Address
            Console.WriteLine("\nAttempts to pass invalid values:");

            Console.WriteLine("\nPassing null Name to Address:");
            TestAddressProperties(null, "123 Main St", "Apt 987", "Louisville", "KY", 40208);

            Console.WriteLine("\nPassing null Address1 to Address:");
            TestAddressProperties("Anonymous Student", null, "Apt 987", "Louisville", "KY", 40208);

            Console.WriteLine("\nPassing null Address2 to Address:");
            TestAddressProperties("Anonymous Student", "123 Main St", null, "Louisville", "KY", 40208);

            Console.WriteLine("\nPassing null City to Address:");
            TestAddressProperties("Anonymous Student", "123 Main St", "Apt 987", null, "KY", 40208);

            Console.WriteLine("\nPassing null State to Address:");
            TestAddressProperties("Anonymous Student", "123 Main St", "Apt 987", "Louisville", null, 40208);

            Console.WriteLine("\nPassing negative Zip to Address:");
            TestAddressProperties("Anonymous Student", "123 Main St", "Apt 987", "Louisville", "KY", -1);

            Console.WriteLine("\nPassing too large Zip to Address:");
            TestAddressProperties("Anonymous Student", "123 Main St", "Apt 987", "Louisville", "KY", 123456);

            // Test using invalid values in each property to create a Letter
            Console.WriteLine("\nPassing null OriginAddress to Letter:");
            TestLetterProperties(null, testAddress2, 0.5M);

            Console.WriteLine("\nPassing null DestinationAddress to Letter:");
            TestLetterProperties(testAddress1, null, 0.5M);

            Console.WriteLine("\nPassing negative FixedCost to Letter:");
            TestLetterProperties(testAddress1, testAddress2, -0.5M);
        }

        // Precondition: None
        // Postcondition: Message logged to console to confirm success or failure of creating a new Address object
        private static void TestAddressProperties(string name, string address1, string address2, string city, string state, int zip)
        {
            try
            {
                var address = new Address(name, address1, address2, city, state, zip);
                Console.WriteLine("Test passed with no errors");
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        // Precondition: None
        // Postcondition: Message logged to console to confirm success or failure of creating a new Letter object
        private static void TestLetterProperties(Address originAddress, Address destinationAddress, decimal fixedCost)
        {
            try
            {
                var letter = new Letter(originAddress, destinationAddress, fixedCost);
                Console.WriteLine("Test passed with no errors");
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
