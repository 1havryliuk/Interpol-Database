using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Windows.Forms;

using InterpolSystem.Models;
namespace InterpolSystem.Forms
{
    public partial class MainForm : Form
    {
        public List<Criminal> criminals = new List<Criminal>();
        public List<Gang> gangs = new List<Gang>();
        private const string FILE_NAME = "criminals.json";

        public MainForm()
        {
            InitializeComponent();

            SeedGangs();

            if (File.Exists(FILE_NAME))
            {
                LoadData();
            }
            else
            {
                SeedData();
            }
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
                BirthPlace = "Бірмінгем",
                BirthDate = new DateTime(1890, 5, 12),
                Languages = "Англійська",
                CrimeProfession = "Керівник мафії",
                LastCase = "Незаконна торгівля зброєю",
                Gang = gangs[0]
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
                BirthPlace = "Ріонегро",
                BirthDate = new DateTime(1949, 12, 1),
                Languages = "Іспанська",
                CrimeProfession = "Наркобарон",
                LastCase = "Контрабанда наркотиків",
                Gang = gangs[1]
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
                BirthPlace = "Бруклін",
                BirthDate = new DateTime(1899, 1, 17),
                Languages = "Англійська",
                CrimeProfession = "Мафіозі",
                LastCase = "Рекет",
                Gang = gangs[2]
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
                BirthPlace = "Сицилія",
                BirthDate = new DateTime(1891, 12, 7),
                Languages = "Італійська, англійська",
                CrimeProfession = "Глава мафії",
                LastCase = "Відмивання грошей",
                Gang = gangs[3]
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
                BirthPlace = "Гавана",
                BirthDate = new DateTime(1940, 8, 3),
                Languages = "Іспанська",
                CrimeProfession = "Контрабандист",
                LastCase = "Наркоторгівля",
                Gang = gangs[4]
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
                BirthPlace = "Кассано",
                BirthDate = new DateTime(1891, 1, 26),
                Languages = "Англійська",
                CrimeProfession = "Мафіозі",
                LastCase = "Корупція",
                Gang = gangs[5]
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
                BirthPlace = "Нью-Йорк",
                BirthDate = new DateTime(1940, 10, 27),
                Languages = "Англійська",
                CrimeProfession = "Глава мафії",
                LastCase = "Рекет",
                Gang = gangs[6]
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
                BirthPlace = "Сіналоа",
                BirthDate = new DateTime(1957, 4, 4),
                Languages = "Іспанська",
                CrimeProfession = "Наркобарон",
                LastCase = "Контрабанда наркотиків",
                Gang = gangs[7]
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
                BirthPlace = "Гродно",
                BirthDate = new DateTime(1992, 7, 4),
                Languages = "Англійська",
                CrimeProfession = "Фінансист мафії",
                LastCase = "Відмивання грошей",
                Gang = gangs[8]
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
                BirthPlace = "Сицилія",
                BirthDate = new DateTime(1987, 11, 24),
                Languages = "Італійська",
                CrimeProfession = "Бос мафії",
                LastCase = "Замовні вбивства",
                Gang = gangs[9]
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
                BirthPlace = "Сицилія",
                BirthDate = new DateTime(1897, 11, 24),
                LastResidence = "Неаполь",

                Languages = "Італійська, англійська",
                CrimeProfession = "Організатор мафії",
                LastCase = "Контрабанда",
                Gang = gangs[10]
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
                BirthPlace = "Палермо",
                BirthDate = new DateTime(1962, 8, 24),
                Languages = "Англійська",
                CrimeProfession = "Гангстер",
                LastCase = "Вбивства",
                Gang = gangs[11]
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
                BirthPlace = "Бостон",
                BirthDate = new DateTime(1989, 9, 3),
                Languages = "Італійська",
                CrimeProfession = "Мафіозі",
                LastCase = "Рекет",
                Gang = gangs[6]
            });
        }
        private void SeedGangs()
        {
            gangs.Add(new Gang
            {
                Name = "Peaky Blinders",
                Country = "Велика Британія",
                MembersCount = 120
            });

            gangs.Add(new Gang
            {
                Name = "Медельїнський картель",
                Country = "Колумбія",
                MembersCount = 500
            });

            gangs.Add(new Gang
            {
                Name = "Chicago Outfit",
                Country = "США",
                MembersCount = 300
            });

            gangs.Add(new Gang
            {
                Name = "Сім'я Корлеоне",
                Country = "Італія",
                MembersCount = 150
            });

            gangs.Add(new Gang
            {
                Name = "Montana Group",
                Country = "Куба",
                MembersCount = 80
            });
            gangs.Add(new Gang
            {
                Name = "Genovese Family",
                Country = "США",
                MembersCount = 250
            });
            gangs.Add(new Gang
            {
                Name = "Gambino Family",
                Country = "США",
                MembersCount = 400
            });
            gangs.Add(new Gang
            {
                Name = "Sinaloa Cartel",
                Country = "Мексика",
                MembersCount = 1000
            });
            gangs.Add(new Gang
            {
                Name = "National Crime Syndicate",
                Country = "США",
                MembersCount = 350
            });
            gangs.Add(new Gang
            {
                Name = "Cosa Nostra",
                Country = "Італія",
                MembersCount = 700
            });
            gangs.Add(new Gang
            {
                Name = "Luciano Family",
                Country = "Італія",
                MembersCount = 200
            });
            gangs.Add(new Gang
            {
                Name = "Winter Hill Gang",
                Country = "США",
                MembersCount = 170
            });
        }
        public void SaveData()
        {
            var options = new JsonSerializerOptions
            {
                WriteIndented = true,
                Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping
            };

            string json =
                JsonSerializer.Serialize(criminals, options);

            File.WriteAllText(FILE_NAME, json);
        }
        private void LoadData()
        {
            if (File.Exists(FILE_NAME))
            {
                string json = File.ReadAllText(FILE_NAME);

                criminals =
                    JsonSerializer.Deserialize<List<Criminal>>(json)
                    ?? new List<Criminal>();
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            // перевірка імені
            if (textBoxFirstName.Text.Any(char.IsDigit))
            {
                MessageBox.Show(
                    "Ім'я не повинно містити цифри!");

                return;
            }

            // перевірка прізвища
            if (textBoxLastName.Text.Any(char.IsDigit))
            {
                MessageBox.Show(
                    "Прізвище не повинно містити цифри!");

                return;
            }

            // перевірка клички
            if (textBoxNickname.Text.Any(char.IsDigit))
            {
                MessageBox.Show(
                    "Кличка не повинна містити цифри!");

                return;
            }

            Criminal newCriminal = new Criminal();

            newCriminal.FirstName = textBoxFirstName.Text;
            newCriminal.LastName = textBoxLastName.Text;
            newCriminal.Nickname = textBoxNickname.Text;

            criminals.Add(newCriminal);

            CriminalDetailsForm form =
                new CriminalDetailsForm(newCriminal, criminals);

            form.ShowDialog();

            SaveData();

            MessageBox.Show("Злочинця додано!");
        }

        private void buttonOpenRegistry_Click(object sender, EventArgs e)
        {
            this.Hide();

            FormRegistry form = new FormRegistry(criminals, this);

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