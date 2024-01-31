using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Transform target; // ����, � ������� ����� ��������� ����
    public float moveSpeed = 5f; // �������� �������� �����
    public int health = 100;
    public void TakeDamage(int damage)
    {
        health -= damage; 
        if(health<=0)
        {
             Destroy(gameObject);
        }
    }

    void Update()
    {
        if (target != null)
        {
            // ��������� ����������� � ����
            Vector3 direction = target.position - transform.position;

            // ����������� �����������, ����� ��������� � ���������� ���������
            direction.Normalize();

            // ���������� ����� � ����������� ����
            transform.position += direction * moveSpeed * Time.deltaTime;
        }

       
    }
    


}