using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW13.Task1.Models
{
    public class Song
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int Duration { get; set; }
        public int YearCreate { get; set; }
        public Жанр Жанр { get; set; }

        public Song(string title, string author, int duration, int yearCreate)
        {
            Title = title;
            Author = author;
            Duration = duration;
            YearCreate = yearCreate;
        }
        public static dynamic GetSongData(Song song)
        {
            return new { song.Title, Minutes = song.Duration, AlbumYear = song.YearCreate };
        }
        public static string GetJsonNewtonsoftAnonymousType(dynamic anonymSong)
        {
            return JsonConvert.SerializeObject(anonymSong);
        }
        public static string GetJsonDotNetAnonymousType(dynamic anonymeSong)
        {
            return System.Text.Json.JsonSerializer.Serialize(anonymeSong);
        }
    }
   
}
