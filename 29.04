using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ConsoleApp1
{
    public class Movie
    {
        private string _name;
        private int _duration;
        private int[] _review;

        public string Name { get { return _name; } }
        public int Duration { get { return _duration; } }
        public int[] Revie => _review.ToArray();


        public Movie(string name, int duration)
        {
            _name = name;
            _duration = duration;
            _review = new int[1];
        }

        public void Add(int num)
        {
            Array.Resize(ref _review, num);
            _review[_review.Length - 1] = num;
        }
    }




    internal class Program
    {
        static void Main(string[] args)
        {
            Movie movie1 = new Movie("Harry Pottre", 102);
            movie1.Add(5);
            movie1.Add(5);
            movie1.Add(4);

            var temp = new
            {
                MovieType = movie1.GetType().Name,
                movie1.Name,
                movie1.Duration,
                movie1.Review

            };

            string folderpath=Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string filePATH=Path.Combine(folderpath,"Test","")
        
        
        }









            //// полученике путей к папкам

            ////относительный путь (Relative path) относительно файла с кодом где находится?
            ////"date.txt"(просто файл)
            //// "dataset/data.txt"(файл в папке)

            //// абсолютный путь (полноценный адрес) не подходит для запуска на другом устройстве 
            ////

            //string folderPath=Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            //string filePath = Path.Combine(folderPath,"Test", "examplt.txt");//ВМЕСТО folderPath+"/"+ "example.txt";


            ////проверка сущ ли пвпка 
            //string folderPath1 = Path.Combine(folderPath, "Test");
            //string filePath1 = Path.Combine(folderPath, "Test", "examplt.txt");

            //Console.WriteLine(folderPath1);
            //if (Directory.Exists(filePath1))
            //{
            //    Console.WriteLine("есть папка");

            //}
            //else
            //{
            //    Console.WriteLine("нет папки ");
            //    Directory.CreateDirectory(folderPath1);
            //    Console.WriteLine("папка создана");
            //}
            //// такой же код может быть с отрицанием !
            //string folderPath1Check = Path.GetFullPath(filePath1);

            //if (!Directory.Exists(folderPath1))
            //{
            //    Directory.CreateDirectory(folderPath1);
            //}
            //else
            //{
            //    File.Create(filePath1).Close(); 
            //}


            ////проверка сущ ли файл
            //if (File.Exists(filePath))
            //{
            //    Console.WriteLine("файл существует на компе");
            //}
            //else
            //{
            //    Console.WriteLine("ФАЙЛ НЕ СУЩ НА КОМПЕ");//если файла не существует то выводет это и сохраняем его
            //    //File.Create(filePath).Close();
            //    FileStream fs = File.Create(filePath);//сщздаем файл поэтому следующтй выход будет if ("файл существует на компе")
            //    fs.Close();
            //    Console.WriteLine("файл создан");
            //}

            //string foldPathCheck=Path.GetFullPath(filePath1);
            //string foldnameCheck = Path.GetFileName(filePath1);
            //Console.WriteLine(foldPathCheck);
            //Console.WriteLine(foldnameCheck);

            //File.WriteAllText(filePath, "HEY,KIRA!");
            //File.WriteAllLines(filePath, new string[] { "So", "cold", "" });


            ////записывает файл в строку
            ////если файла не было -сщздает и записывает
            ////если файл был-ПЕРЕзаписывает содержимое(удалит старое и запишет новое )
            ////чтобы каждый раз не перезаписывать а сохранить старое сожеожимон использ Append

            //File.WriteAllText(filePath, " ");
            //File.AppendAllText(filePath, "WOW");
            //File.AppendAllLines(filePath, new string[] { "No", "idea" });



            //// для чтения 

            //string content=File.ReadAllText(filePath);
            //string[] lines=File.ReadAllLines(filePath);
            ////Console.WriteLine(content);
            //foreach(string line in lines)
            //{
            //    Console.WriteLine(line);
            //}

            ////удаление
            //File.Delete(filePath);


            

       

  
        
    }
}
