using UnityEngine;

public class PlayerController : MonoBehaviour
{
    float jumpForce = 400f;
    float walkForce = 30f;
    float maxWalkSpeed = 2f;

    public Sprite[] walkSprites;
    float time = 0;
    int idx = 0;
    SpriteRenderer sr;

    Rigidbody2D rb;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Application.targetFrameRate = 60;
        rb = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            rb.AddForce(transform.up * jumpForce);
        }

        if(rb.linearVelocityX < maxWalkSpeed)
        {
            rb.AddForce(transform.right * walkForce);
        }
    }
}
