using System;
class Program
{
    static void Main(string[] args)
    {
        int[] grades = { 75, 90, 45, 60, 85, 30, 95, 70 };

        double aver = CalculateAverage(70, 90);
        double aver2 = CalculateAverage(60, 75, 90);
        double aver3 = CalculateAverage(grades);

        Console.WriteLine(aver);
        Console.WriteLine(aver2);
        Console.WriteLine(aver3);
    }

    static double CalculateAverage(int grade1, int grade2)
    {
        return (double)(grade1 + grade2) / 2;
    }

    static double CalculateAverage(int grade1, int grade2, int grade3)
    {
        return (double)(grade1 + grade2 + grade3) / 3;
    }

    static double CalculateAverage(int[] grades)
    {
        int sum = 0;

        for (int i = 0; i < grades.Length; i++)
        {
            sum += grades[i];
        }

        double average = (double)sum / grades.Length;
        return average;
    }
}