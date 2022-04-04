using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigo : MonoBehaviour
{
    [SerializeField]
    private float speed = 20f;

    [SerializeField]
    private GameObject balaEnemiga; 

    //corrutina
    private IEnumerator disparoCorrutina;

    [SerializeField]
    private float tiempoDisparo = 100;

    [SerializeField]
    private int cont = 1;


    
    // Start is called before the first frame update
    void Start()
    {   
        disparoCorrutina = Disparo();
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Random.Range(-10, 10);  
        float vertical = Random.Range(0, 10); 
        transform.Translate(
            horizontal * speed/100 * Time.deltaTime,
            vertical * speed/100 * Time.deltaTime,
            0);

        //StartCoroutine(disparoCorrutina);
        //ayuda, no sirveeeeeeeeeeeeeeee
        
    }


    private IEnumerator Disparo(){
        while(true){
            Instantiate(balaEnemiga, transform.position, transform.rotation);
            yield return new WaitForSeconds(tiempoDisparo);
        }
    }
    
}
