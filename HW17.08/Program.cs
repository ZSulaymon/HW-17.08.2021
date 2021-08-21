using System;

namespace HW17._08
{
    class Car
    {
        public string name;
        public string Model;
        public int year;
        public string color;
        public string complectation;
        public int weight;
        public string length;
        public int Horsepower;
        public int maxSpeed;
        public string Manufacturer;
        public string TransmissionType;
        public string Description;


        public void GetInfo()
        {
            Console.WriteLine($" Имя:{name}\n Модель:{Model}\n Год вып:{year}\n Цвет:{color}\n Комплектация:{complectation}\n Вес: {weight}\n Длина:{length}\n Лошодинная сила:{Horsepower}\n Макс скорость:{maxSpeed}\n Производитель:{Manufacturer}\n Коробка передача:{TransmissionType}\n Описание:{Description}\n");
        }
    }



    class Program
    {

        static void Main(string[] args)
        {
            Car tesla = new Car();
            tesla.name = "Teslа";
            tesla.Model = "Model X";
            tesla.year = 2018;
            tesla.color = "blue";
            tesla.complectation = "FUll";
            tesla.Description = "американская компания, производитель электромобилей и решений для хранения электрической энергии. Компания была основана в июле 2003 года Мартином Эберхардом и Марком Тарпеннингом, но нынешнее руководство компании называют сооснователями Илона Маска";
            tesla.Horsepower = 670;
            tesla.maxSpeed = 220;
            tesla.weight = 1500;
            tesla.length = "2м";
            tesla.Manufacturer = "Tesla Corporation";
            tesla.TransmissionType = "Автомат";



            tesla.GetInfo();
        }
    }
}
