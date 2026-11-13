public class Movies {
    public string Name;
    public string Genre;
    public int Year;
    public double Rating;
  
    public Movies(string name, string genre, int year, double rating) {
        Name = name;
        Genre = genre;
        Year = year;
        Rating = rating;   
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