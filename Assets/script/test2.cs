using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class test2 : MonoBehaviour
{
    [SerializeField] private GameObject _bullet;
    [SerializeField] private Transform _bulletRightshiftPos;
    private float _trmChange = 1;

    private void Start()
    {
        StartCoroutine(move());
        
    }

    private IEnumerator move()
    {
        while (true)
        {
            yield return new WaitForSeconds(0.1f);
            transform.position += new Vector3(_trmChange, 0, 0);

            if (transform.position.x >= 10 || -10 >= transform.position.x)
                _trmChange *= -1;
        }
    }
}
