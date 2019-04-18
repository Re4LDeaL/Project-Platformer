using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinController : MonoBehaviour
{

    public float rotationSpeed = 1000; //rotation speed
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float angleRot = rotationSpeed * Time.deltaTime; // angle of rotation
        transform.Rotate(Vector3.up * angleRot, Space.World);
        
    }
}
