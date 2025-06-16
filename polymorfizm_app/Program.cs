using polymorfizm_app.Heros;

namespace polymorfizm_app
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Elf elf = new Elf();
            Gnom gnom = new Gnom();
            HeroAttack(elf);
            HeroAttack(gnom);
            Console.ReadKey();
        }
        public static void HeroAttack(Hero hero)
        {
            hero.Attack();
        }
    }
}
