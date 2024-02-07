using UnityEngine;
using UnityEngine.UI;

public class PlayerEquipmentStats : MonoBehaviour
{
    // 아이템 스텟 목록
    public string Name { get; private set; }
    public int Level { get; private set; }
    public int Atk { get; private set; }
    public int Def { get; private set; }
    public int Hp { get; private set; }
    public int Critical { get; private set; }
    public int Gold { get; private set; }

    // 스크립터블 오브젝트 데이터
    [SerializeField] private EquipmentStatsData _equipmentStats;

    // 적용 될 친구들
    [SerializeField] private Text _nameValue;
    [SerializeField] private Text _levelvalue;
    [SerializeField] private Text _atkValue;
    [SerializeField] private Text _defValue;
    [SerializeField] private Text _hpValue;
    [SerializeField] private Text _critcalValue;
    [SerializeField] private Text _goldValue;

    private void Awake()
    {
        Name = _equipmentStats.Name;
        Level = _equipmentStats.Level;
        Atk = _equipmentStats.Atk;
        Def = _equipmentStats.Def;
        Hp = _equipmentStats.Hp;
        Critical = _equipmentStats.Critical;
        Gold = _equipmentStats.Gold;
    }

    private void Start()
    {
        if (_nameValue != null)
            _nameValue.text = Name;
        if (_levelvalue != null)
            _levelvalue.text = Level.ToString("00");
        if (_atkValue != null)
            _atkValue.text = "+" + Atk.ToString("N0");
        if (_defValue != null)
            _defValue.text = "+" + Def.ToString("N0");
        if (_hpValue != null)
            _hpValue.text = "+" + Hp.ToString("N0");
        if (_critcalValue != null)
            _critcalValue.text = "+" + Critical.ToString("N0");
        if (_goldValue != null)
            _goldValue.text = Gold.ToString("N0");
    }
}
