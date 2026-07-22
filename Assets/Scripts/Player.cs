using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(Rigidbody2D))]
public class Player : MonoBehaviour
{
    public float speed = 5f;
    public int maxHealth = 3;

    private int health;
    private Rigidbody2D rb;
    private Vector2 moveDir;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        health=maxHealth;
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        Vector2 movement=new Vector2(moveDir.x*speed,0f);
        rb.linearVelocity = movement;
    }

    void OnMove(InputValue value)
    {
        moveDir = value.Get<Vector2>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
