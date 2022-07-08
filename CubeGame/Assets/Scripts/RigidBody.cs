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
        //Це блокує RigidBody, щоб воно не рухалося і не оберталося по осі y (можна побачити в Inspector).
        m_Rigidbody.constraints = RigidbodyConstraints.FreezePositionZ | RigidbodyConstraints.FreezeRotationZ;
        //Налаштування вектора для переміщення Rigidbody по осі z 
        m_YAxis = new Vector3(0, 0, 0);
    }

    void Update()
    {
        //Натисніть пробіл, щоб видалити обмеження на RigidBody
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //Видалити всі обмеження
            m_Rigidbody.constraints = RigidbodyConstraints.None;
        }

        //Натисніть клавішу зі стрілкою вгору, щоб переміщатися по осі y, якщо обмеження знято 
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            //Якщо обмеження знято, Rigidbody рухається вздовж осі y 
            //Якщо обмеження є, рух не відбувається 
            m_Rigidbody.velocity = m_YAxis;
        }

        //Натисніть клавішу зі стрілкою вниз, щоб переміститися в негативному напрямку по осі y, якщо обмеження знято, 
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            m_Rigidbody.velocity = -m_YAxis;
        }
    }
}
