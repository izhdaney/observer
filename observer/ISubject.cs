using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace observer
{
    public interface ISubject
    {
        // Присоединяет наблюдателя к издателю.
        void Attach(IObserver observer);

        // Отсоединяет наблюдателя от издателя.
        void Detach(IObserver observer);

        // Уведомляет всех наблюдателей о событии.
        void Notify();
    }
}
