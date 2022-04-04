using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParaEnemigos : MonoBehaviour
{
    [SerializeField]
    private GameObject enemigo;

    [SerializeField]
    private float speed = 16;

    [SerializeField]
    private float randomDirection;

    [SerializeField]
    private Rigidbody2D enemigo2;

    Vector3 direction;


    // Start is called before the first frame update
    void Start()
    {
        //StartCoroutine(GenerarEnemigo());
        StartCoroutine(RandomMove());
    }

    // Update is called once per frame
    void Update()
    {
        
        
    }

    private IEnumerator GenerarEnemigo(){
        while(true){
            Instantiate(enemigo, new Vector3(Random.Range(-3.5f, 3), Random.Range(1.5f, 3.4f), 0), enemigo.transform.rotation);

            //esperar tiempo random
            yield return new WaitForSeconds(Random.Range(0.5f, 4));

        }
    }

    private IEnumerator RandomMove(){

    while(true) {

        float horizontal = Random.Range(-4, 4);  
        float vertical = Random.Range(1.5f, 3.4f); 
        enemigo.transform.Translate(
            horizontal * speed * Time.deltaTime,
            vertical * speed * Time.deltaTime,
            0); 

        yield return new WaitForSeconds(0.5f);
        }
    }

}
