namespace Rodfy.Models;

class Singer
{
    private List<Album> albuns = new List<Album>();
    private List<int> score = new List<int>();

    public Singer(string name)
    {
        Name = name;
    }

    public string Name { get; }
    public double Average => score.Average();
    public List<Album> Albuns => albuns;

    public void AddAlbum(Album album) 
    { 
        albuns.Add(album);
    }

    public void AddScore(int score)
    {
        this.score.Add(score);
    }

    public void ExibirDiscografia()
    {
        Console.WriteLine($"Singer's discography {Name}");
        foreach (Album album in albuns)
        {
            Console.WriteLine($"Álbum: {album.Name} ({album.TotalTime})");
        }
    }
}