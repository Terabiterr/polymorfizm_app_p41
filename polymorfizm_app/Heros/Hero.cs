namespace polymorfizm_app.Heros
{
    public abstract class Hero //Base, Super, Parent
    {
        public abstract string? Name { get; set; }
        public Hero(string? name)
        {
            Name = name;
        }

        public abstract void Attack();
        //Додати клас Ork до ієрархії успадкування Hero
    }
}
