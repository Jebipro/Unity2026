using UnityEngine;

public class Player : MonoBehaviour
{
    Rigidbody rb;
    Animator anim;

    Vector3 moveDirection;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float xInput = Input.GetAxisRaw("Horizontal");
        float zInput = Input.GetAxisRaw("Vertical");

        moveDirection = new Vector3 (xInput, 0, zInput);
    }
}
