namespace Rodfy.Models;

public class Assessment
{
    public int score { get; }

    public Assessment(int score)
    {
        this.score = score;
    }

    public static Assessment Parse(string text)
    {
        int score = int.Parse(text);
        return new Assessment(score);
    }
}