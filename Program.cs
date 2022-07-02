// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

Console.WriteLine("Введите числа через запятую");
string s = Console.ReadLine();
string[] nums = s.Split(",");

int[] array = new int[nums.Length];
for (int i = 0; i < array.Length; i++)
{
    array[i] = int.Parse(nums[i]);
}

int count = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] > 0) count++;
}

Console.WriteLine(count);