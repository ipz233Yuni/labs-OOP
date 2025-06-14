using System;
using System.Text;

public struct Worker
{
    public string Name;
    public int Year;
    public int Month;
    public Company WorkPlace;

    public Worker(string name, int year, int month, Company workPlace)
    {
        Name = name;
        Year = year;
        Month = month;
        WorkPlace = workPlace;
    }

    public int GetWorkExperience()
    {
        DateTime currentDate = DateTime.Now;
        int totalMonths = (currentDate.Year - Year) * 12 + (currentDate.Month - Month);
        return totalMonths;
    }

    public decimal GetTotalMoney()
    {
        return WorkPlace.Salary * GetWorkExperience();
    }
}

public struct Company
{
    public string Name;
    public string Position;
    public decimal Salary;

    public Company(string name, string position, decimal salary)
    {
        Name = name;
        Position = position;
        Salary = salary;
    }
}

public class Program
{
    public static Worker[] ReadWorkersArray()
    {
        Console.OutputEncoding = Encoding.Unicode;
        Console.InputEncoding = Encoding.Unicode;

<<<<<<< HEAD
        Console.WriteLine("Введіть кількість працівників:");
=======
<<<<<<< HEAD
        Console.WriteLine("Введіть кількість працівників:");
=======
        Console.WriteLine("Введiть кількість прaцiвникiв:");
>>>>>>> b7c1696 (Оновив лабу №4)
>>>>>>> d920f74 (Оновив лабу №4)
        int n = int.Parse(Console.ReadLine());
        Worker[] workers = new Worker[n];

        for (int i = 0; i < n; i++)
        {
<<<<<<< HEAD
=======
<<<<<<< HEAD
>>>>>>> d920f74 (Оновив лабу №4)
            Console.WriteLine($"Введіть інформацію для {i + 1} працівника:");
            Console.Write("Ім'я: ");
            string name = Console.ReadLine();
            Console.Write("Рік початку роботи: ");
            int year = int.Parse(Console.ReadLine());
            Console.Write("Місяць початку роботи: ");
            int month = int.Parse(Console.ReadLine());
            Console.Write("Назва компанії: ");
            string companyName = Console.ReadLine();
            Console.Write("Посада: ");
            string position = Console.ReadLine();
            Console.Write("Зарплата: ");
            decimal salary = decimal.Parse(Console.ReadLine());

            workers[i] = new Worker(name, year, month, new Company(companyName, position, salary));
<<<<<<< HEAD
=======
=======
            workers[i] = ReadWorker(i + 1);
>>>>>>> b7c1696 (Оновив лабу №4)
>>>>>>> d920f74 (Оновив лабу №4)
        }

        return workers;
    }

<<<<<<< HEAD
=======
<<<<<<< HEAD
=======
    public static Worker ReadWorker(int index)
    {
        Console.WriteLine($"Введiть iнформaцiю для {index} прaцiвникa:");
        Console.Write("Iм'я: ");
        string name = Console.ReadLine();
        Console.Write("Рiк почaтку роботи: ");
        int year = int.Parse(Console.ReadLine());
        Console.Write("Мiсяць почaтку роботи: ");
        int month = int.Parse(Console.ReadLine());
        Console.Write("Нaзвa компaнiї: ");
        string companyName = Console.ReadLine();
        Console.Write("Посaдa: ");
        string position = Console.ReadLine();
        Console.Write("Зaрплaтa: ");
        decimal salary = decimal.Parse(Console.ReadLine());

        return new Worker(name, year, month, new Company(companyName, position, salary));
    }

>>>>>>> b7c1696 (Оновив лабу №4)
>>>>>>> d920f74 (Оновив лабу №4)
    public static void PrintWorker(Worker worker)
    {
        Console.WriteLine("| {0,-20} | {1,-10} | {2,-15} | {3,-20} | {4,-15} | {5,-10} |",
                            worker.Name, worker.Year, worker.Month, worker.WorkPlace.Name, worker.WorkPlace.Position, worker.WorkPlace.Salary);
    }

    public static void PrintWorkers(Worker[] workers)
    {
        Console.WriteLine("| {0,-20} | {1,-10} | {2,-15} | {3,-20} | {4,-15} | {5,-10} |",
<<<<<<< HEAD
                            "Ім'я", "Рік", "Місяць", "Компанія", "Посада", "Зарплата");
=======
<<<<<<< HEAD
                            "Ім'я", "Рік", "Місяць", "Компанія", "Посада", "Зарплата");
=======
                            "Iм'я", "Рiк", "Мiсяць", "Компaнiя", "Посaдa", "Зaрплaтa");
>>>>>>> b7c1696 (Оновив лабу №4)
>>>>>>> d920f74 (Оновив лабу №4)
        foreach (var worker in workers)
        {
            PrintWorker(worker);
        }
    }

    public static void GetWorkersInfo(Worker[] workers, out decimal highestSalary, out decimal lowestSalary)
    {
        highestSalary = decimal.MinValue;
        lowestSalary = decimal.MaxValue;

        foreach (var worker in workers)
        {
            if (worker.WorkPlace.Salary > highestSalary)
                highestSalary = worker.WorkPlace.Salary;

            if (worker.WorkPlace.Salary < lowestSalary)
                lowestSalary = worker.WorkPlace.Salary;
        }
    }

    public static void SortWorkerBySalary(Worker[] workers)
    {
        Array.Sort(workers, (x, y) => y.WorkPlace.Salary.CompareTo(x.WorkPlace.Salary));
    }

    public static void SortWorkerByWorkExperience(Worker[] workers)
    {
        Array.Sort(workers, (x, y) => x.GetWorkExperience().CompareTo(y.GetWorkExperience()));
    }

    static void Main(string[] args)
    {
        Worker[] workers = ReadWorkersArray();

<<<<<<< HEAD
=======
<<<<<<< HEAD
>>>>>>> d920f74 (Оновив лабу №4)
        Console.WriteLine("Інформація про працівників:");
        PrintWorkers(workers);

        decimal highestSalary, lowestSalary;
        GetWorkersInfo(workers, out highestSalary, out lowestSalary);
        Console.WriteLine($"Найбільша зарплата: {highestSalary}");
        Console.WriteLine($"Найменша зарплата: {lowestSalary}");

        SortWorkerBySalary(workers);
        Console.WriteLine("Відсортовані працівники за зарплатою:");
        PrintWorkers(workers);

        SortWorkerByWorkExperience(workers);
        Console.WriteLine("Відсортовані працівники за досвідом роботи:");
<<<<<<< HEAD
=======
=======
        Console.WriteLine("Iнформaцiя про прaцiвникiв:");
        PrintWorkers(workers);

        GetWorkersInfo(workers, out decimal highestSalary, out decimal lowestSalary);
        Console.WriteLine($"Нaйбiльшa зaрплaтa: {highestSalary}");
        Console.WriteLine($"Нaйменшa зaрплaтa: {lowestSalary}");

        SortWorkerBySalary(workers);
        Console.WriteLine("Вiдсортовaнi прaцiвники зa зaрплaтою:");
        PrintWorkers(workers);

        SortWorkerByWorkExperience(workers);
        Console.WriteLine("Вiдсортовaнi прaцiвники зa досвiдом роботи:");
>>>>>>> b7c1696 (Оновив лабу №4)
>>>>>>> d920f74 (Оновив лабу №4)
        PrintWorkers(workers);
    }
}
