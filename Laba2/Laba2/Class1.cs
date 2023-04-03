using System;

namespace SS123
{
    class Note
    {
        protected string firstName;
        protected string surName;
        protected string patronymic;

        //конструктор по умолчанию
        public Note()
        {
            this.firstName = "Daniil";
            this.surName = "Sergeev";
            this.patronymic = "Valerevich";
        }

        //конструктор не по умолчанию
        public Note(string firstName, string surName, string patronymic)
        {
            this.firstName = firstName;
            this.surName = surName;
            this.patronymic = patronymic;
        }

        //метод для вывода информации в консоль
        virtual public void ShowInfo()
        {
            Console.WriteLine("\nИмя : {0}", firstName.ToString());
            Console.WriteLine("Фамилия : {0}", surName.ToString());
            Console.WriteLine("Отчество : {0}", patronymic.ToString());
        }


    }
}

