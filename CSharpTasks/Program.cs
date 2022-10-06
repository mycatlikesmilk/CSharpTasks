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
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
            double sum;

            Console.Write("Введите метраж квартиры (м^2) с точностью до десятых: ");
            var square = Console.ReadLine();
            double squareD = Convert.ToDouble(square);
            double squarePrice = squareD * 44.25;

            Console.Write("Введите этаж квартиры: ");
            var floor = Console.ReadLine();
            double floorD = Convert.ToDouble(floor);
            double floorPrice = squarePrice * (floorD * 0.04);

            Console.Write("Введите количество электроэнергии (кВт) с точностью до сотых: ");
            var elec = Console.ReadLine();
            double elecD = Convert.ToDouble(elec);
            double elecPrice = elecD * 4.70;

            Console.Write("Введите количество горячей воды (м^3): ");
            var hotWater = Console.ReadLine();
            double hotWaterD = Convert.ToDouble(hotWater);
            double hotWaterPrice = hotWaterD * 80.15;

            Console.Write("Введите количество холодной воды (м^3): ");
            var coldWater = Console.ReadLine();
            double coldWaterD = Convert.ToDouble(coldWater);
            double coldWaterPrice = coldWaterD * 48.72;

            if (floorD <= 11)
            {
                Console.Write("Введите количество потребляемого газа (м^3) с точностью до десятых: ");
                var gas = Console.ReadLine();
                double gasD = Convert.ToDouble(gas);
                double gasPrice = gasD * 2.42;
            }

            Console.Write("Введите количество отопления (гКалл) с точностью до десятых: ");
            var hot = Console.ReadLine();
            double hotD = Convert.ToDouble(hot);
            double hotPrice = hotD * 1273;

            Console.Write("Подключен ли интернет? (да/нет): ");
            var inet = Console.ReadLine();

            if (inet == "yes" || inet == "Yes" || inet == "YES" || inet == "yES" || inet == "YEs" || inet == "yEs" || inet == "yeS")
            {
                sum = squarePrice + floorPrice + elecPrice + hotWaterPrice + coldWaterPrice + hotPrice + 400;
                var rubles = Math.Truncate(sum);
                var copies = sum - rubles;
                copies = copies * 100;


                Console.Write($"Итоговая сумма: {rubles} рубля(ей) {copies.ToString("N0")} копеек");
            }
            else if (inet == "no" || inet == "No" || inet == "NO" || inet == "nO" )
            {
                sum = squarePrice + floorPrice + elecPrice + hotWaterPrice + coldWaterPrice + hotPrice;
                var rubles = Math.Truncate(sum);
                var copies = sum - rubles;
                copies = copies * 100;

                Console.Write($"Итоговая сумма: {rubles} рубля(ей) {copies.ToString("N0")} копеек");
            }
            else
            {
                Console.WriteLine("Ваш ответ не распознан, ответ по-умолчанию: да");
                sum = squarePrice + floorPrice + elecPrice + hotWaterPrice + coldWaterPrice + hotPrice + 400;
                var rubles = Math.Truncate(sum);
                var copies = sum - rubles;
                copies = copies * 100;

                Console.Write($"Итоговая сумма: {rubles} рубля(ей) {copies.ToString("N0")} копеек");
            }

            Console.ReadLine();
        }
    }
}
