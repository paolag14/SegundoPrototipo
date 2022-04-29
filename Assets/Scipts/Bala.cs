using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bala : MonoBehaviour
{
    [SerializeField]
    private float speed = 8;

    [SerializeField]
    private int score = 1;

    private Personaje personaje;

    [SerializeField]
    private GameObject explosion;

    SoundManager sonidos;
    

    void Awake(){
        personaje = GameObject.FindObjectOfType<Personaje>(); 
    }


    // Start is called before the first frame update
    void Start()
    {
        //ESTRATEGIA DE DESTRUCCIÓN DE OBJETOS (BALAS)
        Destroy(gameObject, 5);
        sonidos = GameObject.FindObjectOfType<SoundManager>(); 
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, speed * Time.deltaTime, 0);
        
    }

    void OnCollisionEnter2D(Collision2D c){
        ContactPoint2D contacto = c.GetContact(0);
        if (c.gameObject.name != "vida(Clone)"){

            Instantiate(explosion, transform.position, transform.rotation);
            Destroy(c.gameObject);
            Destroy(gameObject);
            sonidos.sonidoExplosion();


         // puntaje - kills
            personaje.UpdateScore(score);
        }

    }

}
