using System;

class Program
{
    static void Main()
    {
        Random random = new Random();
        int n = 10; // Размер массива

        // Генерация массива случайных чисел от 1 до 5
        int[] nums = new int[n];
        for (int i = 0; i < n; i++)
        {
            nums[i] = random.Next(1, 4);
        }

        int candidate = FindMajorityCandidate(nums);

        // Проверка, является ли кандидат мажоритарным числом
        int count = nums.Count(num => num == candidate);

        Console.WriteLine("Сгенерированный массив:");
        Console.WriteLine(string.Join(", ", nums));

        if (count > nums.Length / 2)
        {
            Console.WriteLine($"Мажоритарное число: {candidate}");
        }
        else
        {
            Console.WriteLine("Мажоритарного числа нет.");
        }
    }

    static int FindMajorityCandidate(int[] nums)
    {
        int count = 0;
        int candidate = 0;

        foreach (int num in nums)
        {
            if (count == 0)
            {
                candidate = num;
                count = 1;
            }
            else if (num == candidate)
            {
                count++;
            }
            else
            {
                count--;
            }
        }

        return candidate;
    }
}
