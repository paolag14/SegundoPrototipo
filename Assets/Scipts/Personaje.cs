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

    public Text levelText;
    
    [SerializeField]
    public float nivel = 1;

    SoundManager sonidos;

    PowerUps powers;

    
    
    // Start is called before the first frame update
    void Start(){
        scoreText.fontSize = 18;
        scoreText.fontStyle = FontStyle.Bold;
        scoreText.color = Color.white;
        scoreText.text = "Kills: ";  

        lifeText.fontSize = 18;
        lifeText.fontStyle = FontStyle.Bold;
        lifeText.color = Color.white;
        lifeText.text = "Life: " + currentLife.ToString();

        levelText.fontSize = 18;
        levelText.fontStyle = FontStyle.Bold;
        levelText.color = Color.white;
        levelText.text = "Level: " + nivel.ToString();  

        if(bala == null){
            Debug.LogError("PROYECTIL NO ASIGNADO");
            throw new System.Exception("PROYECTIL NO ASIGNADO");
        }

        
        sonidos = GameObject.FindObjectOfType<SoundManager>(); 

        powers = GameObject.FindObjectOfType<PowerUps>(); 

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

        lifeText.text = "Life: " + currentLife.ToString();

        if(Input.GetKeyDown(KeyCode.Space)){
            StartCoroutine(disparoCorrutina);
            sonidos.sonidoBalaJugador();
            
        }

        if(Input.GetKeyUp(KeyCode.Space)){
            StopCoroutine(disparoCorrutina);
        }

    }

    public void UpdateScore(int score){
        currentScore += score; 
        scoreText.text = "Kills: " + currentScore.ToString(); 
        //nivel 2
        if (currentScore == 5){
            UpdateLevel(1);
            powers.generaVida();
            
        }
        //nivel 3
        if (currentScore == 15){
            UpdateLevel(1);
            //powers.generaVida();
        }
    }

    public void UpdateLife(int vida){
        currentLife -= vida;
        lifeText.text = "Life: " + currentLife.ToString();

        sonidos.sonidoMenosVida();

        if (currentLife <= 0){
            //sonidos.sonidoExplosion();
            Destroy(gameObject);
            lifeText.text = "GAME OVER";
            levelText.text = "GAME OVER";
            scoreText.text = "GAME OVER";
            sonidos.sonidoGameOver();
            
        }
    }

    public void UpdateLevel(int level){
        nivel += level;
        levelText.text = "Level: " + nivel.ToString();
        sonidos.sonidoNivel(); 
    }
 
    private IEnumerator Disparo(){
        while(true){
            Instantiate(bala, transform.position, transform.rotation);
            
            yield return new WaitForSeconds(tiempoDisparo);
        }
    }

    public void OnTriggerEnter2D(Collider2D c){
        
        if (c.gameObject.name == "Enemigo(Clone)" || c.gameObject.name == "BalaEnemigos(Clone)" 
        || c.gameObject.name == "otraBalaEnemigos(Clone)" || c.gameObject.name == "OtroEnemigo(Clone)") {
            Instantiate(choque, transform.position, transform.rotation);
            UpdateLife(1);
        }

        else if (c.gameObject.name == "vida(Clone)"){
            currentLife += 1;
            sonidos.sonidoGanaVida();
            //print("toca: " + c.gameObject.name);
            Destroy(c.gameObject);
            
        }

    } 

    
}
