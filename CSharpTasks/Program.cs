namespace CSharpTasks
{
    internal class Program
    {
        /* Описание задачи
         * Создать программу подсчета месячного платежа за квартиру
         * При запуске программа запускает ряд вопросов для пользователя, на основании ответов которых происходит расчет месячного платежа.
         * 1-ый вопрос: метраж квартиры в метрах в квадрате с точностью до десятых. Считается, что за каждый квадратный метр пользователь платит 44 рубля 25 копеек
         * 2-ой вопрос: этаж квартиры. Считается, что оплата за метраж квартиры увеличивается в 0.04 за каждый этаж
         * 3-ий вопрос: количество потребленной электроэнергии в киловаттах с точностью до сотых. Считается, что за каждый киловатт энергии пользователь платит 4 рубля 70 копеек
         * 4-ый вопрос: количество потребленной теплой воды в кубометрах с точностью до целых. Считается, что за каждый кубометр теплой воды пользователь платит 80 рублей 15 копеек
         * 5-ый вопрос: количество потребленной холодной воды в кубометрах с точностью до целых. Считается, что за каждый кубометр холодной поды пользователь платит 48 рублей 72 копейки
         * 6-ой вопрос: количество потребленного газа в кубометрах с точностью до десятых. Если этаж квартиры выше 12-го включительно, считается, что в этом доме не проведен газ и этот вопрос не задается. В обратном случае считается, что за каждый кубометр газа пользователь платит 2 рубля 42 копейки
         * 7-ой вопрос: количество потребленного отопления в гигакаллориях с точностью до десятых. Считается, что за каждый гигакаллорий пользователь платит 1273 рубля
         * 8-ой вопрос: подключен ли интернет в квартире (да/нет). В случае подключенного интернета дополнительно взымается плата 400 рублей
         * После всех подсчетов программа выводит итоговую сумму оплаты за месяц
         *
         * Пример работы программы:
         * Введите метраж квартиры (м^2): 42.8
         * Введите этаж квартиры: 14
         * Введите количество электроэнергии (кВт): 230.49
         * Введите количество теплой воды (м^3): 5
         * Введите количество холодной воды (м^3): 3
         * Введите количество отопления (гКалл): 1.9
         * Подключен интернет? нет
         *
         * Итоговая сумма: 6435 рубля 22 копейки
        */
        static void Main(string[] args)
        {
            Console.WriteLine("Введите метраж квартиры c точностью до десятых(м^2):");
            string apartArea = Console.ReadLine();
            double PRSapartArea = double.Parse(apartArea);

            Console.WriteLine("Введите этаж квартиры:");
            string floorNumb = Console.ReadLine();
            double PRSfloorNumb = double.Parse(floorNumb);

            Console.WriteLine("Введите количество электроэнергии с точностью до сотых(кВт):");
            string electricity = Console.ReadLine();
            double PRSelectricity = double.Parse(electricity);

            Console.WriteLine("Введите количество теплой воды с точностью до целых(м^3):");
            string hotWater = Console.ReadLine();
            double PRShotWater = double.Parse(hotWater);

            Console.WriteLine("Введите холодной воды с точностью до целых(м^3):");
            string coldWater = Console.ReadLine();
            double PRScoldWater = double.Parse(coldWater);

            double PRSgas = 0;
            if (PRSfloorNumb < 12)
            {
                Console.WriteLine("Введите количество газа с точностью до десятых(м^3):");
                string gas = Console.ReadLine();
                PRSgas = double.Parse(gas);
            }

            Console.WriteLine("Введите количество отопления с точностью до десятых(гКалл):");
            string heating = Console.ReadLine();
            double PRSheating = double.Parse(heating);

            Console.WriteLine("Интернет подключен (напишите да, либо оставьте строку пустой, если интернет не подключен)?");
            string internet = Console.ReadLine();

            bool internetPay = !string.IsNullOrWhiteSpace(internet) && internet[0] == 'д' && internet[1] == 'а';

            if (internetPay == false)
            {
                Console.WriteLine("Интернет не подключен, в итоговый расчет это не будет включено");
            }

            if (internetPay == false)
            {
                double total = Math.Round((((PRSapartArea * 44.25) * (1 + (0.04 * PRSfloorNumb))) + (PRSelectricity * 4.7) + (PRShotWater * 80.15) + (PRScoldWater * 48.72) + (PRSgas * 2.42) + (PRSheating * 1273)), 2);
                string STRtotal = total.ToString("N2");
                char separator = ',';
                string[] STRseparatedTotal = STRtotal.Split(separator);
                Console.WriteLine("\nИтоговая сумма: " + STRseparatedTotal[0] + " руб. " + STRseparatedTotal[1] + " коп.");
            }
            else if (internetPay == true)
            {
                double total = Math.Round(((((PRSapartArea * 44.25) * (1 + (0.04 * PRSfloorNumb))) + (PRSelectricity * 4.7) + (PRShotWater * 80.15) + (PRScoldWater * 48.72) + (PRSgas * 2.42) + (PRSheating * 1273) + 400)), 2);
                string STRtotal = total.ToString("N2");
                char separator = ',';
                string[] STRseparatedTotal = STRtotal.Split(separator);
                Console.WriteLine("\nИтоговая сумма: " + STRseparatedTotal[0] + " руб. " + STRseparatedTotal[1] + " коп.");
            }

            Console.ReadLine();
        }
    }
}
