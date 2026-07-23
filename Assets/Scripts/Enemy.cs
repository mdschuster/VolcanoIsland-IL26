using System;
using UnityEngine;
using Random = UnityEngine.Random;

public class Enemy : MonoBehaviour
{

    public float minSpeed = 5f;
    public float maxSpeed = 10f;
    public int damage = 1;
    
    private float speed;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        speed=Random.Range(minSpeed,maxSpeed);
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Translate(speed*Time.deltaTime*Vector3.down);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            //have the player take damage
            Player p = other.GetComponent<Player>();
            p.takeDamage(damage);
            //play a sound
            //play a particle system explosion
            Destroy(this.gameObject);
        }

        if (other.CompareTag("Ground"))
        {
            //play a sound and a particle system
            Destroy(this.gameObject);
        }
    }
}
