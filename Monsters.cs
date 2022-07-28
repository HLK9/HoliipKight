class Monsters
{
    public int Health {get;set;}
    public int Defend {get;set;}
    public int Damage {get; set;}
    public int EXP {get;set;}
    public string Name{get; set;}
    public Monsters(int _health,int _defend,int _damage,int _exp, string _name )
    {
        Health = _health;
        Defend =_defend;
        Damage=_damage;
        EXP = _exp;
        Name = _name;
    }
}
 