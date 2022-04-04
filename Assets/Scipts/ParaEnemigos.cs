using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParaEnemigos : MonoBehaviour
{
    
    public GameObject enemigo;

    [SerializeField]
    private float speed = 16;


    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(GenerarEnemigo());
        //StartCoroutine(RandomMove());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private IEnumerator GenerarEnemigo(){
        while(true){
            Instantiate(enemigo, new Vector3(Random.Range(-4, 4), 
                Random.Range(2,4), 0), 
                enemigo.transform.rotation);
            
            //esperar tiempo random
            yield return new WaitForSeconds(Random.Range(0.8f, 2.8f));

        }
    }


}
