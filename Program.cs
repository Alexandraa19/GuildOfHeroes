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
bool yaroslavAlive = yaroslav.IsAlive();
Console.WriteLine($"Ярослав жив: {yaroslavAlive}");
Console.WriteLine($"Артём жив: {artem.IsAlive()}");

if (yaroslavAlive) {
    Console.WriteLine("Ярослав может продолжать приключение.");
} else {
    Console.WriteLine("Ярослав больше не может сражаться.");
}
string info = yaroslav.GetInfo();
Console.WriteLine("Строка получена. Сейчас выведем её:");
Console.WriteLine(info);

Console.WriteLine();
Console.WriteLine(anastasia.GetInfo());
Console.WriteLine();
Console.WriteLine(artem.GetInfo());



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