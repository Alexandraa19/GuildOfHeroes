Hero yaroslav = new Hero("Ярослав", 100);
Hero anastasia = new Hero("Анастасия", 90);
Hero artem = new Hero("Артём", 120);
Hero alexander = new Hero("   Александр   ", 150);
alexander.TakeDamage(10);
alexander.Heal(10);
Console.WriteLine(">>> Участники готовы <<<");
Console.WriteLine();
Hero alexander = new Hero("Александр", 150);

Console.WriteLine(yaroslav.GetInfo());
Console.WriteLine();
Console.WriteLine(anastasia.GetInfo());
Console.WriteLine();
Console.WriteLine(artem.GetInfo());
Console.WriteLine();
Console.WriteLine(alexander.GetInfo());
Console.WriteLine($"Предел здоровья Александра: {alexander.MaxHealth}");


Movies spiderMan = new Movies("Человек-паук: Нет пути домой", "Фантастика", 2021, 8.3);
Movies scream = new Movies("Крик", "Ужасы", 1996, 6.6);
Movies guardians2 = new Movies("Стражи Галактики. Часть 2", "Фантастика", 2017, 7.6);

Console.WriteLine();
Console.WriteLine(alexander.GetInfo());


Console.WriteLine();
Console.WriteLine(">>> Фильм 2: Крик <<<");
Console.WriteLine($"Рейтинг до: {scream.Rating}");
scream.ChangeRating(7.2); 
Console.WriteLine($"После допустимого (7.2): {scream.Rating}");
scream.ChangeRating(15);
Console.WriteLine($"После недопустимого (15): {scream.Rating}");
Console.WriteLine($"Современный: {scream.IsModern()}");
Movies spiderMan = new Movies("Человек-паук: Нет пути домой", "Фантастика", 2021, 8.3);
 Movies scream = new Movies("Крик", "Ужасы", 1996, 6.6);
 Movies guardians2 = new Movies("Стражи Галактики. Часть 2", "Фантастика", 2017, 7.6);


 scream.Rating =7.2;
 Console.WriteLine();
 Console.WriteLine(">>> Фильм 1: Человек-паук <<<");
 Console.WriteLine($"Рейтинг до: {spiderMan.Rating}");
 spiderMan.ChangeRating(9.1);
 Console.WriteLine($"После допустимого (9.1): {spiderMan.Rating}");
 spiderMan.ChangeRating(-5);
 Console.WriteLine($"После недопустимого (-5): {spiderMan.Rating}");
Console.WriteLine($"Современный: {spiderMan.IsModern()}");

<<<<<<< HEAD
Console.WriteLine();
Console.WriteLine(">>> Проверка конструктора <<<");
Movies badMovie = new Movies(" Плохой фильм ", "Тест", 2023, 15.0);
Console.WriteLine($"Имя: [{badMovie.Name}]"); 
Console.WriteLine($"Рейтинг из 15.0 стал: {badMovie.Rating}"); 

Console.WriteLine();
Console.WriteLine($"Человек-паук: рейтинг {spiderMan.Rating}, год {spiderMan.Year}");
Console.WriteLine($"Крик: рейтинг {scream.Rating}, год {scream.Year}");
Console.WriteLine($"Стражи галактики. часть 2: рейтинг {guardians2.Rating}, год {guardians2.Year}");

 Console.WriteLine();
 Console.WriteLine(">>> Фильм 2: Крик <<<");
 Console.WriteLine($"Рейтинг до: {scream.Rating}");
 scream.ChangeRating(7.2);
 Console.WriteLine($"После допустимого (7.2): {scream.Rating}");
 scream.ChangeRating(15);
 Console.WriteLine($"После недопустимого (15): {scream.Rating}");
 Console.WriteLine($"Современный: {scream.IsModern()}");

 Console.WriteLine();
 Console.WriteLine(">>> Фильм 3: Стражи Галактики. Часть 2 <<<");
 Console.WriteLine($"Рейтинг: {guardians2.Rating}");
 Console.WriteLine($"Современный: {guardians2.IsModern()}");

 Console.WriteLine();
Console.WriteLine($"Человек-паук: рейтинг {spiderMan.Rating}, год {spiderMan.Year}");
 Console.WriteLine($"Крик: рейтинг {scream.Rating}, год {scream.Year}");
 Console.WriteLine($"Стражи галактики. часть 2:рейтинг {guardians2.Rating}, год {guardians2.Year}");
