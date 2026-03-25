using System;

public class MusicTrack
{
    public string Artist { get; set; }
    public string Title { get; set; }
    public string Genre { get; set; }
    public int Year { get; set; }

    public MusicTrack(string artist, string title, string genre, int year)
    {
        if (string.IsNullOrWhiteSpace(artist))
        {
            throw new ArgumentException("Исполнитель не может быть пустым", nameof(artist));
        }

        if (string.IsNullOrWhiteSpace(title))
        {
            throw new ArgumentException("Название трека не может быть пустым", nameof(title));
        }

        if (year < 1900 || year > DateTime.Now.Year)
        {
            throw new ArgumentException($"Год должен быть между 1900 и {DateTime.Now.Year}", nameof(year));
        }

        Artist = artist;
        Title = title;
        Genre = genre;
        Year = year;
    }

    public override string ToString()
    {
        return $"{Artist} - {Title} ({Year}) [{Genre}]";
    }
}