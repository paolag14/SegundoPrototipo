using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class SoundManager : MonoBehaviour
{
    [SerializeField]
    public AudioClip[] clips;
    public AudioClip[] clipsSecond;
    public AudioSource player;
    //private int pistalActual;
    // Start is called before the first frame update
    void Start()
    {

        player = GetComponent<AudioSource>();

    }

    // Update is called once per frame
    
    void Update()
    {
        /*
        if (Input.GetKeyDown(KeyCode.A)){
            pistalActual++;
            pistalActual %= clips.Length;
            player.clip = clips[pistalActual];
        }

        if (Input.GetKeyDown(KeyCode.S)){
            player.Play();
        }

        if (Input.GetKeyDown(KeyCode.D)){
           player.Pause();
        }

        if (Input.GetKeyDown(KeyCode.F)){
           player.Stop();
        }*/

        //sonidoBalaJugador();
    }
    
    public void sonidoBalaJugador(){
        player.PlayOneShot(clips[0]);
    }

    public void sonidoMenosVida(){
        player.PlayOneShot(clips[1]);
    }

    public void sonidoNivel(){
        player.PlayOneShot(clips[2]);
    }

    public void sonidoChoque(){
        player.PlayOneShot(clips[3], 3F);
    }

    public void sonidoExplosion(){
        player.PlayOneShot(clips[4]);
    }

    public void sonidoBalaEnemigo(){
        player.PlayOneShot(clips[5]);
    }

    public void sonidoGameOver(){
        player.PlayOneShot(clips[6]);
    }

    public void sonidoGanaVida(){
        player.PlayOneShot(clips[7]);
    }

    public void sonidoOtraBala(){
        player.PlayOneShot(clips[8]);
    }

    

}
