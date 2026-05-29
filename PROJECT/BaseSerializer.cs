using Model.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Data
{
    public abstract class BaseSerializer
    {
        // Расширение файла (например, ".json" или ".xml")
        public abstract string Extension { get; }

        // Сериализация и десериализация всей базы приютов
        public abstract void Serialize(string filePath, Shelter[] data);
        public abstract Shelter[] Deserialize(string filePath);

        // Сериализация конкретной выборки для оконных отчетов (таблиц)
        public abstract void SerializeSelection(string filePath, List<Pet> pets);
    }
}
