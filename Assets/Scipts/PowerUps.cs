using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUps : MonoBehaviour
{
    [SerializeField]
    private GameObject escudo;

    [SerializeField]
    public GameObject vidaP;

    // Start is called before the first frame update
    void Start()
    {
        //Destroy(vidaP, 6);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void generaEscudo(){
        StartCoroutine(generaEscudos());
    }

    public void generaVida(){
        //Instantiate(vidaP, new Vector3(Random.Range(-7.3f, 7.2f), 
          //      Random.Range(-4.2f, 4.2f), 0), 
            //    transform.rotation);
        StartCoroutine(generaCorazones());
    }

    private IEnumerator generaCorazones(){
        while(true){
            var corazonClon = Instantiate(vidaP, new Vector3(Random.Range(-6.8f, 6.8f), 
                Random.Range(-3.6f, 3.3f), 0), 
                transform.rotation);
            Destroy(corazonClon, 5);
            yield return new WaitForSeconds(Random.Range(4, 11.5f));
        }
    }

    private IEnumerator generaEscudos(){
        while(true){
            var escudoClon = Instantiate(escudo, new Vector3(Random.Range(-6.8f, 6.8f), 
                Random.Range(-3.6f, 3.3f), 0), 
                transform.rotation);
            Destroy(escudoClon, 5);
            yield return new WaitForSeconds(Random.Range(7f, 12f));
        }
    }
}
