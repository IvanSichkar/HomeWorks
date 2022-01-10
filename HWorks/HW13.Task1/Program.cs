using HW13.Task1.Models;


var song = new Song("Overcome", "Robert Spurling", 2, 2018);
dynamic anonymSong = Song.GetSongData(song);

Console.WriteLine($"Anonymous type: Title= {anonymSong.Title}, Minutes= {anonymSong.Minutes},Year = { anonymSong.AlbumYear}");

Console.WriteLine(new string('-', 20));
Console.WriteLine($"Json format NewtonSoft Anonymous type: {Song.GetJsonNewtonsoftAnonymousType(anonymSong)}");
Console.WriteLine($"Json format .Net       Anonymous type: {Song.GetJsonDotNetAnonymousType(anonymSong)}");
Console.WriteLine(new string('-', 20));

Console.WriteLine("Insert music style: ");

foreach (string жанрName in Enum.GetNames(typeof(Жанр)))
{
    Console.WriteLine("'{0}' or '{1:D}'", жанрName, Enum.Parse(typeof(Жанр), жанрName));
}

string inputValue = Console.ReadLine();

if (Enum.TryParse(inputValue, true, out Жанр жанр) && Enum.IsDefined(typeof(Жанр), жанр))
    song.Жанр = song.Жанр | жанр;
else
    Console.WriteLine("Music style set default!");

Console.WriteLine(new string('-',10));
Console.WriteLine($"Song type: Title= {song.Title},Author= {song.Author}, Duration={song.Duration}, " +
                  $"YearCreate= {song.YearCreate} Music style= {song.Жанр}");

Console.ReadKey();
