using System;

namespace WindowsFormsTechnic {
    // Класс-ошибка "Если не найдена техника по определенному месту"
    class BaseNotFoundException : Exception {
        public BaseNotFoundException(int i) : base("Не найдена техника по месту " + i) { }
    }
}