using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bala : MonoBehaviour
{
    private int score = 1;
    private Personaje personaje;  

    void Awake(){
        personaje = GameObject.FindObjectOfType<Personaje>(); 
    }
    
    // Start is called before the first frame update
    void Start(){
        // destruir bala después de 5 segundos
        Destroy(gameObject, 5);
    }

    // Update is called once per frame
    void Update(){
        transform.Translate(0, 10 * Time.deltaTime, 0, Space.World); 
    }

    void OnTriggerEnter(Collider c){
        Destroy(c.gameObject); // destruir enemigo 
        Destroy(gameObject);  // destruir bala

        // puntaje - kills
        personaje.UpdateScore(score); 
    }
}
