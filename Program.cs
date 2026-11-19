// Probe.Run(); 
Hero yaroslav = new Hero("Ярослав", 100);
Hero anastasia = new Hero("Анастасия", 90);
Hero artem = new Hero("Артём", 120);
Hero alexander = new Hero("   Александр   ", 150);
Hero sergey = new Hero("Сергей", 110);

alexander.TakeDamage(10);
alexander.Heal(10);

Guild guild = new Guild("Гильдия героев");
guild.Heroes.Add(yaroslav);
guild.Heroes.Add(anastasia);
guild.Heroes.Add(artem);
guild.Heroes.Add(alexander);
guild.Heroes.Add(sergey);

Console.WriteLine($">>> {guild.Name}: перекличка <<<");
Console.WriteLine($"Участников: {guild.Heroes.Count}");

if (guild.Heroes.Count > 0) {
    Console.WriteLine($"Первый: {guild.Heroes[0].Name}");
    Console.WriteLine($"Последний: {guild.Heroes[guild.Heroes.Count - 1].Name}");
}

Console.WriteLine();
foreach (Hero hero in guild.Heroes) {
    Console.WriteLine(hero.GetInfo());
    Console.WriteLine();
}

int strongCount = 0;
foreach (Hero hero in guild.Heroes) {
    if (hero.Health >= 120) {
        strongCount += 1;
    }
}
Console.WriteLine($"Могут нести тяжёлые ящики (здоровье от 120): {strongCount}");


if (guild.Heroes.Count > 0) {
    Hero strongest = guild.Heroes[0];
    foreach (Hero hero in guild.Heroes) {
        if (hero.Health > strongest.Health) {
            strongest = hero;
        }
    }
    Console.WriteLine($"самый здоровый: {strongest.Name} ({strongest.Health})");
}


Console.WriteLine("\n мой проект ");
Movies spiderMan = new Movies("Человек-паук: Нет пути домой", "Фантастика", 2021, 8.3);
Movies scream = new Movies("Крик", "Ужасы", 1996, 6.6);
Movies guardians2 = new Movies("Стражи Галактики. Часть 2", "Фантастика", 2017, 7.6);

List<Movies> myMovies = new List<Movies>();
myMovies.Add(spiderMan);
myMovies.Add(scream);
myMovies.Add(guardians2);

Console.WriteLine($"всего фильмов: {myMovies.Count}");

if (myMovies.Count > 0) {
    Console.WriteLine($"Первый: {myMovies[0].Name}");
    Console.WriteLine($"Последний: {myMovies[myMovies.Count - 1].Name}");
}

Console.WriteLine();
foreach (Movies m in myMovies) {
    Console.WriteLine($">>> {m.Name} <<<");
    Console.WriteLine($"Рейтинг: {m.Rating}");
    Console.WriteLine($"Современный: {m.IsModern()}");
    Console.WriteLine();
}


Movies badMovie = new Movies("фильм", "Тест", 2026, 15.0);
myMovies.Add(badMovie);
Console.WriteLine($"фильм с недопустимым рейтингом но конструктор исправил его на: {myMovies[myMovies.Count - 1].Rating}");
int highRatingCount = 0;
foreach (Movies m in myMovies) {
    if (m.Rating > 7.0) {
        highRatingCount++;
    }
}
Console.WriteLine($"Фильмов с рейтингом выше 7.0: {highRatingCount}");
spiderMan.ChangeRating(9.5);
Console.WriteLine($"Рейтинг Человека-паука после изменения: {myMovies[0].Rating}");

myMovies[0].ChangeRating(15.0);
Console.WriteLine($"Рейтинг Человека-паука после недопустимого изменения: {myMovies[0].Rating}");