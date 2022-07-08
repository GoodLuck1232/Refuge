using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragDrop : MonoBehaviour

{
    Rigidbody m_Rigidbody;
    Vector3 BlueCub;

    void Start()
    {
        m_Rigidbody = GetComponent<Rigidbody>();
        //�� ����� RigidBody, ��� ���� �� �������� � �� ���������� �� �� y (����� �������� � Inspector).
        m_Rigidbody.constraints = RigidbodyConstraints.FreezePositionZ | RigidbodyConstraints.FreezeRotationZ;
        //������������ ������� ��� ���������� Rigidbody �� �� y 
        BlueCub = new Vector3(1, 0, 0);
    }

    void OnMauseDown()
    {
        BlueCub = transform.position - MouseWorldPosition();
    }

    private void OnMouseDrag()
    {
        transform.position = MouseWorldPosition() + BlueCub;
    }

    Vector3 MouseWorldPosition() 
    {
        var mouseScreenPos = Input.mousePosition;
        mouseScreenPos.z = Camera.main.WorldToScreenPoint(transform.position).z;
        return Camera.main.ScreenToWorldPoint(mouseScreenPos);
    }
}                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                               