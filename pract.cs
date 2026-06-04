using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
           // // относительный путь (Relative path) - 
           // // "data.txt"(файл) а если файл лежит в папке то тогда "dataset/data.txt" (папка/файл)
           // //абсолютный путь - полноценный адрес с:/...... он подходит только на данный момент в моем компе но на другом компе другой путь, программма ломается



           // // получение к папкам 
           // //   string folderpath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments); - основной май документ
           // string folderpath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);// будет лежать на рабочем столе 
           // string filePath = Path.Combine(folderpath,"example.txt"); // соединяет ( вместо folderpath + "/" + "example.txt )
           // // построили путь к будущему файлу !!!!!

           // if (File.Exists(filePath))
           // {
           //     // если создать без проверки то содержимое у суш файле он сотрет и сделает его новым 
           //     Console.WriteLine("файл сущ на компьютере ");
           // }
           // else
           // {
           //     Console.WriteLine("не сущ указанного файла");
           //     File.Create(filePath).Close(); // возвращает поток 
           //     //FileStream fs = File.Create(filePath);
           //     //fs.Close();
           //     Console.WriteLine("файл создан");
           // }
           // // если запустить по новой после создания то во второй раз и после срабоает if 
           // Console.WriteLine(folderpath);// C:\Users\m2502174\Desktop 



           // string folderpath1 = Path.Combine(folderpath, "Test");
           // string filePath1 = Path.Combine(folderpath1, "example.txt");

           // string folderpath1check = Path.GetDirectoryName(filePath1); // путь до папки 
           // //string folderpath1check2 = Path.GetFileName(filePath1); // имя файла
           // //string folderpath1check3 = Path.GetExtension(filePath1); // 

           // Console.WriteLine(folderpath1check);
           // if (Directory.Exists(filePath1))
           // {
           //     Console.WriteLine("есть папка");
           // }
           // else
           // {
           //     Console.WriteLine("нет папки");
           //     Directory.CreateDirectory(folderpath1); // close не надо 
           //     Console.WriteLine("создали папку");
           // }
           // if (!File.Exists(filePath))
           // {
           //     File.Create(filePath).Close();
           // }
          
           // File.WriteAllText(filePath, "люблю киру арину вику варю женю дарину ");
           // //File.WriteAllText(filePath, new string[] { "so", "cold", "33444" });
           // // записывает файл в строку
           // // если файла не было - создает и записывает
           // // если файл был - перезаписывает смодержимое (удаляя старое )


           // // Append создает файл и туда добавляет (если его не сущ)
           // File.AppendAllText(filePath, "оаооаао"); // не переносит строку 
           // File.AppendAllLines(filePath, new string[] {"хочу", "idea", "неееет"}); // переносит каждое слово
           // File.AppendAllLines(filePath, new string[] { "хочу ", "в", "гелен"});

           // // можно просто срапзу проверить что не сущ и создать
           // //if (!Directory.Exists(filePath1))
           // //{
           // //    Directory.CreateDirectory(folderpath1); 
           // //}

           // // считывать строки:
           // string content = File.ReadAllText(filePath); // выдаст ошибку если нет файла 
           // string[] lines = File.ReadAllLines(filePath); // если нет файл он сам сздаст 
           // Console.WriteLine(content); // выводит также все по строкам как и вы в самом файле 


           // // или же так вывовдить 
           //foreach (string line in lines)
           // {
           //     Console.WriteLine(line);
           // }

           //// ДЕЛИТ 

           //File.Delete(filePath);



            Movie movie1 = new Movie("harry potter", 120);
            movie1.Add(6);
            movie1.Add(7);
            movie1.Add(8);

            var temp = new
            {
                MovieType = movie1.GetType().Name,
                movie1.Name,
                movie1.Durtion,
                movie1.Rewiew
            };
            string folderpath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string filepath = Path.Combine(folderpath, "Test", "example.json");
            string json = JsonConvert.SerializeObject(temp);
            File.WriteAllText(filepath, json);

            // --десирилизация 
            string content = File.ReadAllText(filepath);
            var newJson = JsonConvert.DeserializeObject<dynamic>(content);
            Console.WriteLine(newJson);

            Movie movie2 = new Movie((string)newJson.Name, (int)newJson.Duration);
            foreach (var  n in newJson.Rewiew)
            {
                movie2.Add((int)n);
            }
            //Console.WriteLine(Movies(movie1, movie2));

        }
        //public private bool Movies(Movie a1, Movie a2)
        //{
        //    if (a1.Name != a2.Name) return false;
        //    if (a1.Durtion != a2.Durtion) return false;
        //    if (a1.Rewiew.Length != a2.Rewiew.Length) return false;
        //    return true;
        //}
    }
    public class Movie
    {
        private string _name;
        private int _duration;
        private int[] _rewiew;


        public int Durtion => _duration;
        public string Name => _name;
        public int[] Rewiew => _rewiew.ToArray();
        public Movie(string name, int duration)
        {
            _name = name;
            _duration = duration;
            _rewiew = new int[0];
        }
        public void Add(int num)
        {
            Array.Resize(ref _rewiew,_rewiew.Length + 1);
            _rewiew[Rewiew.Length-1] = num;
        }
    }
}
