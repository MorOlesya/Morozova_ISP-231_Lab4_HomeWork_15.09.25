namespace Morozova_ISP_231_Lab4_HomeWork_15._09._25;

class Program
{
    static void Main(string[] args)
    {
        //Задание 1
        Console.WriteLine("Задание 1");
        List<string> things = new List<string>();
        things.Add("sword");
        things.Add("shield");
        things.Add("potion");
        things.Add("sword");
        things.Add("potion");
        things.Add("potion");
        foreach (string thing in things)
        {
            Console.WriteLine(thing);
        }
        
        //Задание 2
        Console.WriteLine();
        Console.WriteLine("Задание 2");
        int[] points = [10, 20, 15, 30, 25];
        int sum_points = 0;
        foreach (int point in points)
        {
            sum_points += point;
        }
        Console.WriteLine($"Общее количество очков: {sum_points}");
        
        //Задание 3
        Console.WriteLine();
        Console.WriteLine("Задание 3");
        int[] list_3 = [1, 3, 7, 2, 5];
        int max_3 = 0;
        foreach (int num in list_3)
        {
            if (max_3 < num)
                max_3 = num;
        }
        Console.WriteLine($"Макс элемент: {max_3}");
        
        //Задание 4
        Console.WriteLine();
        Console.WriteLine("Задание 4");
        int[] list_4 = [1, 2, 3, 4, 5];
        int even_num = 0;
        int odd_num = 0;
        foreach (int num in list_4)
        {
            if (num % 2 == 0)
                even_num += 1;
            else
            {
                odd_num += 1;
            }
        }
        Console.WriteLine($"Количество чётных чисел: {even_num}");
        Console.WriteLine($"Количество нечётных чисел: {odd_num}");
        
        //Задание 5
        Console.WriteLine();
        Console.WriteLine("Задание 5");
        int[] times = [120, 95, 110, 105, 100];
        int min_time = 100000;
        foreach (int num in times)
        {
            if (num < min_time)
                min_time = num;
        }
        Console.WriteLine($"Минимальное время прохождения: {min_time}");
        
        //Задание 6
        Console.WriteLine();
        Console.WriteLine("Задание 6");
        string[] games = ["win", "loss", "win", "win", "loss"];
        int win = 0;
        int loss = 0;
        foreach (string game in games)
        {
            if (game == "win")
                win += 1;
            else
                loss += 1;
        }
        Console.WriteLine($"Количество побед: {win}");
        Console.WriteLine($"Количество поражений: {loss}");
        
        //Задание 7
        Console.WriteLine();
        Console.WriteLine("Задание 7");
        int[] game_points = [15, 20, 25, 30, 10];
        int sum_game_points = 0;
        int count_game_points = 0;
        foreach (int point in game_points)
        {
            sum_game_points += point;
            count_game_points += 1;
        }
        Console.WriteLine($"Среднее количество очков: {sum_game_points / count_game_points}");
        
        //Задание 8
        Console.WriteLine();
        Console.WriteLine("Задание 8");
        string[] inventory = ["Меч", "Ласточка", "Бомба", "Зелье Гром", "Ласточка"];
        for (int i = 0; i < inventory.Length; i++)
        {
            if (inventory[i] == "Ласточка")
                inventory[i] = "Кошка";
        }

        foreach (string thing in inventory)
        {
            Console.WriteLine(thing);
        }
        
        //Задание 9
        Console.WriteLine();
        Console.WriteLine("Задание 9");
        string[] companions = ["Garrus", "Tali", "Mordin", "Grunt", "Jack"];
        string[] roles = ["Лидер команды", "Техник", "Биотик", "Солдат", "Поддержка"];
        for (int i = 0; i < roles.Length; i++)
        {
            Console.WriteLine($"{roles[i]}: {companions[i]}");
        }
    }
}