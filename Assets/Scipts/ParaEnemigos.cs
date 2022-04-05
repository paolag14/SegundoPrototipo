using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParaEnemigos : MonoBehaviour
{
    //private IEnumerator GenerarEnemigo;
    //private IEnumerator GenerarEnemigo2;

    public GameObject enemigo;

    [SerializeField]
    private float speed = 16;

    //public Text levelText;
    [SerializeField]
    private float nivel = 1;


    private Personaje personaje;

    void Awake(){
        personaje = GameObject.FindObjectOfType<Personaje>(); 
    }

    // Start is called before the first frame update
    void Start()
    {   

        if (personaje.nivel == 1){
            StartCoroutine(GenerarEnemigo());
        }
        else if (personaje.nivel == 2){
            StopCoroutine(GenerarEnemigo());
            StartCoroutine(GenerarEnemigo2());
        }
        else if (personaje.nivel == 3){
            StopCoroutine(GenerarEnemigo());
            StopCoroutine(GenerarEnemigo2());
            StartCoroutine(GenerarEnemigo3());
        }
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
            yield return new WaitForSeconds(Random.Range(0.8f, 2.8f));

        }
    }

    private IEnumerator GenerarEnemigo2(){
        while(true){
            Instantiate(enemigo, new Vector3(Random.Range(-5, 5.5f), 
                Random.Range(2,4), 0), 
                enemigo.transform.rotation);
            
            //esperar tiempo random
            yield return new WaitForSeconds(Random.Range(0.4f, 1.2f));

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


}
