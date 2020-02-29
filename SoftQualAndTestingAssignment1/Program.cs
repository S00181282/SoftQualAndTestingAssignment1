using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftQualAndTestingAssignment1
{
    public class Program
    {
        //Coverage Type Enum
        public enum Coverage { Comprehensive, ThirdParty }
        static Coverage coverageType;

        //Main Method to start the program
        public static void Main()
        {
            //Variables
            int clientAge, carValue, penaltyPoints, extraCharge;
            float basicPremium = 0;

            //Gathering the Client's information
            carValue = CarValue();
            basicPremium = CoverageType();
            clientAge = ClientAge();
            basicPremium = Between18And25Method(clientAge, basicPremium);
            penaltyPoints = PointAmount();
            extraCharge = ExtraChargeCost(penaltyPoints);

            /*-------------------Client Information-------------------*/
            Console.WriteLine("\n\n---CLIENT INFO---");
            Console.WriteLine("Car Value: €" + carValue);
            Console.WriteLine("Coverage Type: " + coverageType + " Coverage");
            Console.WriteLine("Age: " + clientAge + " Years Old");
            Console.WriteLine("Basic Premium: " + basicPremium + "%");
            Console.WriteLine("Penalty Points: " + penaltyPoints);
            Console.WriteLine("Extra Charge: €" + extraCharge);
            Console.ReadLine();
        }

        //The value of the Client's car
        static int CarValue()
        {
            Console.Write("Enter Value of the Car: €");
            return Convert.ToInt32(Console.ReadLine());
        }

        //The Coverage Type of the Client
        static float CoverageType()
        {
            Console.Write("Enter Client's Coverage Type: ");
            Enum.TryParse(Console.ReadLine(), out coverageType);

            switch (coverageType)
            {
                //if it is Comprehensive Coverage
                case Coverage.Comprehensive:
                    Console.WriteLine("Basic Premium is now 4%.");
                    return 4f;

                //if it is Third Party Coverage
                case Coverage.ThirdParty:
                    Console.WriteLine("Basic Premium is now 2.5%.");
                    return 2.5f;

                //if you did not enter a valid Coverage type
                default:
                    Console.WriteLine("Please Enter a Valid Coverage Type.");
                    Main();
                    return 0f;
            }
        }

        //The Client's Age
        static int ClientAge()
        {
            int age;

            Console.Write("Enter Client's Age: ");
            age = Convert.ToInt32(Console.ReadLine());

            return age;
        }

        //If the Client is between the ages of Eighteen and Twenty-Five
        static float Between18And25Method(int age, float premium)
        {
            bool eighteenToTwentyfive;

            if (age >= 18)
            {
                if (age >= 18 && age <= 25)
                {
                    eighteenToTwentyfive = true;
                }
                else
                {
                    eighteenToTwentyfive = false;
                }
            }
            else
            {
                //if the Client is below Eighteen
                Console.WriteLine("NO QUOTE POSSIBLE.");
                Console.WriteLine();
                Main();
                return 0;
            }

            switch (eighteenToTwentyfive)
            {
                //if they are between Eighteen and Twenty-Five
                case true:
                    premium += 10f;
                    Console.WriteLine("Basic Premium Raised by 10% to " + premium + "%.");
                    return premium;

                //if they are NOT between Eighteen and Twenty-Five
                case false:
                    premium += 0f;
                    Console.WriteLine("Basic Premium Not Raised, it is still " + premium + "%.");
                    return premium;

                default:
                    return premium;
            }
        }

        //The amount of penalty points the Client has
        static int PointAmount()
        {
            int points;

            Console.Write("Enter Client's Penalty Points: ");
            points = Convert.ToInt32(Console.ReadLine());
            return points;
        }

        //The extra charge they need to pay because of their accumulated penalty points
        static int ExtraChargeCost(int points)
        {
            int charge;

            switch (points)
            {
                case 0:
                    charge = 0;
                    Console.WriteLine("No Extra Charge.");
                    return charge;

                case 1:
                case 2:
                case 3:
                case 4:
                    charge = 100;
                    Console.WriteLine("An Extra Charge of 100 Euro is Required.");
                    return charge;

                case 5:
                case 6:
                case 7:
                    charge = 200;
                    Console.WriteLine("An Extra Charge of 200 Euro is Required.");
                    return charge;

                case 8:
                case 9:
                case 10:
                    charge = 300;
                    Console.WriteLine("An Extra Charge of 300 Euro is Required.");
                    return charge;

                case 11:
                case 12:
                    charge = 400;
                    Console.WriteLine("An Extra Charge of 400 Euro is Required.");
                    return charge;

                default:
                    charge = 0;
                    Console.WriteLine("NO QUOTE POSSIBLE.");
                    return charge;
            }
        }
    }
}
