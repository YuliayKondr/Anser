using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.CompilerServices;
namespace WpfApp1
{
    public class AnserBall:INotifyPropertyChanged
    {
        private static string[] massAnser = new string[]
            {
                "Бесспорно",
                "Предрешено",
                "Никаких сомнений",
                "Определённо да",
                "Можешь быть уверен \nв этом",
                "Мне кажется — «да»",
                "Вероятнее всего",
                "Хорошие перспективы",
                "Знаки говорят — «да»",
                "Да",
                "Пока не ясно, \nпопробуй снова",
                "Спроси позже",
                "Лучше не рассказывать",
                "Сейчас нельзя предсказать",
                "Сконцентрируйся \nи спроси опять",
                "Даже не думай",
                "Мой ответ — «нет»",
                "По моим данным — «нет»",
                "Перспективы не \nочень хорошие",
                "Весьма сомнительно"
        };
        public static string Anser()
        {
            Random random = new Random();
            return massAnser[random.Next(0, 20)];
        }
        private string _privet;
        public string Privet
        {
            get { return _privet; }
            set { _privet = value; }
        }
        public string Durish()
        {
            return "Ты меня дуришь";
        }
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string prop="")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
             
    }
}
