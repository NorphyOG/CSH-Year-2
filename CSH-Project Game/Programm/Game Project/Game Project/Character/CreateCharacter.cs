using Game_Project.Character.Enemy;
using Game_Project.Character.Klassen;

namespace Game_Project.Character;

public class CreateCharacter
{
    private StandardKlasse _bogenSchuetze;
    private StandardKlasse _ritter;
    private StandardKlasse _megier;

    private Begleiter _antonio;
    private Begleiter _adrian;
    private Begleiter _johannes;

    private StandardEnemy _goblin;
    private MiniBoss _goblinMiniBoss;
    private Boss _goblinBoss;
    
    private StandardEnemy _oger;
    private MiniBoss _ogerMiniBoss;
    private Boss _ogerBoss;
    
    private StandardEnemy _cyclope;
    private MiniBoss _cyclopeMiniBoss;
    private Boss _cyclopeBoss;


    public StandardKlasse BogenSchuetze
    {
        get => _bogenSchuetze;
        set => _bogenSchuetze = value ?? throw new ArgumentNullException(nameof(value));
    }

    public StandardKlasse Ritter
    {
        get => _ritter;
        set => _ritter = value ?? throw new ArgumentNullException(nameof(value));
    }

    public StandardKlasse Megier
    {
        get => _megier;
        set => _megier = value ?? throw new ArgumentNullException(nameof(value));
    }

    public Begleiter Antonio
    {
        get => _antonio;
        set => _antonio = value ?? throw new ArgumentNullException(nameof(value));
    }

    public Begleiter Adrian
    {
        get => _adrian;
        set => _adrian = value ?? throw new ArgumentNullException(nameof(value));
    }

    public Begleiter Johannes
    {
        get => _johannes;
        set => _johannes = value ?? throw new ArgumentNullException(nameof(value));
    }

    public StandardEnemy Goblin
    {
        get => _goblin;
        set => _goblin = value ?? throw new ArgumentNullException(nameof(value));
    }

    public MiniBoss GoblinMiniBoss
    {
        get => _goblinMiniBoss;
        set => _goblinMiniBoss = value ?? throw new ArgumentNullException(nameof(value));
    }

    public Boss GoblinBoss
    {
        get => _goblinBoss;
        set => _goblinBoss = value ?? throw new ArgumentNullException(nameof(value));
    }

    public StandardEnemy Oger
    {
        get => _oger;
        set => _oger = value ?? throw new ArgumentNullException(nameof(value));
    }

    public MiniBoss OgerMiniBoss
    {
        get => _ogerMiniBoss;
        set => _ogerMiniBoss = value ?? throw new ArgumentNullException(nameof(value));
    }

    public Boss OgerBoss
    {
        get => _ogerBoss;
        set => _ogerBoss = value ?? throw new ArgumentNullException(nameof(value));
    }

    public StandardEnemy Cyclope
    {
        get => _cyclope;
        set => _cyclope = value ?? throw new ArgumentNullException(nameof(value));
    }

    public MiniBoss CyclopeMiniBoss
    {
        get => _cyclopeMiniBoss;
        set => _cyclopeMiniBoss = value ?? throw new ArgumentNullException(nameof(value));
    }

    public Boss CyclopeBoss
    {
        get => _cyclopeBoss;
        set => _cyclopeBoss = value ?? throw new ArgumentNullException(nameof(value));
    }

    public CreateCharacter(StandardKlasse bogenSchuetze, StandardKlasse ritter, StandardKlasse megier, Begleiter antonio, Begleiter adrian, Begleiter johannes, StandardEnemy goblin, MiniBoss goblinMiniBoss, Boss goblinBoss, StandardEnemy oger, MiniBoss ogerMiniBoss, Boss ogerBoss, StandardEnemy cyclope, MiniBoss cyclopeMiniBoss, Boss cyclopeBoss)
    {
        _bogenSchuetze = bogenSchuetze;
        _ritter = ritter;
        _megier = megier;
        _antonio = antonio;
        _adrian = adrian;
        _johannes = johannes;
        _goblin = goblin;
        _goblinMiniBoss = goblinMiniBoss;
        _goblinBoss = goblinBoss;
        _oger = oger;
        _ogerMiniBoss = ogerMiniBoss;
        _ogerBoss = ogerBoss;
        _cyclope = cyclope;
        _cyclopeMiniBoss = cyclopeMiniBoss;
        _cyclopeBoss = cyclopeBoss;
    }
}