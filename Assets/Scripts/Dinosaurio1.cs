using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class Dinosaurio1 : MonoBehaviour
{   public Animator ani;
    public float speed = 2.0f;
    public float vRotation = 5.0f;
    public Vector3 objPosition;
    public Vector3 minRandom;
    public Vector3 maxRandom;
    public float distanceObj;

    void Start(){
        ani = GetComponent<Animator>();
        newObjectRandom();
    }

    void Update() 
    {          
        rotationObject();
        movementObject();   
    }

    void rotationObject()
    {
        // Rotamos hacia el objetivo
        float pasoRotacion = vRotation * Time.deltaTime;
        Vector3 objDirection = objPosition - transform.position;
        Vector3 newDirection = Vector3.RotateTowards(transform.forward, objDirection, pasoRotacion, 0.0f);
        transform.rotation = Quaternion.LookRotation(newDirection);
    }

    void newObjectRandom()
    {
        /*Creacion de un objeto para seguimiento posterior*/
        objPosition.x = Random.Range(minRandom.x, maxRandom.x);
        objPosition.z = Random.Range(minRandom.z, maxRandom.z);
        objPosition.y = transform.position.y;
    }

    void movementObject()
    {
        // Nos movemos hacia el objetivo 
        float movementStep = speed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, objPosition, movementStep);
        distanceObj = Vector3.Distance(objPosition, transform.position);        
        if(distanceObj < 2.0f)
        {
            newObjectRandom();
        }
    }    
     
    void OnDrawGizmosSelected()
    {
        /*Dibujo del objeto tridimensional en el plano*/
       /*Draw a sphere into a map*/ Gizmos.DrawSphere(objPosition, 60f);
       /*Set Sphere color (red)*/ Gizmos.color = new Color(1, 0, 0, 0.75F);
        Gizmos.DrawSphere(minRandom, 25f);
        Gizmos.DrawSphere(maxRandom, 25f);
    }
}
