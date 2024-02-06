using UnityEngine;

public class PlayerEquipEquipment : PlayerEquipmentStats
{
    [SerializeField] private GameObject _equipWindow; // 장착 확인 창

    [SerializeField] private GameObject _equipCheck; // 장착 확인
    [SerializeField] private GameObject _equipdisplay; // 장착하려는 장비 표시

    // 작창하려는 장비 선택시 장착 확인 창
    public void EquipWindow()
    {
        _equipWindow.SetActive(true);
        _equipdisplay.SetActive(true);
    }

    // 착용 선택
    public void EquipEquipment()
    {
        if (!_equipCheck.activeSelf)
        {
            PlayerStatus.instance.Atk += Atk;
            PlayerStatus.instance.Def += Def;
            PlayerStatus.instance.Hp += Hp;
            PlayerStatus.instance.Critical += Critical;
        }
        _equipCheck.SetActive(true);
        _equipWindow.SetActive(false);
        _equipdisplay.SetActive(false);
    }

    // 해제 선택
    public void UnEquipEquipment()
    {
        if (_equipCheck.activeSelf)
        {
            PlayerStatus.instance.Atk -= Atk;
            PlayerStatus.instance.Def -= Def;
            PlayerStatus.instance.Hp -= Hp;
            PlayerStatus.instance.Critical -= Critical;
        }
        _equipCheck.SetActive(false);
        _equipWindow.SetActive(false);
        _equipdisplay.SetActive(false);
    }
}
