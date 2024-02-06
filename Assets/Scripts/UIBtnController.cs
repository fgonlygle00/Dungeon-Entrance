using UnityEngine;

public class UIBtnController : MonoBehaviour
{
    public GameObject statusWindow;
    public GameObject inventroyWindow;

    // 부가 요소 오브젝트
    public GameObject eyeBtn; // 화면 하당 눈 버튼
    public GameObject allUImage; // 전체 UI

    // 상태보기 버튼 누르면 상태창 표시
    public void StatusBtn()
    {
        statusWindow.SetActive(true);
    }

    // 인벤토리 버튼 누르면 인벤토리창 표시
    public void InventroyBtn()
    {
        inventroyWindow.SetActive(true);
    }

    // 상태, 인벤 창 닫기
    public void WindowCloseBtn()
    {
        statusWindow.SetActive(false);
        inventroyWindow.SetActive(false);
    }

    // 내가 그냥 넣은 부가 요소
    // 눈 표시 버튼 누르면 UI 숨기기
    public void CloseOpenEyeBtn()
    {
        eyeBtn.SetActive(!eyeBtn.activeSelf);
        allUImage.SetActive(!allUImage.activeSelf);
    }
}
