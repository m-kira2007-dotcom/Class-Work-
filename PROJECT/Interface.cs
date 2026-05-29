using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Core
{
    public interface ICountable
    {
        int Count();// общее колво животных в приюте
        int Count(Type type);// возвращает колво живот конкретного вида (собаки коты)

        int Percentage(Type type);//возвращ процент животных конкретного типа от всех
    }
    public interface IFilter
    {
        // содерж  метод для фильтрации по виду животных 
        //Pet[] Filter(Type type);// возвращ массив объектов Pet[]

        List<Pet> Filter(Type type);
    }
}
