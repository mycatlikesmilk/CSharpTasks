namespace CSharpTasks
{
    internal class Program
    {
        /*  Битва игрок vs комп. 
            У каждого из них есть показатели ХП и маны. 
            Игрок может делать 3 действия:
            1)Атаковать
            2)Хилиться
            3)Восстановить ману

            Противник может делать 3 действия:
            1)Атаковать
            2)Хилиться
            3)Украсть ману игрока

            Атака игрока наносит противнику 2-6 урона и тратит 1-3 маны. 
            Хил игрока восстанавливает 2-5 ХП и тратит 1-3 маны.
            Восстановление маны игрока - восстанавливает 3-7 маны.

            Атака Компьютера наносит игроку 2-8 урона и тратит 1-3 маны.
            Хил Компьютера восстанавливает 1-4 ХП и тратит 1-3 маны.
            Кража маны - забирает у игрока 1-4 маны. 

            Игрок и Комп делают действия по-очереди. 
            
            В свой ход Игрок может выбрать одно из 3-х действий. 
            Противник атакует, если у него 20< ХП, хилится, если у него <=20 ХП и похищает ману, если у него <=5 маны.

            Игрок побеждает, если здоровье Компьютера <=0 , игрок проигрывает, если его здоровье или мана <=0. 
        
            Начальные параметры
            Игрок: 40 ХП 20 маны;
            Противник 50 ХП 30 маны; 
         */
        static void Main(string[] args)
        {
            Random random = new Random();
            var count = 1;

            //Параметры героя
            var hpHero = 40;
            var manaHero = 20;

            //Параметры ПК
            var hpPC = 50;
            var manaPC = 30;


            do
            {
                Console.WriteLine("ХОД ИРОКА\n\n");
                Console.WriteLine($"Ход номер: {count++}\n\n");
                Console.WriteLine($"Показатели Компьютера:\nХП: {hpPC}\nМана: {manaPC}\n\nВаши показатели:\nХП: {hpHero}\nМана: {manaHero}\n");
                Console.WriteLine("Игрок, выберите действие\n1)Атаковать\n2)Хилиться\n3)Восстановить ману");
                var heroChoice = Console.ReadLine();

                

                if (heroChoice == "1")
                {
                    Console.WriteLine("Вы выбрали \"Атаковать\"\n ");
                    var heroDamage = random.Next(2, 7);
                    var heroManaUse = random.Next(1, 4);
                    hpPC = hpPC - heroDamage;
                    manaHero = manaHero - heroManaUse;

                    Console.WriteLine($"Вы нанесли урон равный: {heroDamage}, затратив на это {heroManaUse} маны\n\nПоказатели Компьютера:\nХП: {hpPC}\nМана: {manaPC}\n\nВаши показатели:\nХП: {hpHero}\nМана: {manaHero}\n\n\n");

                }
                else if (heroChoice == "2")
                {
                    Console.WriteLine("Вы выбрали \"Хилиться\"\n");
                    var heroHeal = random.Next(2, 6);
                    var heroManaUse = random.Next(1, 4);
                    hpHero = hpHero + heroHeal;
                    manaHero = manaHero - heroManaUse;


                    Console.WriteLine($"Вы похилили себя на: {heroHeal} ХП, затратив на это {heroManaUse} маны\n\nПоказатели Компьютера:\nХП: {hpPC}\nМана: {manaPC}\n\nВаши показатели:\nХП: {hpHero}\nМана: {manaHero}\n\n\n");

                }
                else if (heroChoice == "3")
                {
                    Console.WriteLine("Вы выбрали \"Восстановить ману\"\n");
                    var heroManaReset = random.Next(3, 8);
                    manaHero = manaHero + heroManaReset;

                    Console.WriteLine($"Вы восстановили ману на {heroManaReset} ед.\n\nПоказатели Компьютера:\nХП: {hpPC}\nМана: {manaPC}\n\nВаши показатели:\nХП: {hpHero}\nМана: {manaHero}\n\n\n");

                }

                Console.WriteLine("ХОД КОМПЬЮТЕРА\n");
                Thread.Sleep(3000);


                if (manaPC <= 5)
                {
                    Console.WriteLine("Компьютер ворует у вас ману!\n");
                    var PCManaSteal = random.Next(1, 4);
                    manaHero = manaHero - PCManaSteal;
                    manaPC = manaPC + PCManaSteal;

                    Console.WriteLine($"Компьютер украл у вас ману в количестве {PCManaSteal} ед.\n\nПоказатели Компьютера:\nХП: {hpPC}\nМана: {manaPC}\n\nВаши показатели:\nХП: {hpHero}\nМана: {manaHero}\n\n\n");
                }
                else if (hpPC <= 20)
                {
                    Console.WriteLine("Компьютер хилится!\n");
                    var PCHeal = random.Next(1, 4);
                    var PCManaUse = random.Next(1, 4);
                    hpPC = PCHeal + hpPC;
                    manaPC = manaPC - PCManaUse;

                    Console.WriteLine($"Компьютер похилился на {PCHeal} ед.\n\nПоказатели Компьютера:\nХП: {hpPC}\nМана: {manaPC}\n\nВаши показатели:\nХП: {hpHero}\nМана: {manaHero}\n\n\n");
                }
                else if (hpPC > 20)
                {
                    Console.WriteLine("Компьютер атакует вас!\n");
                    var PCDamage = random.Next(2, 9);
                    var PCManaUse = random.Next(1, 4);
                    hpHero = hpHero - PCDamage;
                    manaPC = manaPC - PCManaUse;

                    Console.WriteLine($"Компьютер нанёс вам урон в {PCDamage} ед.\n\nПоказатели Компьютера:\nХП: {hpPC}\nМана: {manaPC}\n\nВаши показатели:\nХП: {hpHero}\nМана: {manaHero}\n\n\n");
                }

                Console.WriteLine("\n\nНажмите ENTER для завершения хода");
                Console.ReadLine();
                Console.Clear();

            }
            while (hpHero > 0 && manaHero > 0 && hpPC > 0);

            if (hpHero <= 0)
            {
                Console.WriteLine("Вы ПРОИГРАЛИ! ВАШЕ ХП РАВНО НУЛЮ!\nПопробуйте снова!");
            }
            else if (manaHero <= 0)
            {
                Console.WriteLine("Вы ПРОИГРАЛИ! ВАША МАНА РАВНА НУЛЮ!\nПопробуйте снова!");
            }
            else if (hpPC <= 0)
            {
                Console.WriteLine("Вы ПОБЕДИЛИ КОМПЬЮТЕР ПОВЕРЖЕН!\nПопробуйте снова!");
            }

            Console.ReadLine();
        }
    }
}