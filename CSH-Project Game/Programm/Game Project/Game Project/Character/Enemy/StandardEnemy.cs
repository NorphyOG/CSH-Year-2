namespace Game_Project.Character.Enemy;

public class StandardEnemy
{
    private string _enemyName;
    private ulong _level;
    private ulong _schaden;
    private ulong _maxLeben;
    private ulong _aktuellesLeben;

    public string EnemyName
    {
        get => _enemyName;
        set => _enemyName = value ?? throw new ArgumentNullException(nameof(value));
    }

    public ulong Level
    {
        get => _level;
        set => _level = value;
    }

    public ulong Schaden
    {
        get => _schaden;
        set => _schaden = value;
    }

    public ulong MaxLeben
    {
        get => _maxLeben;
        set => _maxLeben = value;
    }

    public ulong AktuellesLeben
    {
        get => _aktuellesLeben;
        set => _aktuellesLeben = value;
    }

    public StandardEnemy(string enemyName, ulong level, ulong schaden, ulong maxLeben, ulong aktuellesLeben)
    {
        _enemyName = enemyName;
        _level = level;
        _schaden = schaden;
        _maxLeben = maxLeben;
        _aktuellesLeben = aktuellesLeben;
    }
    
    public override string ToString()
    {
        return EnemyName + ";" + Level + ";" + Schaden + ";" + MaxLeben + ";" + AktuellesLeben;
    }
}