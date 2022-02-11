// load data from file
var data = File.ReadAllLines("../../Data/1k.txt");

// convert to int[]
var input = Array.ConvertAll(data, int.Parse);

// Bubble sort
for (int i = 0; i < input.Length; i++)
{
    for (int j = 0; j < input.Length - 1; j++)
    {
        if (input[j] > input[j + 1])
        {
            // swap
            int temp = input[j];
            input[j] = input[j + 1];
            input[j + 1] = temp;
        }
    }
}

// output data
foreach (var item in input) Console.WriteLine(item);