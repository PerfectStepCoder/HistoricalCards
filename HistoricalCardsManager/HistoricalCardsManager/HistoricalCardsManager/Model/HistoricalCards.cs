using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HistoricalCardsManager.Model
{
    class HistoricalCards : IObservable<T>
    {
        IDisposable IObservable<T>.Subscribe(IObserver<T> observer)
        {
            throw new NotImplementedException();
        }

        // Реализовывай свои исключения не забывая про конструктор с inner исключением? которое вызвало данное исключение (стек трейс ошибки). Исключения деляе Serializable

        // int? count = Customers?.orders?.length;

        // Перевыбрасывай исключения throw до метода main

        // Используй информацию из Enviroment

        // Сделай запрет на права использовать рефлексию во время выполнения программы

        // Вложенные классы попробуй их!

        // Классы взаимодействуют друг с другом через интерфейсы и события а не через наследование 

        // Какие то классы будут sealed

        // Используй полиморфизм, но некоторые методы будут sealed overide т.е. с запретом дальнейшего переопределения     
 
        // Используй операторы is и as

        // От обычного класса можно наследоваться абстратным классом

        // В некторых классах можно затенить существующие методы в наследниках оператором new, переопределение за счет сокрытия

        // Используй полиморфные методы

        // Если переопределяешь equevls то и getHashcode переорпеделеи так что одинаковые сущности имеют одинаковый хеш-код
        public HistoricalCards Select()
        {
            // Код фильтра коллекции
            return this;
        }
    }
}
