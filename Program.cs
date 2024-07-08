Console.Write("Enter the number of rows (n): ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the number of columns (m): ");
int m = Convert.ToInt32(Console.ReadLine());

int[,] a = new int[n,m];
for(int i = 0; i < n; i++){
    for(int j = 0; j < m; j++){
        Console.WriteLine($"Element[{i}, {j}]: ");
        a[i,j] = Convert.ToInt32(Console.ReadLine());
    }
}

Console.WriteLine("Result: ");
foreach(int i in a) Console.WriteLine(i);

