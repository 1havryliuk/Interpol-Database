using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace InterpolSystem
{
    public partial class Form1 : Form
    {
        public List<Criminal> criminals = new List<Criminal>();

        public Form1()
        {
            InitializeComponent();
            SeedData();
        }

        private void SeedData()
        {
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
                FirstName = "Френк",
                LastName = "Костелло",
                Nickname = "Прем'єр",
                Height = 178,
                HairColor = "Сивий",
                EyeColor = "Карі",
                SpecialSigns = "Рубець на шиї",
                Citizenship = "США",
                LastResidence = "Нью-Йорк",
                Languages = "Англійська",
                CrimeProfession = "Мафіозі",
                LastCase = "Корупція",
                Gang = "Genovese Family"
            });

            criminals.Add(new Criminal
            {
                FirstName = "Джон",
                LastName = "Готті",
                Nickname = "Тефлоновий Дон",
                Height = 180,
                HairColor = "Темний",
                EyeColor = "Сірі",
                SpecialSigns = "Татуювання",
                Citizenship = "США",
                LastResidence = "Бруклін",
                Languages = "Англійська",
                CrimeProfession = "Глава мафії",
                LastCase = "Рекет",
                Gang = "Gambino Family"
            });

            criminals.Add(new Criminal
            {
                FirstName = "Хоакін",
                LastName = "Гусман",
                Nickname = "Ель Чапо",
                Height = 165,
                HairColor = "Чорний",
                EyeColor = "Карі",
                SpecialSigns = "Невисокий зріст",
                Citizenship = "Мексика",
                LastResidence = "Сіналоа",
                Languages = "Іспанська",
                CrimeProfession = "Наркобарон",
                LastCase = "Контрабанда наркотиків",
                Gang = "Sinaloa Cartel"
            });

            criminals.Add(new Criminal
            {
                FirstName = "Маєр",
                LastName = "Ланскі",
                Nickname = "Бухгалтер мафії",
                Height = 170,
                HairColor = "Сивий",
                EyeColor = "Карі",
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
                FirstName = "Сальваторе",
                LastName = "Ріїна",
                Nickname = "Тото",
                Height = 172,
                HairColor = "Темний",
                EyeColor = "Карі",
                SpecialSigns = "Грубий голос",
                Citizenship = "Італія",
                LastResidence = "Сицилія",
                Languages = "Італійська",
                CrimeProfession = "Бос мафії",
                LastCase = "Замовні вбивства",
                Gang = "Cosa Nostra"
            });

            criminals.Add(new Criminal
            {
                FirstName = "Лакі",
                LastName = "Лучано",
                Nickname = "Lucky",
                Height = 176,
                HairColor = "Темний",
                EyeColor = "Карі",
                SpecialSigns = "Шрам на обличчі",
                Citizenship = "Італія",
                LastResidence = "Неаполь",
                Languages = "Італійська, англійська",
                CrimeProfession = "Організатор мафії",
                LastCase = "Контрабанда",
                Gang = "Luciano Family"
            });

            criminals.Add(new Criminal
            {
                FirstName = "Джеймс",
                LastName = "Балджер",
                Nickname = "Whitey",
                Height = 179,
                HairColor = "Білий",
                EyeColor = "Блакитні",
                SpecialSigns = "Шрам на лобі",
                Citizenship = "США",
                LastResidence = "Бостон",
                Languages = "Англійська",
                CrimeProfession = "Гангстер",
                LastCase = "Вбивства",
                Gang = "Winter Hill Gang"
            });

            criminals.Add(new Criminal
            {
                FirstName = "Карло",
                LastName = "Гамбіно",
                Nickname = "Дон Карло",
                Height = 175,
                HairColor = "Сивий",
                EyeColor = "Карі",
                SpecialSigns = "Повільна хода",
                Citizenship = "Італія",
                LastResidence = "Нью-Йорк",
                Languages = "Італійська",
                CrimeProfession = "Мафіозі",
                LastCase = "Рекет",
                Gang = "Gambino Family"
            });
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Criminal newCriminal = new Criminal();

            CriminalDetailsForm form =
                new CriminalDetailsForm(newCriminal, criminals);

            form.ShowDialog();

            // якщо після заповнення є ім'я — додаємо
            if (!string.IsNullOrWhiteSpace(newCriminal.FirstName))
            {
                criminals.Add(newCriminal);

                MessageBox.Show("Злочинця додано!");
            }
        }

        private void buttonOpenRegistry_Click(object sender, EventArgs e)
        {
            this.Hide();

            FormRegistry form = new FormRegistry(criminals);

            form.ShowDialog();

            this.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxLastName_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxNickname_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonArchive_Click(object sender, EventArgs e)
        {
            ArchiveForm form = new ArchiveForm(criminals);

            form.ShowDialog();
        }
    }
}