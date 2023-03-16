using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_move : MonoBehaviour
{
    [SerializeField] private float _speed;
    private void Update()
    {
        if (Input.GetKey(KeyCode.L))
        {
            transform.position += new Vector3(_speed, 0, 0);
        }
        if (Input.GetKey(KeyCode.J))
        {
            transform.position += new Vector3(-_speed, 0, 0);
        }
        if (Input.GetKey(KeyCode.K))
        {
            transform.position += new Vector3(0, -_speed, 0);
        }
        if (Input.GetKey(KeyCode.I))
        {
            transform.position += new Vector3(0, _speed, 0);
        }
    }
}
