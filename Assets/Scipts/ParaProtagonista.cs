using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParaProtagonista : MonoBehaviour
{
    private Personaje personaje;

    [SerializeField]
    private int life = 1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    void OnCollisionEnter2D(Collision2D c){
         // vidas
        personaje.UpdateLife(life);
        print("ALGOOOOOOO");
    }

}
