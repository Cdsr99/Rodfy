namespace Rodfy.Models;

public class Singer
{
    private List<Album> albuns = new List<Album>();
    private List<Assessment> score = new List<Assessment>();

    public Singer(string name)
    {
        Name = name;
    }

    public string Name { get; }

    public double Average
    {
        get
        {
            if (score.Count == 0) return 0;
            else return score.Average(a => a.score);
        }
    }
    public List<Album> Albuns => albuns;

    public void AddAlbum(Album album) 
    { 
        albuns.Add(album);
    }

    public void AddScore(Assessment score)
    {
        this.score.Add(score);
    }

    public void ShowDetails()
    {
        Console.WriteLine($"Singer's discography {Name}");
        foreach (Album album in albuns)
        {
            Console.WriteLine($"Album: {album.Name} ({album.TotalTime})");
        }

        Console.WriteLine($"\nand the score is {this.Average}");
    }
}