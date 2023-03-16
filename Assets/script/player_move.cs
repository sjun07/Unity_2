using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_move : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private GameObject _bullet;
    [SerializeField] private Transform _bulletSpasePos;
    private Rigidbody2D _rigidbody2D;

    private void Awake()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        move();
        Shoot();
    }
    private void move()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");
        Vector3 pos = new Vector3(x, y, 0);

        //transform.position += pos * _speed * Time.deltaTime;
        //transform.Translate(pos * _speed * Time.deltaTime); //loacl ÁÂÇ¥
        _rigidbody2D.velocity = _speed * pos;
        
    }
    private void Shoot()
    {
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            GameObject bullet = Instantiate(_bullet);
            bullet.transform.position = _bulletSpasePos.position;
            bullet.transform.rotation = Quaternion.identity;    
        }
    }

}
