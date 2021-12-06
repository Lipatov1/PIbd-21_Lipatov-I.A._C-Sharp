﻿using System.Drawing;
using System;

namespace WindowsFormsTechnic {
    public class ArmoredCar : Vehicle, IEquatable<ArmoredCar> {
        // Ширина и высота отрисовки бронированной машины
        protected readonly int armoredCarWidth = 210;
        protected readonly int armoredCarHeight = 85;

        // Разделитель для записи информации по объекту в файл
        protected readonly char separator = ';';

        // Конструктор
        public ArmoredCar(int maxSpeed, float weight, Color mainColor) {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
        }

        // Конструктор для загрузки с файла
        public ArmoredCar(string info) {
            string[] strs = info.Split(separator);
            if (strs.Length == 3) {
                MaxSpeed = Convert.ToInt32(strs[0]);
                Weight = Convert.ToInt32(strs[1]);
                MainColor = Color.FromName(strs[2]);
            }
        }

        // Конструктор с изменением размеров бронированной машины
        protected ArmoredCar(int maxSpeed, float weight, Color mainColor, int carWidth, int carHeight) {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
            this.armoredCarWidth = carWidth;
            this.armoredCarHeight = carHeight;
        }

        // Изменение направления пермещения
        public override void MoveTransport(Direction direction) {
            float step = MaxSpeed * 100 / Weight;
            switch (direction) {
                case Direction.Right:
                    if (startPosX + step < pictureWidth - armoredCarWidth) {
                        startPosX += step;
                    }
                    break;

                case Direction.Left:
                    if (startPosX - step > 0) {
                        startPosX -= step;
                    }
                    break;

                case Direction.Up:
                    if (startPosY - step > 0) {
                        startPosY -= step;
                    }
                    break;

                case Direction.Down:
                    if (startPosY + step < pictureHeight - armoredCarHeight) {
                        startPosY += step;
                    }
                    break;
            }
        }

        // Отрисовка бронированной машины
        public override void DrawTransport(Graphics g) {
            Pen penBlack = new Pen(Color.Black, 3);
            Brush brMain = new SolidBrush(MainColor);
            Brush brDarkOlive = new SolidBrush(ColorTranslator.FromHtml("#35391f"));

            // Отрисовываем колеса
            g.FillEllipse(brDarkOlive, startPosX, startPosY + 40, 45, 45);
            g.FillEllipse(brDarkOlive, startPosX + 165, startPosY + 40, 45, 45);
            g.FillRectangle(brDarkOlive, startPosX + 25, startPosY + 40, 160, 25);
            g.DrawEllipse(penBlack, startPosX + 5, startPosY + 45, 35, 35);
            g.DrawEllipse(penBlack, startPosX + 170, startPosY + 45, 35, 35);

            // Отрисовываем крышу
            g.FillRectangle(brMain, startPosX + 7, startPosY + 30, 198, 20);
            g.FillRectangle(brMain, startPosX + 60, startPosY, 90, 30);
        }

        public override string ToString() {
            return $"{MaxSpeed}{separator}{Weight}{separator}{MainColor.Name}";
        }

        // Метод интерфейса IEquatable для класса ArmoredCar
        public bool Equals(ArmoredCar other) {
            if (other == null) {
                return false;
            }
            if (GetType().Name != other.GetType().Name) {
                return false;
            }
            if (MaxSpeed != other.MaxSpeed) {
                return false;
            }
            if (Weight != other.Weight) {
                return false;
            }
            if (MainColor != other.MainColor) {
                return false;
            }
            return true;
        }

        // Перегрузка метода от object
        public override bool Equals(Object obj) {
            if (obj == null) {
                return false;
            }
            if (!(obj is ArmoredCar carObj)) {
                return false;
            }
            else {
                return Equals(carObj);
            }
        }
    }
}