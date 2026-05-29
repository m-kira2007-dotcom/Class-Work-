using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Core
{
    public partial class Shelter : ICountable, IFilter
    {
        public string Name { get; set; }
        public int Capacity { get; set; } // вместимость 
        public bool HasOpenTerritory { get; set; } // сколько открытой территори

        // Исправлено: инициализация через классический пустой массив по умолчанию
        public List<Pet> Pets { get; set; } = new List<Pet>();

        public Shelter()
        {

        }

        public Shelter(string name, int capacity, bool hasOpenTerritory)
        {
            Name = name;
            Capacity = capacity;
            HasOpenTerritory = hasOpenTerritory;
        }

        //интерфейса ICountable
        public int Count()
        {
            return Pets.Count; // сколько животных в приюте
        }

        public int Count(Type type)
        {
            if (type == null) return Pets.Count;

            int count = 0;
            foreach (var pet in Pets)
            {
                if (pet != null && pet.GetType() == type)
                {
                    count++;
                }
            }
            return count;
        }

        public int Percentage(Type type)
        {
            if (Pets.Count == 0 || type == null) return 0;

            double countOfType = Count(type);
            double totalCount = Pets.Count;

            int procent=(int)Math.Round(countOfType / totalCount * 100);
            return procent;
        }
        // Реализация интерфейса IFilter
        //public Pet[] Filter(Type type)
        //{
        //    if (type == null) return Pets;

        //    int targetSize = Count(type);
        //    Pet[] result = new Pet[targetSize];

        //    int index = 0;
        //    foreach (var pet in Pets)
        //    {
        //        if (pet != null && pet.GetType() == type)
        //        {
        //            result[index] = pet;
        //            index++;
        //        }
        //    }
        //    return result;

        //}
        public List<Pet> Filter(Type type) // 
        {
            // 1. Создаем пустой динамический список, который будем возвращать
            List<Pet> result = new List<Pet>();

            // 2. Если тип не указан (выбрано "Все виды" -> null), 
            // переносим абсолютно всех живых питомцев из массива в этот список
            if (type == null)
            {
                foreach (var pet in Pets)
                {
                    if (pet != null)
                    {
                        result.Add(pet);
                    }
                }
                return result;
            }

            // 3. Если тип указан, бежим циклом по массиву Pets 
            // и добавляем в список только тех, чей тип совпал (например, Cat)
            foreach (var pet in Pets)
            {
                if (pet != null && pet.GetType() == type)
                {
                    result.Add(pet); // Метод .Add() сам расширяет список
                }
            }

            // 4. Возвращаем заполненный список
            return result;
        }
    }
}
