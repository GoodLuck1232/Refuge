using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RigidBody : MonoBehaviour
{
    Rigidbody m_Rigidbody;
    Vector3 m_YAxis;

    void Start()
    {
        m_Rigidbody = GetComponent<Rigidbody>();
        //�� ����� RigidBody, ��� ���� �� �������� � �� ���������� �� �� y (����� �������� � Inspector).
        m_Rigidbody.constraints = RigidbodyConstraints.FreezePositionZ | RigidbodyConstraints.FreezeRotationZ;
        //������������ ������� ��� ���������� Rigidbody �� �� z 
        m_YAxis = new Vector3(0, 0, 0);
    }

    void Update()
    {
        //�������� �����, ��� �������� ��������� �� RigidBody
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //�������� �� ���������
            m_Rigidbody.constraints = RigidbodyConstraints.None;
        }

        //�������� ������ � ������� �����, ��� ����������� �� �� y, ���� ��������� ����� 
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            //���� ��������� �����, Rigidbody �������� ������ �� y 
            //���� ��������� �, ��� �� ���������� 
            m_Rigidbody.velocity = m_YAxis;
        }

        //�������� ������ � ������� ����, ��� ������������ � ����������� �������� �� �� y, ���� ��������� �����, 
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            m_Rigidbody.velocity = -m_YAxis;
        }
    }
}
