using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Invencibilidad : MonoBehaviour
{

    Renderer rend;
    Color c;

    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<Renderer>();
        c = rend.material.color;
    }

    void OnTriggerEnter2D(Collider2D c){
        if (c.gameObject.name == "escudo(Clone)"){
            StartCoroutine(efectoEscudo());
        }
    }
    
    public IEnumerator efectoEscudo() {
        Physics2D.IgnoreLayerCollision(8, 7, true);
        Physics2D.IgnoreLayerCollision(8, 6, true);
        c.a = 0.5f;
        rend.material.color = c;
        yield return new WaitForSeconds(5f);
        Physics2D.IgnoreLayerCollision(8, 7, false);
        Physics2D.IgnoreLayerCollision(8, 6, false);
        c.a = 1f;
        rend.material.color = c;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
