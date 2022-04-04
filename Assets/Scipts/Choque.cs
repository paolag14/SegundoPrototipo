using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Choque : MonoBehaviour
{
    private Personaje personaje;
    
    void Awake(){
        personaje = GameObject.FindObjectOfType<Personaje>(); 
    }


    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, 1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
