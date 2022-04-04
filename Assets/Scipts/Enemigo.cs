using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigo : MonoBehaviour
{
    [SerializeField]
    private float speed = 20f;


    private Personaje personaje;

    void Awake(){
        personaje = GameObject.FindObjectOfType<Personaje>(); 
    }
    
    // Start is called before the first frame update
    void Start()
    {

        
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Random.Range(-4, 4);  
        float vertical = Random.Range(0, 4); 
        transform.Translate(
            horizontal * speed/100 * Time.deltaTime,
            vertical * speed/100 * Time.deltaTime,
            0); 
        //yield return new WaitForSeconds(0.5f);
    }

    

    public void OnColliderEnter2D(Collider2D c){
        //if (c.gameObject.name == "Protagonista") {
          //  print("algo pasaaaaaa");
            //personaje.UpdateLife(1);
        //}
        //else{
            print(c.gameObject.name);
        //}

    }  

    
}
