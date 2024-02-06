# Dungeon Entrance
Unity 3D(?) 개인 과제

## 🖥️프로젝트 소개
Untiy 3D강의 중 개인 과제로 2D가 나와서 3D로 변형 해서 작업을 진행하였다.

캐릭터의 기본 정보 및 아이템을 착용/해제 하는 기능을 구현 하였다.

## 🗓️개발 기간
* 2024.02.01 ~ 2024.02.07

## 👨‍👩‍👧‍👦멤버 구성
* 개인 과제

## 🪟개발 환경
* Unity Editor 2022.3.2f1

* Visual Studio 2022

* Window 11

## ✨주요 기능
* 필수 기능 - 메인 화면 구성, Status 보기, Inventroy 보기

* 선택 기능 - 아이템 장착 팝업 업그레이드

## 📄CS 구성
* < DragAndRotate > 캐릭터를 마우스 오른쪽을 누른 상태에서 좌우로 드래그하면 캐릭터 회전
<details>
<summary>DragAndRotate.cs 내용</summary>

    using UnityEngine;
    
    public class DragAndRotate : MonoBehaviour
    {
        bool rotating;
        float rotateSpeed = 50.0f;
        Vector3 mousePos, offset, rotation;
    
        // 해당 오브젝트에 Collider만 있으면 이 기능을 사용할 수 있음(OnMouseDown, OnMouseUp에 마우스포인트 가져다 대면 설명 나옴)
        void OnMouseDown()
        {
            rotating = true;
            mousePos = Input.mousePosition;
        }
    
        void OnMouseUp()
        {
            rotating = false;
        }
    
        void Update()
        {
            if (rotating)
            {
                offset = (Input.mousePosition - mousePos);
                rotation.y = -(offset.x + offset.y) * Time.deltaTime * rotateSpeed;
                transform.Rotate(rotation);
                mousePos = Input.mousePosition;
            }
        }
    }
</details>

* < UIBtnController > 화면에 보여지는 UI 버튼 상호작용 기능
<details>
<summary>UIBtnController.cs 내용</summary>

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
</details>

* < PlayerStatus > 캐릭터의 상태 데이터 및 표시
<details>
<summary>PlayerStatus.cs 내용</summary>

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
            Name = "지훈";
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
</details>

* < PlayerEquipmentStats > 캐릭터의 장비의 스텟 데이터 및 표
<details>
<summary>PlayerEquipmentStats.cs 내용</summary>

    using UnityEngine;
    using UnityEngine.UI;
    
    public class PlayerEquipmentStats : MonoBehaviour
    {
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
</details>

* < PlayerEquipEquipment > 캐릭터 장비 장착/해제 기능 및 팝업 창
<details>
<summary>PlayerEquipEquipment.cs 내용</summary>

    using UnityEngine;
    
    public class PlayerEquipEquipment : PlayerEquipmentStats
    {
        [SerializeField] private GameObject _equipWindow;
    
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
</details>

## 그외 기타 내용은 팀 노션에서
### <https://teamsparta.notion.site/T1-fca79e3e985a48faa7e27de75899d2ad>
