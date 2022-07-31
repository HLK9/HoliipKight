class Character
{
    public int Health {get; set;}
    public int Damage {get; set;}
    public int Defend {get; set;}
    public int Mana {get;set;} 
    public int Level {get;set;}
    public int EXP {get;set;}
    public string Class{get;set;}
    public string UserName{get;set;}
    public Character(int _health,int _damage, int _defend, int _mana, int _level, int _exp, string _class, string _userName)
    {
        Health = _health;
        Damage=_damage;
        Defend = _defend;
        Mana = _mana;
        Level = _level;
        EXP = _exp;
        Class = _class;
        UserName = _userName;
        
    }

}