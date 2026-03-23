using UnityEngine;

public class RouletteController : MonoBehaviour
{
    public float startSpeed = 10f;
    public float decreaseRatio = 0.97f;

    float rotSpeed = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Application.targetFrameRate = 60;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            this.rotSpeed = startSpeed;
        }

        transform.Rotate(0, 0, this.rotSpeed);

        this.rotSpeed *= decreaseRatio;
    }
}
