abstract class Character
{

    protected string characterType; 
    
    protected Character(string characterType)
    {
        this.characterType = characterType;
    }

    public abstract int DamagePoints(Character target);

    public virtual bool Vulnerable()
    {
        return false;
    }

    public override string ToString()
    {
        return $"Character is a {characterType}";
    }
}

class Warrior : Character
{
    private const int VulnerableDamage = 10;
    private const int NormalDamage = 6;
    
    public Warrior() : base("Warrior")
    {
    }

    public override int DamagePoints(Character target)
    {
        return target.Vulnerable() ? VulnerableDamage : NormalDamage;
    }
}

class Wizard : Character
{

    private const int PreppedDamage = 12;
    private const int NormalDamage = 3;
    
    private bool _hasPreparedSpell;
    
    public Wizard() : base("Wizard")
    {
    }

    public override int DamagePoints(Character target)
    {
        return _hasPreparedSpell ? PreppedDamage : NormalDamage;
    }

    public override bool Vulnerable()
    {
        return !_hasPreparedSpell;
    }

    public void PrepareSpell()
    {
        _hasPreparedSpell = true;
    }
}
