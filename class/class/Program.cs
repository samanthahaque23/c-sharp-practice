using System;

namespace CSharpIntermediate
{ 
class Program
{
    static void Main(string[] args)
    {
        var customer = new Customer(1,"john");
            Console.WriteLine(customer.Name);
            Console.Write(customer.Id);
        
    }
}


}
