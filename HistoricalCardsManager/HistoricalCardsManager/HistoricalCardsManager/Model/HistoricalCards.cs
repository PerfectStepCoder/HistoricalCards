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


        // Вложенные классы попробуй их!

        // Классы взаимодействуют друг с другом через интерфейсы и события а не через наследование 

        // Какие то классы будут sealed

        // Используй полиморфизм, но некоторые методы будут sealed overide т.е. с запретом дальнейшего переопределения     
 
        // Используй операторы is и as

        // От обычного класса можно наследоваться абстратным классом

        // В некторых классах можно затенить существующие методы в наследниках оператором new

        public HistoricalCards Select()
        {
            // Код фильтра коллекции
            return this;
        }
    }
}
