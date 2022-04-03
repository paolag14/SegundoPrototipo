using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class Personaje : MonoBehaviour
{

    public float velocidad = 15;
    public GameObject original; 
    public Transform referenciaDePosicion; 
    public Text scoreText;
    private int currentScore; 
    
    
    // Start is called before the first frame update
    void Start(){
        scoreText.fontSize = 18;
        scoreText.fontStyle = FontStyle.Italic;
        scoreText.text = "Kills: ";  
    } 

    // Update is called once per frame
    void Update(){
       
       // Movilidad en 4 direcciones utilizando ejes
        float horizontal = Input.GetAxis("Horizontal");  
        float vertical = Input.GetAxis("Vertical"); 
        transform.Translate(
            velocidad * horizontal * Time.deltaTime,
            velocidad * vertical * Time.deltaTime,
            0, 
            Space.World); 

        // Disparar balas 
        if(Input.GetKeyDown(KeyCode.Space)){
            Instantiate(
                original,
                referenciaDePosicion.position,
                referenciaDePosicion.rotation
            ); 
        }
    }

    public void UpdateScore(int score){
        currentScore += score; 
        scoreText.text = "Kills: " + currentScore.ToString(); 
    }

}
