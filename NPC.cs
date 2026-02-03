using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    //vida
    public int health = 20;

    //nivel
    public int level = 2;

    public float speed = 1.5f;

    // Start is called before the first frame update
    void Start()
    {
        //nivel+vida
        health = health + level;
        print("Lives:" + health);
    }

    // Update is called once per frame
    void Update()
    {
        //posicion NPC
        Vector3 newPosition = transform.position;
        //cambiar posicion NPC
        newPosition.z += speed * Time.deltaTime;
        //actualiza posicion 
        transform.position = newPosition;
    }
}
