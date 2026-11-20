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

Console.WriteLine($">>> {guild.Name}: участников {guild.MemberCount} <<<");
Console.WriteLine();

QuestBoard board = new QuestBoard(guild);

Quest floatQuest = new Quest(101, "Вернуть поплавок", 100, 30);
Console.WriteLine($"Поручение добавлено: {board.AddQuest(floatQuest)}");
Console.WriteLine($">>> №{floatQuest.Id}: {floatQuest.Title} <<<");

Console.WriteLine($"Назначение Сергея: {board.TryAssign(101, " сЕрГеЙ ")}");
Hero? assigned = floatQuest.AssignedHero;
if (assigned != null) {
    Console.WriteLine($"Исполнитель: {assigned.Name}");
}
Console.WriteLine($"Опыт после назначения: {sergey.Experience}");

Console.WriteLine($"Завершение: {board.TryComplete(101)}");
Console.WriteLine($"Опыт после завершения: {sergey.Experience}");
Console.WriteLine($"Повторное завершение: {board.TryComplete(101)}");
Console.WriteLine($"Опыт после повтора: {sergey.Experience}");

Console.WriteLine();
Console.WriteLine(floatQuest.GetInfo());
Console.WriteLine(sergey.GetInfo());




Console.WriteLine("\n мой проект (Операция с фильмом) ");

MovieCatalog catalog = new MovieCatalog("Мой каталог");
Movies spiderMan = new Movies("Человек-паук: Нет пути домой", "Фантастика", 2021, 8.3);
Movies scream = new Movies("Крик", "Ужасы", 1996, 6.6);
catalog.AddMovie(spiderMan);
catalog.AddMovie(scream);


MovieOperation watchOp = new MovieOperation(1, "Просмотр", 8.0); 

Console.WriteLine($"Старт операции с Криком: {watchOp.TryStart(scream)}"); 
Console.WriteLine($"Старт операции с Человеком-пауком: {watchOp.TryStart(spiderMan)}");
Console.WriteLine($"Завершение операции: {watchOp.TryFinish()}");
Console.WriteLine($"Новый рейтинг Человека-паука в каталоге: {catalog.FindMovieByName("Человек-паук: Нет пути домой")?.Rating}");
Console.WriteLine($"Повторное завершение: {watchOp.TryFinish()}");

public class MovieOperation {
    public int Id { get; private set; }
    public string Title { get; private set; }
    public double MinRating { get; private set; }
    public Movies? TargetMovie { get; private set; }
    public bool IsFinished { get; private set; }

    public MovieOperation(int id, string title, double minRating) {
        Id = id;
        Title = title;
        MinRating = minRating;
        TargetMovie = null;
        IsFinished = false;
    }

    public bool TryStart(Movies movie) {
        if (IsFinished) return false;
        if (TargetMovie != null) return false;
        if (movie.Rating < MinRating) return false;

        TargetMovie = movie;
        return true;
    }

    public bool TryFinish() {
        if (IsFinished) return false;
        if (TargetMovie == null) return false;

        TargetMovie.ChangeRating(TargetMovie.Rating + 0.5); 
        IsFinished = true;
        return true;
    }
}

public class MovieCatalog {
    private List<Movies> _movies = new List<Movies>();
    public string Name { get; private set; }
    public int MovieCount { get { return _movies.Count; } }

    public MovieCatalog(string name) { Name = name; }

    public bool AddMovie(Movies movie) {
        if (FindMovieByName(movie.Name) != null) return false;
        _movies.Add(movie);
        return true;
    }

    public Movies? FindMovieByName(string name) {
        if (string.IsNullOrWhiteSpace(name)) return null;
        string searchName = name.Trim();
        foreach (Movies m in _movies) {
            if (string.Equals(m.Name, searchName, StringComparison.OrdinalIgnoreCase)) return m;
        }
        return null;
    }
}