using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OtroEnemigo : MonoBehaviour
{
    [SerializeField]
    private float speed = 20f;

    [SerializeField]
    private GameObject balaEnemiga; 

    //corrutina
    private IEnumerator disparoCorrutina;

    private float fireRate = 0.01f;
    private float nextFire = 5;

    private int vidaEnemigo;

    SoundManager sonidos;


    
    // Start is called before the first frame update
    void Start()
    {   
        Destroy(gameObject, 20);
        sonidos = GameObject.FindObjectOfType<SoundManager>(); 

        disparoCorrutina = Disparo();
        Disparando();
        
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

    private void Disparando() {
        if (Time.time> nextFire){
            nextFire = Time.time + fireRate;
        }

        Instantiate(balaEnemiga, transform.position, Quaternion.Euler(0,0,0));
        sonidos.sonidoOtraBala();
        //algo.AddRelativeForce(Vector3.forward*3);
        //algo.transform.Translate(0, 2 * Time.deltaTime, 0);
    }


    private IEnumerator Disparo(){
        while(true){
            Instantiate(balaEnemiga, transform.position, transform.rotation);
            yield return new WaitForSeconds(5);
        }
    }
    
}

