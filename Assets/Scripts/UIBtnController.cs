using UnityEngine;

public class UIBtnController : MonoBehaviour
{
    public GameObject statusWindow;
    public GameObject inventroyWindow;

    // �ΰ� ��� ������Ʈ
    public GameObject eyeBtn; // ȭ�� �ϴ� �� ��ư
    public GameObject allUImage; // ��ü UI

    // ���º��� ��ư ������ ����â ǥ��
    public void StatusBtn()
    {
        statusWindow.SetActive(true);
    }

    // �κ��丮 ��ư ������ �κ��丮â ǥ��
    public void InventroyBtn()
    {
        inventroyWindow.SetActive(true);
    }

    // ����, �κ� â �ݱ�
    public void WindowCloseBtn()
    {
        statusWindow.SetActive(false);
        inventroyWindow.SetActive(false);
    }

    // ���� �׳� ���� �ΰ� ���
    // �� ǥ�� ��ư ������ UI �����
    public void CloseOpenEyeBtn()
    {
        eyeBtn.SetActive(!eyeBtn.activeSelf);
        allUImage.SetActive(!allUImage.activeSelf);
    }
}
