using UnityEngine;

public class DragAndRotate : MonoBehaviour
{
    bool rotating;
    float rotateSpeed = 50.0f;
    Vector3 mousePos, offset, rotation;

    // �ش� ������Ʈ�� Collider�� ������ �� ����� ����� �� ����(OnMouseDown, OnMouseUp�� ���콺����Ʈ ������ ��� ���� ����)
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
