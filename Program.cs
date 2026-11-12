Hero yaroslav = new Hero("Ярослав", 100);
Hero anastasia = new Hero("Анастасия", 90);
Hero artem = new Hero("Артём", 120);

yaroslav.Health = 75;

Console.WriteLine(">>> Герой 1 <<<");
Console.WriteLine($"Имя: {yaroslav.Name}");
Console.WriteLine($"Здоровье: {yaroslav.Health}");
Console.WriteLine($"Уровень: {yaroslav.Level}");
Console.WriteLine($"Опыт: {yaroslav.Experience}");

Console.WriteLine();

Console.WriteLine(">>> Герой 2 <<<");
Console.WriteLine($"Имя: {anastasia.Name}");
Console.WriteLine($"Здоровье: {anastasia.Health}");
Console.WriteLine($"Уровень: {anastasia.Level}");
Console.WriteLine($"Опыт: {anastasia.Experience}");

Console.WriteLine();

Console.WriteLine(">>> Герой 3 <<<");
Console.WriteLine($"Имя: {artem.Name}");
Console.WriteLine($"Здоровье: {artem.Health}");
Console.WriteLine($"Уровень: {artem.Level}");
Console.WriteLine($"Опыт: {artem.Experience}");

Movies spiderMan = new Movies("Человек-паук: Нет пути домой", "Фантастика", 2021, 8.3);
Movies scream = new Movies("Крик", "Ужасы", 1996, 6.6);
Movies guardians2 = new Movies("Стражи Галактики. Часть 2", "Фантастика", 2017, 7.6);

scream.Rating =7.2;

Console.WriteLine(">>> Фильм 1 <<<");
Console.WriteLine($"Название: {spiderMan.Name}");
Console.WriteLine($"Жанр: {spiderMan.Genre}");
Console.WriteLine($"Год: {spiderMan.Year}");
Console.WriteLine($"Рейтинг: {spiderMan.Rating}");

Console.WriteLine();

Console.WriteLine(">>> Фильм 2 <<<");
Console.WriteLine($"Название: {scream.Name}");
Console.WriteLine($"Жанр: {scream.Genre}");
Console.WriteLine($"Год: {scream.Year}");
Console.WriteLine($"Рейтинг: {scream.Rating}");

Console.WriteLine();

Console.WriteLine(">>> Фильм 3 <<<");
Console.WriteLine($"Название: {guardians2.Name}");
Console.WriteLine($"Жанр: {guardians2.Genre}");
Console.WriteLine($"Год: {guardians2.Year}");
Console.WriteLine($"Рейтинг: {guardians2.Rating}");