using UnityEngine;

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
}
