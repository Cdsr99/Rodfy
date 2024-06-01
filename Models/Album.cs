namespace Rodfy.Models;

class Album
{
    private List<Music> _musics = new List<Music>();

    public Album(string name)
    {
        Name = name;
    }

    public string Name { get; }
    public int TotalTime => _musics.Sum(m => m.Duracao);
    public List<Music> Musics => _musics;

    public void AddSong(Music song)
    {
        _musics.Add(song);
    }

    public void ShowAlbunsSongs()
    {
        Console.WriteLine($"List of the album {Name}:\n");
        foreach (var song in _musics)
        {
            Console.WriteLine($"Song: {song.Nome}");
        }
        Console.WriteLine($"\nYou need {TotalTime} minutes to listing to this album");
    }
}