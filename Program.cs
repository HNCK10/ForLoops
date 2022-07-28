// See https://aka.ms/new-console-template for more information
// for loop - repeat some code a finite amount of times
//unlike a while loop which will loop until a condition is met
//------------------------------------------------------------
//for ([counter];[condition];[increment value];)
//-----------------------------------------------------------
//for (int index = 0; index <= 10; index += 1)
//{
//    Console.WriteLine(index);
//}
//------------------------------------------------------------
//Count down to 1 and then display happy new years!
for (int i = 10; i > 0; i--)
{
    Console.WriteLine(i);
}
Console.WriteLine("Happy new year!");
Console.ReadKey();