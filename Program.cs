/* 12x12 Multiplication Table
    Created by: Owen Douglas
    The program will print out a 12x12 multiplication table
*/

//Outer loop to create the rows
for (int a = 1; a <= 12; a++)
{
    //Inner loop to create columns
    for (int b = 1; b <=12; b++)
    {

        Console.Write($"| {a * b,2} ");
    }
    //Print | at the end of each row
    Console.WriteLine("|");

    //Print ------ for inbetween each row
    Console.WriteLine("-----------------------------------------------------------------");
}