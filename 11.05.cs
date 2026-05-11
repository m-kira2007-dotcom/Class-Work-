using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Pract1105
{
    public class Movie
    {
        private string _name;
        private int _duration;
        private int[] _rating;


        public string Name => _name;

        public int Duration => _duration;
        public int[] Rating => _rating;

        public Movie(string name, int duration)
        {
            _name = name;
            _duration = duration;
            _rating = new int[0];
        }
        public void Add(int  stars)
        {
            Array.Resize(ref _rating, _rating.Length+1);
            _rating[_rating.Length-1] = stars;
        }
    }
    public class MovieDTO//для запуска xml serial
    {
        public string Name { get; set; }
        public int Duration { get; set; }
        public int[] Rating { get; set; }

        public MovieDTO()
        {

        }
        public MovieDTO(string name, int duration)//принимает каждле знач отдельно передать в ДТО вариант 1
        {
            Name = name;
            Duration = duration;
            Rating = new int[0];
        }
        public MovieDTO(MovieDTO movie)// из обычного обьекта в обьект дто вариант 2
        {
            Name=movie.Name;
            Duration = movie.Duration;
            Rating = movie.Rating;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //щбект для сериализации
            Movie movie1=new Movie("Spider-man",150);
            MovieDTO movieDTO = new MovieDTO(movie1.Name, movie1.Duration);


            //создаем путь до папки XML
            string folderpath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string filePATH = Path.Combine(folderpath, "movie.xml");


            //создаем XML-сериализатор 
            // класс должен иметь конструктор без параметров 
            //класс доджен буть публичным 
            //в классе все свойства должны быть публичными get set


            // оригинальеый обект ->ДТО обект->отдать его в сериализатор 
            //десериализует обект из файла -> получакм ДТО обект ->ориг обект 
            var serializer=new XmlSerializer(typeof(MovieDTO));
            //для записи using
            using (var writer = new StreamWriter(filePATH))
            {
                serializer.Serialize(writer, movieDTO);
            }


            //десериализуем обьект из файла -> получаем ДТО обткт ->ориг обьект 
            MovieDTO movieDTO2;
            using(var reader=new StreamReader(filePATH))
            {
                movieDTO2=(MovieDTO)serializer.Deserialize(reader);
            }

            //из ДТО в ориг обьект 
            Movie movie2 = new Movie(movieDTO2.Name, movieDTO2.Duration);//десириализованный обьект 
            //Movie movie2 = new Movie(movie1.Name, movie1.Duration);
            //Console.WriteLine(movie2.Name);
            //Console.WriteLine(movie2.Duration);
            if (CompareMovies(movie1,movie2))
            {
                Console.WriteLine("success");
            }
            else
            {
                Console.WriteLine("Something wrong");
            }
        }
        private static bool CompareMovies(Movie m1,Movie m2)
        {
            if (m1.Name!=m2.Name) return false;
            if (m1.Duration!=m2.Duration) return false;

            return true;
        }

    }


}
