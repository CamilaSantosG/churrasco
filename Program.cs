// See https://aka.ms/new-console-template for more information
Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("---Churrasco---");
Console.ResetColor();
//strings//
decimal A1; 
decimal A2;
decimal C;

//programa//
Console.WriteLine();
Console.Write("Adultos (que consomem bebidas alcoólicas)......:");
A1 =  Convert.ToDecimal(Console.ReadLine());
Console.Write("Adultos (que não consomem bebidas alcoólicas)..:");
A2 =  Convert.ToDecimal(Console.ReadLine());
Console.Write("Crianças.......................................:");
C = Convert.ToDecimal(Console.ReadLine());

//resultado//
Console.ForegroundColor = ConsoleColor.DarkCyan;
Console.WriteLine("---Total---");
Console.ResetColor();
decimal carne = (A1 * 400) + (A2 * 400) + (C * 200);
Console.WriteLine($"Carne.....................:{carne}g");

decimal acompanhamento = (A1 * 200) + (A2 * 200) + (C * 200);
Console.WriteLine($"Acompanhamento...:{acompanhamento}g");

decimal cerveja = A1 * 2;
Console.WriteLine($"Cerveja.................:{cerveja}L");

decimal refrigerante = (A1 * 500) + (A2 * 500) + (C * 500);
Console.WriteLine($"Refrigerante........:{refrigerante}ml");

decimal agua = (A1 * 400) + (A2 * 400) + (C * 400);
Console.WriteLine($"Água.......................:{agua}ml");