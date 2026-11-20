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

board.AddQuest(new Quest(101, "Вернуть поплавок", 100, 30));
board.TryAssign(101, "Сергей");
board.TryComplete(101);
board.AddQuest(new Quest(102, "Проверить нижнюю площадку", 100, 10));
board.AddQuest(new Quest(103, "Снять мерки для насоса больницы", 100, 20));
board.AddQuest(new Quest(104, "Обследовать ответвление", 100, 15));

Console.WriteLine($"Сергей на №102: {board.TryAssign(102, "Сергей")}");
Console.WriteLine($"Сергей на №103: {board.TryAssign(103, "Сергей")}");
Console.WriteLine($"Отмена №102: {board.TryCancel(102)}");
Console.WriteLine($"Сергей на №103: {board.TryAssign(103, "Сергей")}");
Console.WriteLine($"Завершение №103: {board.TryComplete(103)}");
Console.WriteLine($"Ярослав на №104: {board.TryAssign(104, "Ярослав")}");
Console.WriteLine($"Удалить Сергея: {board.TryRemoveMember("Сергей")}");

Console.WriteLine();
List<Quest> quests = board.GetQuests();
foreach (Quest quest in quests) {
    Console.WriteLine(quest.GetInfo());
}
Console.WriteLine($"Открыто: {board.CountByStatus(QuestStatus.Open)}, " +
                  $"назначено: {board.CountByStatus(QuestStatus.Assigned)}, " +
                  $"выполнено: {board.CountByStatus(QuestStatus.Completed)}, " +
                  $"отменено: {board.CountByStatus(QuestStatus.Cancelled)}");

Quest? yaroslavQuest = board.FindActiveQuest("Ярослав");
if (yaroslavQuest != null) {
    Console.WriteLine($"Ярослав сейчас: №{yaroslavQuest.Id} «{yaroslavQuest.Title}»");
}
Quest? sergeyQuest = board.FindActiveQuest("Сергей");
if (sergeyQuest == null) {
    Console.WriteLine("Сергей сейчас: свободен");
}

Console.WriteLine();
Console.WriteLine(sergey.GetInfo());

Console.WriteLine("\n мой проект (Состояния операции)");

Movies spiderMan = new Movies("Человек-паук: Нет пути домой", "Фантастика", 2021, 8.3);
Movies scream = new Movies("Крик", "Ужасы", 1996, 6.6);

MovieOperation watchOp = new MovieOperation(1, "Вечерний просмотр");

Console.WriteLine($"Старт просмотра Человека-паука: {watchOp.TryStart(spiderMan)}");

Console.WriteLine($"Повторный старт: {watchOp.TryStart(spiderMan)}");

Console.WriteLine($"Завершение просмотра: {watchOp.TryFinish()}");

MovieOperation watchOp2 = new MovieOperation(2, "Второй просмотр");
Console.WriteLine($"Старт новой операции на того же фильма: {watchOp2.TryStart(spiderMan)}");

public enum MovieStatus {
    Open,
    Active,
    Finished,
    Cancelled
}

public class MovieOperation {
    public int Id { get; private set; }
    public string Title { get; private set; }
    public Movies? TargetMovie { get; private set; }
    public MovieStatus Status { get; private set; }

    public MovieOperation(int id, string title) {
        Id = id;
        Title = title;
        TargetMovie = null;
        Status = MovieStatus.Open;
    }

    public bool TryStart(Movies movie) {
        if (Status != MovieStatus.Open) return false;
        
        TargetMovie = movie;
        Status = MovieStatus.Active;
        return true;
    }
    
    public bool TryFinish() {
        if (Status != MovieStatus.Active) return false;
        if (TargetMovie == null) return false;
        TargetMovie.ChangeRating(TargetMovie.Rating + 0.5);
        
        Status = MovieStatus.Finished;
        return true;
    }
}