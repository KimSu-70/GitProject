using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    public float jumpPower;

    public Rigidbody rigidbody;

    private void Update()
    {
        if(transform.position.y <= 0.6)
        {
            rigidbody.AddForce(Vector3.up * jumpPower, ForceMode.Impulse);
        }
    }
}
