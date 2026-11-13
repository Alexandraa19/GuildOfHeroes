Hero yaroslav = new Hero("Ярослав", 100);
Hero anastasia = new Hero("Анастасия", 90);
Hero artem = new Hero("Артём", 120);
Console.WriteLine($"До вызовов: {yaroslav.Health}, {anastasia.Health}, {artem.Health}");

yaroslav.TakeDamage(25);
anastasia.TakeDamage(30);

Console.WriteLine($"После вызовов: {yaroslav.Health}, {anastasia.Health}, {artem.Health}");
yaroslav.TakeDamage(-20);
Console.WriteLine($"После неверного урона: {yaroslav.Health}");

artem.TakeDamage(200);
Console.WriteLine($"После сильного урона, Артём: {artem.Health}");
yaroslav.Heal(10);
yaroslav.GainExperience(40);
yaroslav.GainExperience(25);

Console.WriteLine($"После лечения, Ярослав: {yaroslav.Health}");
Console.WriteLine($"Опыт Ярослава: {yaroslav.Experience}");



// Movies spiderMan = new Movies("Человек-паук: Нет пути домой", "Фантастика", 2021, 8.3);
// Movies scream = new Movies("Крик", "Ужасы", 1996, 6.6);
// Movies guardians2 = new Movies("Стражи Галактики. Часть 2", "Фантастика", 2017, 7.6);

// scream.Rating =7.2;

// Console.WriteLine(">>> Фильм 1 <<<");
// Console.WriteLine($"Название: {spiderMan.Name}");
// Console.WriteLine($"Жанр: {spiderMan.Genre}");
// Console.WriteLine($"Год: {spiderMan.Year}");
// Console.WriteLine($"Рейтинг: {spiderMan.Rating}");

// Console.WriteLine();

// Console.WriteLine(">>> Фильм 2 <<<");
// Console.WriteLine($"Название: {scream.Name}");
// Console.WriteLine($"Жанр: {scream.Genre}");
// Console.WriteLine($"Год: {scream.Year}");
// Console.WriteLine($"Рейтинг: {scream.Rating}");

// Console.WriteLine();

// Console.WriteLine(">>> Фильм 3 <<<");
// Console.WriteLine($"Название: {guardians2.Name}");
// Console.WriteLine($"Жанр: {guardians2.Genre}");
// Console.WriteLine($"Год: {guardians2.Year}");
// Console.WriteLine($"Рейтинг: {guardians2.Rating}");