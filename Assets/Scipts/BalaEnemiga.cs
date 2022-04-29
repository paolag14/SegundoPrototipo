using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalaEnemiga : MonoBehaviour
{
    [SerializeField]
    private float speed = 6;

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
        //transform.Translate(0, speed * Time.deltaTime, 0, Space.World);
        transform.Translate(Vector3.down * Time.deltaTime * speed, Space.World);
    }

    void OnCollisionEnter2D(Collision2D c){
        /*
        //ContactPoint2D contacto = c.GetContact(0);
        if (c.gameObject.name!="Enemigo(Clone)"){
            print("ahuevo");
        }
        else {
        Instantiate(explosion, transform.position, transform.rotation);
        Destroy(c.gameObject);
        Destroy(gameObject);
        }
        //sonidos.sonidoExplosion();
        */

        //Instantiate(explosion, transform.position, transform.rotation);
        //Destroy(gameObject);

         // life
        //personaje.UpdateLife(1);
        //print("que tocaaa " + c.gameObject.name);
        if (c.gameObject.name == "Protagonista"){
            print ("ahuevo, mlp");
        }
        
    }

    void OnControllerColliderHit(ControllerColliderHit hit){
        print(hit.gameObject.name);
    }

    void OnCollisionExit2D(Collision2D c){
        //print("que tocaaa " + c.gameObject.name);
    }
}
