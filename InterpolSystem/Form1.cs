using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace InterpolSystem
{
    public partial class Form1 : Form
    {
        List<Criminal> criminals = new List<Criminal>();
        public Form1()
        {
            InitializeComponent();

            criminals.Add(new Criminal
            {
                FirstName = "Томас",
                LastName = "Шелбі",
                Nickname = "Томмі",
                Height = 182,
                HairColor = "Темний",
                EyeColor = "Синій",
                SpecialSigns = "Шрам на обличчі",
                Citizenship = "Велика Британія",
                LastResidence = "Бірмінгем",
                Languages = "Англійська",
                CrimeProfession = "Керівник мафії",
                LastCase = "Незаконна торгівля зброєю",
                Gang = "Peaky Blinders"
            });

            criminals.Add(new Criminal
            {
                FirstName = "Пабло",
                LastName = "Ескобар",
                Nickname = "Патрон",
                Height = 167,
                HairColor = "Чорний",
                EyeColor = "Карі",
                SpecialSigns = "Татуювання на руці",
                Citizenship = "Колумбія",
                LastResidence = "Медельїн",
                Languages = "Іспанська",
                CrimeProfession = "Наркобарон",
                LastCase = "Контрабанда наркотиків",
                Gang = "Медельїнський картель"
            });

            criminals.Add(new Criminal
            {
                FirstName = "Аль",
                LastName = "Капоне",
                Nickname = "Scarface",
                Height = 179,
                HairColor = "Темний",
                EyeColor = "Карі",
                SpecialSigns = "Шрам на щоці",
                Citizenship = "США",
                LastResidence = "Чикаго",
                Languages = "Англійська",
                CrimeProfession = "Мафіозі",
                LastCase = "Рекет",
                Gang = "Chicago Outfit"
            });

            criminals.Add(new Criminal
            {
                FirstName = "Віто",
                LastName = "Корлеоне",
                Nickname = "Хрещений батько",
                Height = 180,
                HairColor = "Сивий",
                EyeColor = "Карі",
                SpecialSigns = "Хриплий голос",
                Citizenship = "Італія",
                LastResidence = "Нью-Йорк",
                Languages = "Італійська, англійська",
                CrimeProfession = "Глава мафії",
                LastCase = "Відмивання грошей",
                Gang = "Сім'я Корлеоне"
            });

            criminals.Add(new Criminal
            {
                FirstName = "Тоні",
                LastName = "Монтана",
                Nickname = "Tony",
                Height = 175,
                HairColor = "Чорний",
                EyeColor = "Карі",
                SpecialSigns = "Шрам на руці",
                Citizenship = "Куба",
                LastResidence = "Маямі",
                Languages = "Іспанська",
                CrimeProfession = "Контрабандист",
                LastCase = "Наркоторгівля",
                Gang = "Montana Group"
            });

            criminals.Add(new Criminal
            {
                FirstName = "Джон",
                LastName = "Готті",
                Nickname = "Dapper Don",
                Height = 178,
                HairColor = "Темний",
                EyeColor = "Зелений",
                SpecialSigns = "Дорогі костюми",
                Citizenship = "США",
                LastResidence = "Нью-Йорк",
                Languages = "Англійська",
                CrimeProfession = "Мафіозі",
                LastCase = "Шахрайство",
                Gang = "Gambino Family"
            });

            criminals.Add(new Criminal
            {
                FirstName = "Френк",
                LastName = "Лукас",
                Nickname = "Superfly",
                Height = 181,
                HairColor = "Чорний",
                EyeColor = "Карі",
                SpecialSigns = "Татуювання на шиї",
                Citizenship = "США",
                LastResidence = "Гарлем",
                Languages = "Англійська",
                CrimeProfession = "Наркоторговець",
                LastCase = "Контрабанда героїну",
                Gang = "Lucas Organization"
            });

            criminals.Add(new Criminal
            {
                FirstName = "Карлос",
                LastName = "Ледер",
                Nickname = "El Loco",
                Height = 174,
                HairColor = "Світлий",
                EyeColor = "Блакитний",
                SpecialSigns = "Шрам на шиї",
                Citizenship = "Колумбія",
                LastResidence = "Богота",
                Languages = "Іспанська, англійська",
                CrimeProfession = "Контрабандист",
                LastCase = "Торгівля наркотиками",
                Gang = "Medellin Cartel"
            });

            criminals.Add(new Criminal
            {
                FirstName = "Сальваторе",
                LastName = "Рііна",
                Nickname = "Тото",
                Height = 170,
                HairColor = "Сивий",
                EyeColor = "Карі",
                SpecialSigns = "Шрам біля ока",
                Citizenship = "Італія",
                LastResidence = "Сицилія",
                Languages = "Італійська",
                CrimeProfession = "Кілер",
                LastCase = "Замовні вбивства",
                Gang = "Cosa Nostra"
            });

            criminals.Add(new Criminal
            {
                FirstName = "Хоакін",
                LastName = "Гусман",
                Nickname = "Ель Чапо",
                Height = 168,
                HairColor = "Чорний",
                EyeColor = "Карі",
                SpecialSigns = "Короткий зріст",
                Citizenship = "Мексика",
                LastResidence = "Сіналоа",
                Languages = "Іспанська",
                CrimeProfession = "Наркобарон",
                LastCase = "Контрабанда кокаїну",
                Gang = "Sinaloa Cartel"
            });

            criminals.Add(new Criminal
            {
                FirstName = "Майкл",
                LastName = "Корлеоне",
                Nickname = "Michael",
                Height = 183,
                HairColor = "Темний",
                EyeColor = "Карі",
                SpecialSigns = "Шрам на підборідді",
                Citizenship = "США",
                LastResidence = "Лас-Вегас",
                Languages = "Англійська",
                CrimeProfession = "Глава мафії",
                LastCase = "Фінансові махінації",
                Gang = "Сім'я Корлеоне"
            });

            criminals.Add(new Criminal
            {
                FirstName = "Лакі",
                LastName = "Лучано",
                Nickname = "Lucky",
                Height = 176,
                HairColor = "Темний",
                EyeColor = "Карі",
                SpecialSigns = "Шрам на щоці",
                Citizenship = "Італія",
                LastResidence = "Неаполь",
                Languages = "Італійська, англійська",
                CrimeProfession = "Організатор мафії",
                LastCase = "Контрабанда алкоголю",
                Gang = "Genovese Family"
            });

            criminals.Add(new Criminal
            {
                FirstName = "Меєр",
                LastName = "Ланскі",
                Nickname = "Mob Accountant",
                Height = 169,
                HairColor = "Сивий",
                EyeColor = "Сірий",
                SpecialSigns = "Окуляри",
                Citizenship = "США",
                LastResidence = "Маямі",
                Languages = "Англійська",
                CrimeProfession = "Фінансист мафії",
                LastCase = "Відмивання грошей",
                Gang = "National Crime Syndicate"
            });

            criminals.Add(new Criminal
            {
                FirstName = "Джеймс",
                LastName = "Булгер",
                Nickname = "Whitey",
                Height = 177,
                HairColor = "Білий",
                EyeColor = "Блакитний",
                SpecialSigns = "Шрам на руці",
                Citizenship = "США",
                LastResidence = "Бостон",
                Languages = "Англійська",
                CrimeProfession = "Гангстер",
                LastCase = "Рекет та вбивства",
                Gang = "Winter Hill Gang"
            });

            criminals.Add(new Criminal
            {
                FirstName = "Генрі",
                LastName = "Хілл",
                Nickname = "Henry",
                Height = 171,
                HairColor = "Темний",
                EyeColor = "Карі",
                SpecialSigns = "Татуювання",
                Citizenship = "США",
                LastResidence = "Бруклін",
                Languages = "Англійська",
                CrimeProfession = "Мафіозі",
                LastCase = "Пограбування",
                Gang = "Lucchese Family"
            });
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Criminal c = new Criminal
            {
                FirstName = textBoxFirstName.Text,
                LastName = textBoxLastName.Text,
                Nickname = textBoxNickname.Text
            };

            criminals.Add(c);

            MessageBox.Show("Злочинця додано!");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBoxNickname_TextChanged(object sender, EventArgs e)
        {

        }



        private void textBoxHeight_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxLastName_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonOpenRegistry_Click(object sender, EventArgs e)
        {
            FormRegistry form = new FormRegistry(criminals);
            form.Show();
        }
    }

}
    
