using System;

namespace WindowsFormsTechnic {
    // Класс-ошибка "Если на базе уже есть техника с такими же характеристиками
    class BaseAlreadyHaveException : Exception {
        public BaseAlreadyHaveException() : base("На базе уже есть такая техника")
        { }
    }
}