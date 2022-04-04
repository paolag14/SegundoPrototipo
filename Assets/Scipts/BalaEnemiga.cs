using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalaEnemiga : MonoBehaviour
{
    [SerializeField]
    private float speed = 8;

    private Personaje personaje;

    [SerializeField]
    private GameObject explosion;
    

    void Awake(){
        personaje = GameObject.FindObjectOfType<Personaje>(); 
    }

    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, 5);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, speed * Time.deltaTime, 0);
    }

    void OnCollisionEnter2D(Collision2D c){
        //Instantiate(explosion, transform.position, transform.rotation);
        //Destroy(gameObject);

         // life
        //personaje.UpdateLife(1);
        print("que tocaaa " + c.gameObject.name);
    }
}
