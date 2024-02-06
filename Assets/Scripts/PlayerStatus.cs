using UnityEngine;
using UnityEngine.UI;

public class PlayerStatus : MonoBehaviour
{
    // 캐릭터 스텟 목록
    public string Name { get; set; }
    public int Level { get; set; }
    public int Atk { get; set; }
    public int Def { get; set; }
    public int Hp { get; set; }
    public int Critical { get; set; }
    public int Gold { get; set; }

    // 적용 될 친구들
    [SerializeField] private Text _nameValue;
    [SerializeField] private Text _levelvalue;
    [SerializeField] private Text _atkValue;
    [SerializeField] private Text _defValue;
    [SerializeField] private Text _hpValue;
    [SerializeField] private Text _critcalValue;
    [SerializeField] private Text _goldValue;

    // 아이템 장착시 스텟 변동이 필요해서 싱글턴화 진행
    public static PlayerStatus instance;
    private void Awake()
    {
        instance = this;
        Name = "지훈";
        Level = 1;
        Atk = 10;
        Def = 5;
        Hp = 50;
        Critical = 0;
        Gold = 10000;
    }

    // 지금 이렇게 작업하는거 좋지 않어... 다른 좋은 방법은 아는데... 참...
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
