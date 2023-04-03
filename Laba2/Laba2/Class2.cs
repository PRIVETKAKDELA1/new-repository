using System;

namespace SS123
{
    class Friend : Note
    {
        public string email { get; }
        public string birthday { get; }

        //конструктор
        public Friend(string firstName, string surName, string patronymic, string email, string birthday) : base(firstName, surName, patronymic)
        {
            this.email = email;
            this.birthday = birthday;
        }

        //переопределение метода вывода информации в консоль
        override public void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine("Почта : {0}", email.ToString());
            Console.WriteLine("Дата рождения : {0}", birthday.ToString());
        }
    }
}
