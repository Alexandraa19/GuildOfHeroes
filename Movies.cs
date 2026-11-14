public class Movies {
    private string _name = "Безымянный фильм";

    public string Name {
        get { return _name; }
        private set {
            if (string.IsNullOrWhiteSpace(value)) {
                _name = "Безымянный фильм";
                return;
            }
            _name = value.Trim();
        }
    }

    public string Genre { get; private set; }
    public int Year { get; private set; }
    public double Rating { get; private set; }

    public Movies(string name, string genre, int year, double rating) {
        Name = name;  
        Genre = genre;
        Year = year;

        Rating = rating;
        if (Rating < 0) {
            Rating = 0;
        }
        if (Rating > 10) {
            Rating = 10;
        }
    }
    public void ChangeRating(double newRating) {

        if (newRating < 0 || newRating > 10) {
            return;
        }

        Rating = newRating;
    }
    public bool IsModern() {
        return Year >= 2000;
    }
}