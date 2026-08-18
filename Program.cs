const string nombreComercio = "Kiosco Palta";
Console.WriteLine($"Bienvenido a {nombreComercio}!");
Console.Write("Por favor, ingrese el nombre del cajero: ");
string nombreCajero = Console.ReadLine();
Console.WriteLine($"Bienvenido/a {nombreCajero}. Caja abierta!");
Console.WriteLine();

Console.Write("Por favor, Ingrese el nombre del producto que desea agregar: ");
string nombreProducto = Console.ReadLine();
Console.Write("Ingrese el precio del producto: ");
decimal precioProducto = decimal.Parse(Console.ReadLine());
Console.WriteLine($"El producto {nombreProducto} posee un precio de $ {precioProducto}");


Console.ReadLine();