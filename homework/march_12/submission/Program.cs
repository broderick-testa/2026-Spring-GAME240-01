int[] arr = new int[5];
Random rand = new Random();

//Assign random ints
for (int i = 0; i < arr.Length; i++)
{
    arr[i] = rand.Next(-100, 101);
}

//Write out array
for (int i = 0; i < arr.Length; i++)
{
    Console.Write(arr[i] + " ");
}
Console.WriteLine();

//Compare
int smallest = arr[0];
int largest = arr[0];

for (int i = 1; i < arr.Length; i++)
{
    if (arr[i] > largest)
    {
        largest = arr[i];
    }

    if (arr[i] < smallest)
    {
        smallest = arr[i];
    }
}

//Results
Console.WriteLine("The smallest number is " + smallest + ". The largest number is " + largest);