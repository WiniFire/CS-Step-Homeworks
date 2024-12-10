const ushort m = 4;
const ushort n = 5;
int[,] array = new int[m, n]
    {
        { 1, 2, 3, 4, 5},
        { 7, 8, 9, 10, 11},
        { 12, 13, 14, 15, 16},
        { 17, 18, 19, 20, 21}
    };  
Console.WriteLine("Незмінений массив: ");
Console.WriteLine("{");
for (short i = 0; i < array.GetUpperBound(0) + 1; i++)
{
    Console.Write("    {");
    for (short j = 0; j < array.GetUpperBound(1) + 1; j++)
    {
        Console.Write(array[i, j]);
        if (j != n - 1) Console.Write(", ");
    }
    if (i != m - 1) Console.WriteLine("}, ");
    else Console.WriteLine("}");
}
Console.WriteLine("}\n=======================");
ushort colToSwap1 = 3;
ushort colToSwap2 = 4;
for (short i = 0; i < array.GetUpperBound(0) + 1; i++)
{
    for (short j = 0; j < array.GetUpperBound(1) + 1; j++)
    {
        if (j == colToSwap1 - 1)
        {
            int saveValue = array[i, j];
            array[i, j] = array[i, colToSwap2 - 1];
            array[i, colToSwap2 - 1] = saveValue;
            break;
        }
    }
}
Console.WriteLine("Змінений массив: ");
Console.WriteLine("{");
for (short i = 0; i < array.GetUpperBound(0) + 1; i++)
{
    Console.Write("    {");
    for (short j = 0; j < array.GetUpperBound(1) + 1; j++)
    {
        Console.Write(array[i, j]);
        if (j != n - 1) Console.Write(", ");
    }
    if (i != m - 1) Console.WriteLine("}, ");
    else Console.WriteLine("}"); 
}
Console.WriteLine("}");