// See https://aka.ms/new-console-template for more information

Console.WriteLine("***********************Water bill calculation program*********************");

void CalculateWaterBill()
{
    Console.Write("Enter customer name: ");
    string customerName = Console.ReadLine();
    Console.WriteLine("Please choose customer type:");
    Console.WriteLine("Enter 1 if you are a household customer");
    Console.WriteLine("Enter 2 if you are a government administrative organization customer");
    Console.WriteLine("Enter 3 if you are a manufacturing unit customer");
    Console.WriteLine("Enter 4 if you are a business service customer");
    int typeCustomer = Convert.ToInt32(Console.ReadLine());
    if (typeCustomer == 1)
    {
        // Household customer
        // Request the number of household members
        Console.Write("Enter the number of people in the household: ");
        int numberOfPeople = int.Parse(Console.ReadLine());
        if (numberOfPeople > 1)
        {
            Console.Write("Enter the previous month's water meter reading: ");
            int previousWaterIndex = int.Parse(Console.ReadLine());

            Console.Write("Enter the water meter reading for this month: ");
            int currentWaterIndex = int.Parse(Console.ReadLine());
            if (currentWaterIndex >= previousWaterIndex)
            {
                int consumption = currentWaterIndex - previousWaterIndex;
                double waterConsumptionPerPerson = consumption / numberOfPeople;
                double totalWaterBill = 0;
                if (waterConsumptionPerPerson > 0 && waterConsumptionPerPerson <= 10)
                {
                    totalWaterBill = consumption * 5973 * 1.1;
                }
                else if (waterConsumptionPerPerson > 10 && waterConsumptionPerPerson <= 20)
                {
                    totalWaterBill = consumption * 7051 * 1.1;
                }
                else if (waterConsumptionPerPerson > 20 && waterConsumptionPerPerson <= 30)
                {
                    totalWaterBill = consumption * 8699 * 1.1;
                }
                else
                {
                    totalWaterBill = consumption * 15929 * 1.1;
                }
                Console.WriteLine("\nInvoice Information:");
                Console.WriteLine("Customer Name: " + customerName);
                Console.WriteLine("Previous month's water meter reading: " + previousWaterIndex);
                Console.WriteLine("Water meter reading for this month: " + currentWaterIndex);
                Console.WriteLine("Consumption: " + consumption + " m3");
                Console.WriteLine("Total water bill (excluding VAT): " + totalWaterBill.ToString("N2") + " VND");
            }
            else
            {
                Console.WriteLine("The water consumption of the previous month cannot be greater than that of the current month.");
            }
        }
        else
        {
            Console.WriteLine("You are not a household customer.");
        }
    }
    else if (typeCustomer == 2)
    {
        // Government administrative organization customer
        Console.Write("Enter the previous month's water meter reading: ");
        int previousWaterIndex2 = int.Parse(Console.ReadLine());

        Console.Write("Enter the water meter reading for this month: ");
        int currentWaterIndex2 = int.Parse(Console.ReadLine());
        if (currentWaterIndex2 >= previousWaterIndex2)
        {
            int consumption2 = currentWaterIndex2 - previousWaterIndex2;
            double totalWaterBill2 = consumption2 * 9955 * 1.1;
            Console.WriteLine("\nInvoice Information:");
            Console.WriteLine("Customer Name: " + customerName);
            Console.WriteLine("Previous month's water meter reading: " + previousWaterIndex2);
            Console.WriteLine("Water meter reading for this month: " + currentWaterIndex2);
            Console.WriteLine("Consumption: " + consumption2 + " m3");
            Console.WriteLine("Total water bill (excluding VAT): " + totalWaterBill2.ToString("N2") + " VND");
        }
        else
        {
            Console.WriteLine("The water consumption of the previous month cannot be greater than that of the current month.");
        }
    }
    else if (typeCustomer == 3)
    {
        // Manufacturing unit customer
        Console.Write("Enter the previous month's water meter reading: ");
        int previousWaterIndex3 = int.Parse(Console.ReadLine());

        Console.Write("Enter the water meter reading for this month: ");
        int currentWaterIndex3 = int.Parse(Console.ReadLine()); ;
        if (currentWaterIndex3 >= previousWaterIndex3)
        {
            int consumption3 = currentWaterIndex3 - previousWaterIndex3;

            double totalWaterBill3 = consumption3 * 11615 * 1.1;
            Console.WriteLine("\nInvoice Information:");
            Console.WriteLine("Customer Name: " + customerName);
            Console.WriteLine("Previous month's water meter reading: " + previousWaterIndex3);
            Console.WriteLine("Water meter reading for this month: " + currentWaterIndex3);
            Console.WriteLine("Consumption: " + consumption3 + " m3");
            Console.WriteLine("Total water bill (excluding VAT): " + totalWaterBill3.ToString("N2") + " VND");

        }
        else
        {
            Console.WriteLine("The water consumption of the previous month cannot be greater than that of the current month.");
        }
    }
    else if (typeCustomer == 4)
    {
        // Business service customer
        Console.Write("Enter the previous month's water meter reading: ");
        int previousWaterIndex4 = int.Parse(Console.ReadLine());

        Console.Write("Enter the water meter reading for this month: ");
        int currentWaterIndex4 = int.Parse(Console.ReadLine());
        if (currentWaterIndex4 >= previousWaterIndex4)
        {
            int consumption4 = currentWaterIndex4 - previousWaterIndex4;
            double totalWaterBill4 = consumption4 * 22068 * 1.1;
            Console.WriteLine("\nInvoice Information:");
            Console.WriteLine("Customer Name: " + customerName);
            Console.WriteLine("Previous month's water meter reading: " + previousWaterIndex4);
            Console.WriteLine("Water meter reading for this month: " + currentWaterIndex4);
            Console.WriteLine("Consumption: " + consumption4 + " m3");
            Console.WriteLine("Total water bill (excluding VAT): " + totalWaterBill4.ToString("N2") + " VND");

        }
        else
        {
            Console.WriteLine("The water consumption of the previous month cannot be greater than that of the current month.");
        }
    }
    else
    {
        Console.WriteLine("Please enter the correct customer type.");
    }
}
// Run the program
CalculateWaterBill();
