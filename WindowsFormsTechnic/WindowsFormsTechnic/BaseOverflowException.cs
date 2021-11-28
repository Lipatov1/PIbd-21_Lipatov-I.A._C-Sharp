using System;

namespace WindowsFormsTechnic {
    // Класс-ошибка "Если на базе уже заняты все места"
    class BaseOverflowException : Exception {
        public BaseOverflowException() : base("На базе нет свободных мест") { }
    }
}