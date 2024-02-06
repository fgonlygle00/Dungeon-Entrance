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
