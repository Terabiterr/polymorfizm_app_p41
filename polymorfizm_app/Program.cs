using polymorfizm_app.Heros;

namespace polymorfizm_app
{
    public class Program
    {
        //Static Polymorphism
        public static void PrintX(int x)
            => Console.WriteLine(x);
        public static void PrintX(char x)
            => Console.WriteLine(x);
        public static void PrintX(float x)
            => Console.WriteLine(x);
        public static void Main(string[] args)
        {
            //Dynamic Polymorphism
            //Hero hero;
            //Hero elf = new Elf("Elf");
            //Hero gnome = new Gnome("Gnome");
            ////hero = elf;
            ////hero.Attack();
            ////hero = gnome;
            ////hero.Attack();
            //HeroAttack(elf);
            //HeroAttack(gnome);
            //Hero hero = new Hero("Name"); //Error
            Hero[] heros =
            {
                new Elf("Elf"),
                new Gnome("Gnome"),
                new Ork("Ork")
            };
            foreach (var hero in heros)
            {
                HeroAttack(hero);
            }
            Console.ReadKey();
        }
        //One interface many realization
        public static void HeroAttack(Hero hero)
        {
            hero.Attack();
        }
    }
}
