using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class Personaje : MonoBehaviour
{
    [SerializeField]
    private float velocidad = 15;

    [SerializeField]
    private GameObject bala; 
    //public Transform referenciaDePosicion; 

    [SerializeField]
    private GameObject choque;

    public Text scoreText;

    public Text lifeText;

    private int currentScore; 
    private int currentLife = 3; 

    //corrutina
    private IEnumerator disparoCorrutina;

    [SerializeField]
    private float tiempoDisparo = 1;
    
    
    // Start is called before the first frame update
    void Start(){
        scoreText.fontSize = 18;
        scoreText.fontStyle = FontStyle.Italic;
        scoreText.text = "Kills: ";  
        lifeText.fontSize = 18;
        lifeText.fontStyle = FontStyle.Italic;
        lifeText.text = "Life: " + currentLife.ToString();

        if(bala == null){
            Debug.LogError("PROYECTIL NO ASIGNADO");
            throw new System.Exception("PROYECTIL NO ASIGNADO");
        }

        disparoCorrutina = Disparo();
    } 

    // Update is called once per frame
    void Update(){
       
       // Movilidad en 4 direcciones utilizando ejes
        float horizontal = Input.GetAxis("Horizontal");  
        float vertical = Input.GetAxis("Vertical"); 
        transform.Translate(
            horizontal * velocidad * Time.deltaTime,
            vertical * velocidad * Time.deltaTime,
            0); 

        // Disparar balas
        /*
        if(Input.GetKeyDown(KeyCode.Space)){
            Instantiate(
                bala,
                referenciaDePosicion.position,
                referenciaDePosicion.rotation
            ); 
        }
        */

        if(Input.GetKeyDown(KeyCode.Space)){
            StartCoroutine(disparoCorrutina);
        }

        if(Input.GetKeyUp(KeyCode.Space)){
            StopCoroutine(disparoCorrutina);
        }

    }

    public void UpdateScore(int score){
        currentScore += score; 
        scoreText.text = "Kills: " + currentScore.ToString(); 
    }

    public void UpdateLife(int vida){
        currentLife -= vida;
        lifeText.text = "Life: " + currentLife.ToString();
        if (currentLife <= 0){
            Destroy(gameObject);
            lifeText.text = "GAME OVER";
            
        }
    }
 
    private IEnumerator Disparo(){
        while(true){
            Instantiate(bala, transform.position, transform.rotation);
            yield return new WaitForSeconds(tiempoDisparo);
        }
    }



    public void OnTriggerEnter2D(Collider2D c){
        if (c.gameObject.name == "Enemigo(Clone)") {
            Instantiate(choque, transform.position, transform.rotation);
            UpdateLife(1);
        }
        else{
            //print(c.gameObject.name);
        }

    } 
}
