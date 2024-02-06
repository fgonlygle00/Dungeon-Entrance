using UnityEngine;

public class PlayerEquipEquipment : PlayerEquipmentStats
{
    [SerializeField] private GameObject _equipWindow; // ���� Ȯ�� â

    [SerializeField] private GameObject _equipCheck; // ���� Ȯ��
    [SerializeField] private GameObject _equipdisplay; // �����Ϸ��� ��� ǥ��

    // ��â�Ϸ��� ��� ���ý� ���� Ȯ�� â
    public void EquipWindow()
    {
        _equipWindow.SetActive(true);
        _equipdisplay.SetActive(true);
    }

    // ���� ����
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

    // ���� ����
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
