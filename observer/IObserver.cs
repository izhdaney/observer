﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace observer
{
    public interface IObserver
    {
        // Получает обновление от издателя
        void Update(ISubject subject);
    }
}
