// Probe.Run(); 
Hero yaroslav = new Hero("Ярослав", 100);
Hero anastasia = new Hero("Анастасия", 90);
Hero artem = new Hero("Артём", 120);
Hero alexander = new Hero("   Александр   ", 150);
Hero sergey = new Hero("Сергей", 110);

alexander.TakeDamage(10);
alexander.Heal(10);

Guild guild = new Guild("Гильдия героев");
guild.AddHero(yaroslav);
guild.AddHero(anastasia);
guild.AddHero(artem);
guild.AddHero(alexander);
guild.AddHero(sergey);

List<Hero> members = guild.GetMembers();
Console.WriteLine($">>> {guild.Name}: перекличка <<<");
Console.WriteLine($"Участников: {guild.MemberCount}");

if (members.Count > 0) {
    Console.WriteLine($"Первый: {members[0].Name}");
    Console.WriteLine($"Последний: {members[members.Count - 1].Name}");
}

Console.WriteLine();
foreach (Hero hero in members) {
    Console.WriteLine(hero.GetInfo());
    Console.WriteLine();
}

Hero? found = guild.FindHeroByName(" аРтЁм ");
if (found != null) {
    Console.WriteLine($"Найден по запросу « аРтЁм »: {found.Name}");
} else {
    Console.WriteLine("По запросу « аРтЁм » никого нет.");
}

Console.WriteLine($"Повтор Александра принят: {guild.AddHero(alexander)}");
Console.WriteLine($"Удалён отсутствующий: {guild.RemoveHero("Борис")}");
Console.WriteLine($"Участников после проверок: {guild.MemberCount}");

Console.WriteLine($"Могут нести тяжёлые ящики (здоровье от 120): {guild.CountHealthy(120)}");

Hero? strongest = guild.FindStrongest();
if (strongest != null) {
    Console.WriteLine($"Самый здоровый: {strongest.Name} ({strongest.Health})");
}


MovieCatalog catalog = new MovieCatalog("Мой каталог");

Movies spiderMan = new Movies("Человек-паук: Нет пути домой", "Фантастика", 2021, 8.3);
Movies scream = new Movies("Крик", "Ужасы", 1996, 6.6);
Movies guardians2 = new Movies("Стражи Галактики. Часть 2", "Фантастика", 2017, 7.6);

Console.WriteLine($"Добавлен Человек-паук: {catalog.AddMovie(spiderMan)}");
Console.WriteLine($"Добавлен Крик: {catalog.AddMovie(scream)}");
Console.WriteLine($"Добавлен Стражи Галактики: {catalog.AddMovie(guardians2)}");


Movies spiderManCopy = new Movies(" человек-паук: нет пути домой ", "Боевик", 2021, 9.0);
Console.WriteLine($"Добавлена копия Человека-паука: {catalog.AddMovie(spiderManCopy)}");

Movies? foundMovie = catalog.FindMovieByName("  крИк  ");
if (foundMovie != null) {
    Console.WriteLine($"Найден фильм: {foundMovie.Name}, Рейтинг: {foundMovie.Rating}");
} else {
    Console.WriteLine("Фильм не найден");
}

Movies? notFound = catalog.FindMovieByName("Аватар");
if (notFound == null) {
    Console.WriteLine("Аватар не найден в каталоге (вернулся null)");
}

Console.WriteLine($"Количество до удаления: {catalog.MovieCount}");
Console.WriteLine($"Удалён Человек-паук: {catalog.RemoveMovie("Человек-паук: Нет пути домой")}");
Console.WriteLine($"Количество после удаления: {catalog.MovieCount}");

public class MovieCatalog {
    private List<Movies> _movies = new List<Movies>();
    
    public string Name { get; private set; }
    
    public int MovieCount {
        get { return _movies.Count; }
    }

    public MovieCatalog(string name) {
        Name = name;
    }

    public bool AddMovie(Movies movie) {
        // Ключ - название фильма
        if (FindMovieByName(movie.Name) != null) {
            return false; 
        }
        _movies.Add(movie);
        return true;
    }

    public Movies? FindMovieByName(string name) {
        if (string.IsNullOrWhiteSpace(name)) {
            return null;
        }
        string searchName = name.Trim();

        foreach (Movies m in _movies) {
            if (string.Equals(m.Name, searchName, StringComparison.OrdinalIgnoreCase)) {
                return m;
            }
        }
        return null;
    }

    public bool RemoveMovie(string name) {
        Movies? m = FindMovieByName(name);
        if (m == null) return false;
        return _movies.Remove(m);
    }
}