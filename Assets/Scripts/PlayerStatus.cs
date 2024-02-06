using UnityEngine;
using UnityEngine.UI;

public class PlayerStatus : MonoBehaviour
{
    public string Name { get; set; }
    public int Level { get; set; }
    public int Atk { get; set; }
    public int Def { get; set; }
    public int Hp { get; set; }
    public int Critical { get; set; }
    public int Gold { get; set; }

    [SerializeField] private Text _nameValue;
    [SerializeField] private Text _levelvalue;
    [SerializeField] private Text _atkValue;
    [SerializeField] private Text _defValue;
    [SerializeField] private Text _hpValue;
    [SerializeField] private Text _critcalValue;
    [SerializeField] private Text _goldValue;

    public static PlayerStatus instance;
    private void Awake()
    {
        instance = this;
        Name = "ÁöÈÆ";
        Level = 1;
        Atk = 10;
        Def = 5;
        Hp = 50;
        Critical = 0;
        Gold = 10000;
    }

    private void Update()
    {
        _nameValue.text = Name;
        _levelvalue.text = Level.ToString("00");
        _atkValue.text = Atk.ToString("N0");
        _defValue.text = Def.ToString("N0");
        _hpValue.text = Hp.ToString("N0");
        _critcalValue.text = Critical.ToString("N0");
        _goldValue.text = Gold.ToString("N0");
    }
}
