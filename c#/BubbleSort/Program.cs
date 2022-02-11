var data = File.ReadAllLines("../../Data/1k.txt");
var input = Array.ConvertAll(data, int.Parse);

int[] testData = input.Take(10).ToArray();

for (int i = 0; i < input.Length; i++)
{
    for (int j = 0; j < input.Length - 1; j++)
    {
        int z = 0;
        if (input[j] > input[j + 1])
        {
            // swap
            z = input[j];
            input[j] = input[j + 1];
            input[j + 1] = z;
        }
    }
}


foreach (var item in input.Distinct()) Console.WriteLine(item);