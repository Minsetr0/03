int ascendingCycle = 7;
// 12-5 = 7, как и вообще все числа там возрастают на 7
// цикл заканчивается, 96 - 5 = 91, а 91 / 7 = 13, значит цикл должен повторяться 13 раз
int repeats = 96 / 7;
int initialNumber = 5;
for (int i = 0; i <= repeats; i++)
{
    Console.WriteLine(initialNumber);
    initialNumber += ascendingCycle;
}