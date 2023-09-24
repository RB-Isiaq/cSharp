// See https://aka.ms/new-console-template for more information

Customer cmt = new Customer("8784");
cmt.Phone = "09034029495";
cmt.Name = "Great customer";
Console.WriteLine($"Customer 1");
Console.WriteLine($"Custoeer Code {cmt.Code} {cmt.Name}");


Customer cmt2 = new Customer("87784", "Good customer!");

Console.WriteLine($"Customer 2");
Console.WriteLine($"Customer Name {cmt2.Name} {cmt2.Code}");