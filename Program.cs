int ascendingCycle = 7;
int repeats = 96;
int firstNumberInCycle = 5;

for (int initialNumber = firstNumberInCycle; initialNumber <= repeats; initialNumber += ascendingCycle)
{
    Console.WriteLine(initialNumber);
}