namespace modul10_103022300023
{
    public class Movie
    {
        public string title { get; set; }

        public string director { get; set; }

        public List<string> stars { get; set; }

        public string description { get; set; }

        public Movie(string title, List<string> stars, string description, string director) {
            this.title = title;
            this.stars = stars;
            this.description = description;
            this.director = director; 
        }
    }

}

