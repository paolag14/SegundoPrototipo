using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParaEnemigos : MonoBehaviour
{
    //private IEnumerator GenerarEnemigo;
    //private IEnumerator GenerarEnemigo2;

    public GameObject enemigo;

    public GameObject otroEnemigo;

    //[SerializeField]
    //private float speed = 16;

    //public Text levelText;
    //[SerializeField]
    //private float nivel = 1;


    private Personaje personaje;


    void Awake(){
        personaje = GameObject.FindObjectOfType<Personaje>(); 
    }

    // Start is called before the first frame update
    void Start()
    {   
        /*
        if (personaje.nivel == 1){
            StartCoroutine(GenerarEnemigo());
        }
        
        //no sirven estos
        if (personaje.nivel == 2){
            StopCoroutine(GenerarEnemigo());
            StartCoroutine(GenerarEnemigo2());
            print("estoy en el 2");
        }
        else if (personaje.nivel == 3){
            StopCoroutine(GenerarEnemigo());
            StopCoroutine(GenerarEnemigo2());
            StartCoroutine(GenerarEnemigo3());
            StartCoroutine(GenerarOtroEnemigo());
        }
        */
        StartCoroutine(GenerarEnemigo());
        

    }

    // Update is called once per frame
    void Update()
    {
    }

    private IEnumerator GenerarEnemigo(){
        while(true){
            Instantiate(enemigo, new Vector3(Random.Range(-5, 5.5f), 
                Random.Range(2,4), 0), 
                enemigo.transform.rotation);
            
            //esperar tiempo random
            yield return new WaitForSeconds(Random.Range(1.0f, 3.0f));

        }
    }

    private IEnumerator GenerarEnemigo2(){
        while(true){
            Instantiate(enemigo, new Vector3(Random.Range(-5, 5.5f), 
                Random.Range(2,4), 0), 
                enemigo.transform.rotation);
            
            //esperar tiempo random
            yield return new WaitForSeconds(Random.Range(0.9f, 2.9f));

        }
    }

    private IEnumerator GenerarEnemigo3(){
        while(true){
            Instantiate(enemigo, new Vector3(Random.Range(-5, 5.5f), 
                Random.Range(2,4), 0), 
                enemigo.transform.rotation);
            
            //esperar tiempo random
            yield return new WaitForSeconds(Random.Range(0.1f, 0.3f));

        }
    }

    private IEnumerator GenerarOtroEnemigo(){
        while(true){
            Instantiate(otroEnemigo, new Vector3(Random.Range(-5, 5.5f), 
                Random.Range(2,4), 0), 
                enemigo.transform.rotation);
            
            //esperar tiempo random
            yield return new WaitForSeconds(Random.Range(1.2f, 3.5f));

        }
    }


    public void empiezaNivel2(){
        //StopCoroutine(GenerarEnemigo());
        //StartCoroutine(GenerarEnemigo2());
        //print("si empiezoooo");
    }

    public void empiezaNivel3(){
        //StopCoroutine(GenerarEnemigo2());
        //StartCoroutine(GenerarEnemigo());
        StartCoroutine(GenerarOtroEnemigo());
        //print ("amonos al 3");
    }


}
