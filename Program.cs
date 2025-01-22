using cs_console_phone.Classes;

namespace cs_console_phone;

class Program
{
    static void Main(string[] args)
    {
        Phone first_phone = new Phone();
        first_phone.number = 11223344;
        first_phone.model = "IPhone";
        first_phone.weight = 0.2;
        
        Phone second_phone = new Phone(22334455, "YouPhone");
        second_phone.weight = 0.3;
        
        Phone third_phone = new Phone(33445566, "FooPhone", 0.4);
        
        Console.WriteLine(first_phone.number);
        Console.WriteLine(first_phone.model);
        Console.WriteLine(first_phone.weight);
        
        Console.WriteLine(second_phone.number);
        Console.WriteLine(second_phone.model);
        Console.WriteLine(second_phone.weight);
        
        Console.WriteLine(third_phone.number);
        Console.WriteLine(third_phone.model);
        Console.WriteLine(third_phone.weight);
        
        first_phone.receiveCall("Bro");
        second_phone.receiveCall("Classmate", 3101010);
        third_phone.receiveCall("Boss", 512512);
        
        Console.WriteLine(first_phone.getNumber());
        Console.WriteLine(second_phone.getNumber());
        Console.WriteLine(third_phone.getNumber());
    }
}