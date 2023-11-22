using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class EnemyAi : MonoBehaviour
{
    public int rutina;

    public float cronometro;

    public Animator ani;

    public Quaternion angulo;

    public float grado;


    void Start(){
        ani = GetComponent<Animator>();
    }
    
}
