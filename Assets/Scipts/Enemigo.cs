using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigo : MonoBehaviour
{
    [SerializeField]
    private float speed = 8;

    Vector3 movimiento;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        movimiento = new Vector3(Random.Range(-3.5f, 3), Random.Range(1.5f, 3.4f), 0);
        GetComponent<Rigidbody>().AddForce(movimiento * speed);
    }
}
