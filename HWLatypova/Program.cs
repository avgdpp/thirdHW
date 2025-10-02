using HWLatypova.Enums;
namespace HomeWork
{
    class Programm
    {
        static void Main()
        {
            //последовательность из 10 чисел
            Console.WriteLine("Дана последовательность из 10 чисел. Определить, является ли эта последовательность упорядоченной по возрастанию.");
            Console.WriteLine("введите последовательность из 10 чисел через пробел");
            float value0;
            float value1;
            string[] splitedValues = Console.ReadLine().Split();
            bool isSequence = true;
            bool isUpper = true;
            if (splitedValues.Length == 10)
            {
                for (int i = 1; i < splitedValues.Length; i++)
                {
                    if (!float.TryParse(splitedValues[i - 1], out value0) || !float.TryParse(splitedValues[i], out value1))
                    {
                        isSequence = false;
                        break;
                    }
                    else
                    {
                        if (value0 >= value1)
                        {
                            isUpper = false;
                            Console.Write(i + 1);
                            break;
                        }
                    }
                }

                Console.WriteLine(isSequence ? (isUpper ? "последовательность возрастаяющая" : " - порядковый номер элемента, на котором ломается последовательность") : "данные введены неверно");
            }
            else
            {
                Console.WriteLine("количество элементов последовательности не равно 10");
            }
            // По заданному номеру карты k (6 <=k <= 14) определить достоинство соответствующей карты.
            Console.WriteLine("По заданному номеру карты k (6 <=k <= 14) определить достоинство соответствующей карты.");
            Console.WriteLine("введите число от 6 до 14");
            string[] cards = new string[9];
            cards = ["шестерка", "семерка", "восьмерка", "девятка", "десятка", "валет", "дама", "король", "туз"];
            try
            {
                Console.WriteLine(cards[int.Parse(Console.ReadLine()) - 6]);
            }
            catch (System.Exception)
            {

                Console.WriteLine("ошибка ввода");
            }
            // Напишите программу, которая принимает на входе строку и производит выходные данные в соответствии со следующей таблицей:
            Console.WriteLine("Напишите программу, которая принимает на входе строку и производит выходные данные в соответствии со следующей таблицей:");
            Dictionary<string, string> peoplesFavoriteDriks = new Dictionary<string, string>()
            {
                {"jabroni", "Patron Tequila"},
                {"school counselor", "Anything with Alcohol"},
                {"programmer", "Hipster Craft Beer"},
                {"politican", "Your tax dollars"},
                {"rapper", "Cristal"},
                {"bike gang member", "Moonshine"}
            };

            try
            {
                Console.WriteLine(peoplesFavoriteDriks[Console.ReadLine().ToLower()]);
            }
            catch (System.Exception)
            {
                Console.WriteLine("Beer");
            }
            //день недели
            Console.WriteLine("Составить программу, которая в зависимости от порядкового номера дня недели выводит на экран его название");
            Console.WriteLine("введите число от 1 до 7");
            int daysNum;
            if (!int.TryParse(Console.ReadLine(), out daysNum) || daysNum > 7 || daysNum < 1)
            {
                Console.WriteLine("введеное значение не может быть днем недели");
            }
            else
            {
                Console.WriteLine(Enum.GetName(typeof(Week), daysNum));
            }
            //ложим в сумку
            Console.WriteLine("Создать массив строк. При помощи foreach обойти весь массив. При встрече элемента \"Hello Kitty\" или \"Barbie doll\"необходимо положить их в “сумку”");
            Console.WriteLine("ввидите массив или будет использоваться дефолтьный массив");
            string[] usersItems = Console.ReadLine().Split();
            int bag = 0;
            if (usersItems.Length == 1 && usersItems[0] == "")
            {
                string[] kidsShop = ["asdfsadfas", "Hello Kitty", "bye kitty", "hello kitty", "Barbie doll", "fklasdlfksdakl", "rtx 5090", "beer", "Hello Kitty", "Barbie doll", "Barbie Kitty"];
                Console.WriteLine($"массив, по которому будет идти поиск \"{string.Join(", ", kidsShop)}\"");
                foreach (string toy in kidsShop)
                {
                    bag += (toy == "Hello Kitty" || toy == "Barbie doll") ? 1 : 0;
                }
            }
            else
            {
                foreach (string toy in usersItems)
                {
                    bag += (toy == "Hello Kitty" || toy == "Barbie doll") ? 1 : 0;
                }
            }
            Console.WriteLine($"в сумке {bag} игрушек");
        }
    }
}