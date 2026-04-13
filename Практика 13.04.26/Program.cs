using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // CONTAINS 
            string word = "Hello";
            Console.WriteLine(word.Contains("oll"));// возвращает  bool значение 
            //если строка содерж подстроку"lo", вывести на консоль фраз Success
            if (word.Contains("oll"))//==true (можно так писать ,но это лишнее действие)
            {
                Console.WriteLine(word.Contains("Success"));
            }
            else
            {
                Console.WriteLine("Error");
            }
            char[] example = { 'a', '.', '0', };
            Console.WriteLine(example.Length);
            Console.WriteLine(example.Contains('a'));
            char[] punc = new char[] { '.', '!', '?', ',', ':', '\"', ';', '–', '(', ')', '[', ']', '{', '}', '/' };
            char x = 'a';
            if (punc.Contains(x))
            {
                Console.WriteLine("the symbol is punc ");

            }
            else
            {
                Console.WriteLine("it is punc ");
            }
            //REPLACE
            string text = "cat catastrophe dog dog love";
            //text.Replace("dog", "more cats");///так нельзя,текст не поменяется(текст надо сохранять или приписывать в перемен результат метода)
            text =text.Replace("dog", "more cats");
            Console.WriteLine(text.Replace("dog", "more cats"));
            Console.WriteLine(text.Replace("cat ","lucky"));


            //TRIM
            //(отрезаем с краев всю ненужную информацию,знаки)
            string word2 = " cat ";
            string word3 = "!?,cat";
            word2 = word2.Trim(' ');
            Console.WriteLine(word2);
            //очищение от знаков пунктуации возможно
            word2=word2.Trim(new char[] { ' ', 't' });
            Console.WriteLine(word2);
            word3= word3.Trim(punc);
            Console.WriteLine(word3);


            //SPLIT
            string text2 = "Hello, my dear 2 friends!";
            //string[] dirtyWords = text2.Split(' ');
            //foreach(string w in dirtyWords)// разбили текст по словам 
            //{
            //    Console.WriteLine(w);
            //}
            string[] dirtyWords =text2.Split(punc/*,StringSplitOptions.RemoveEmptyEntries*/);
            for (int i=0; i < dirtyWords.Length;i++)
            {
                Console.WriteLine(dirtyWords[i]);
                if (dirtyWords[i]!= "")
                {
                    Console.WriteLine(text2);

                }

            }

            //JOIN
            string text3=String.Join(" ", dirtyWords);
            Console.WriteLine(text3);


            //IsDigit/IsLetter
            char s = 'a';
            Console.WriteLine(char.IsDigit(s));//является ли цифрой 
            Console.WriteLine(char.IsLetter(s));//являеься ли буквой 
            Console.WriteLine(char.IsLower(s));
            //выводит bool значение 


            //ToUpper/ToLower эти методы тоже нужно присваевать\приписывать
            string word5 = "Hello";
            Console.WriteLine(word5.ToLower());
            Console.WriteLine(word5.ToUpper());


            string vowels = "уеаоиюя";//находим гласные больште и маленькие
            vowels += vowels.ToUpper();
            Console.WriteLine(vowels);


            // найти в массиве все слова текста 
            string input = "Hello, my dear 2 friends!";
            int count = 0;
            string[] dirtyWords1=input.Split(' ');
            string[] cleanWord = new string[0];
            for (int i=0; i < dirtyWords1.Length;i++)
            {
                string trimWord = dirtyWords1[i].Trim(punc);
                Console.WriteLine(trimWord);

                bool f = true;
                foreach(char symbol1 in trimWord)
                {
                    if (char.IsDigit(symbol1)  || punc.Contains(symbol1))
                    {
                        f = false;
                    }
                }
                if (trimWord != "" && f==true)
                {
                    count++;
                    Array.Resize(ref cleanWord,cleanWord.Length+1);
                    cleanWord[cleanWord.Length-1]=trimWord.ToLower();
                    
                }

            }



        }
    }
}
