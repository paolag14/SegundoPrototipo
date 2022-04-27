using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class SoundManager : MonoBehaviour
{
    [SerializeField]
    public AudioClip[] clips;
    public AudioSource player;
    private int pistalActual;
    // Start is called before the first frame update
    void Start()
    {
        sonidoBalaJugador();

        player = GetComponent<AudioSource>();
        //pistalActual = 0;

        //player.clip = clips[0];

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
}
