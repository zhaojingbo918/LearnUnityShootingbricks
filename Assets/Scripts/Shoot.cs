using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public int Speed = 3;

    public GameObject Bullet;

    // Use this for initialization
    void Start()
    {
        Debug.Log("shoot Start");
    }

    // Update is called once per frame
    void Update()
    {
        //  Debug.Log("shoot update");
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("shoot update mousebuttondown");
            var temp = GameObject.Instantiate(Bullet, transform);
            var rigidbody = temp.GetComponent<Rigidbody>();
            var velocity = transform.forward * Speed;
            rigidbody.velocity = velocity;

            Debug.Log(string.Format("速度：{0}", velocity.ToString()));
        }
    }
}
