using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using TMPro;
public class DetectarDinosaurio : MonoBehaviour
{


     public UnityEvent eventoDEntrar;
     public GameObject text_Object;

     public GameObject textoNombre;
     public UnityEvent eventoDSalir;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

     private void OnTriggerEnter(Collider other)
    {
        // Debug.Log("El jugador ha entrado en el trigger");

        if(other.CompareTag("Player")){
            eventoDEntrar.Invoke();
            text_Object = GameObject.Find("/Dread1/Dread2/Bonapartesaurus/Carno1/Carno2/Austro/Talenkauen1/Talenkauen2");
            textoNombre = GameObject.Find("TextoNombre");

            textoNombre = text_Object;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        // Debug.Log("El jugador ha salido del trigger");
        if(other.CompareTag("Player")){
            eventoDSalir.Invoke();
        }
    }
}
