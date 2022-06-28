namespace Game_Project.Character.Klassen;

public class StandardKlasse
{
    private string _characterName;
    private ulong _level;
    private double _maxMaxErfahrung;
    private double _aktuelleErfahrung;
    private ulong _schaden;
    private ulong _maxLeben;
    private ulong _aktuellesLeben;
    private ulong _maxActionPoints;
    private ulong _aktuelleActionPoints;
    private ulong _skillPoints;
    private bool _isDead;

    public bool IsDead
    {
        get => _isDead;
        set => _isDead = value;
    }

    public string CharacterName
    {
        get => _characterName;
        set => _characterName = value ?? throw new ArgumentNullException(nameof(value));
    }

    public ulong Level
    {
        get => _level;
        set => _level = value;
    }

    public double MaxErfahrung
    {
        get => _maxMaxErfahrung;
        set => _maxMaxErfahrung = value;
    }

    public double AktuelleErfahrung
    {
        get => _aktuelleErfahrung;
        set => _aktuelleErfahrung = value;
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

    public ulong MaxActionPoints
    {
        get => _maxActionPoints;
        set => _maxActionPoints = value;
    }

    public ulong AktuelleActionPoints
    {
        get => _aktuelleActionPoints;
        set => _aktuelleActionPoints = value;
    }

    public ulong SkillPoints
    {
        get => _skillPoints;
        set => _skillPoints = value;
    }

    public StandardKlasse(string characterName, ulong level, double maxMaxErfahrung, double aktuelleErfahrung, ulong schaden, ulong maxLeben, ulong aktuellesLeben, ulong maxActionPoints, ulong aktuelleActionPoints, ulong skillPoints, bool isDead)
    {
        _characterName = characterName;
        _level = level;
        _maxMaxErfahrung = maxMaxErfahrung;
        _aktuelleErfahrung = aktuelleErfahrung;
        _schaden = schaden;
        _maxLeben = maxLeben;
        _aktuellesLeben = aktuellesLeben;
        _maxActionPoints = maxActionPoints;
        _aktuelleActionPoints = aktuelleActionPoints;
        _skillPoints = skillPoints;
        _isDead = isDead;
    }

    public override string ToString()
    {
        return CharacterName + ";" + Level + ";" + MaxErfahrung + ";" + AktuelleErfahrung + ";" + Schaden + ";" +
               MaxLeben + ";" + AktuellesLeben + ";" +
               MaxActionPoints + ";" + AktuelleActionPoints + ";" + SkillPoints + ";" + IsDead;
    }
}