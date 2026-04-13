using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 0.1f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Application.targetFrameRate = 60;
    }

    // PC용 코드
    //void Update()
    //{
    //    if (Input.GetKey(KeyCode.LeftArrow))
    //    {
    //        transform.Translate(-speed, 0, 0);
    //    }
    //    if (Input.GetKey(KeyCode.RightArrow))
    //    {
    //        transform.Translate(speed, 0, 0);
    //    }
    //}

    // 모바일용 코드
    public void LButtonDown()
    {
        transform.Translate(-speed, 0, 0);
    }
    
    public void RButtonDown()
    {
        transform.Translate(speed, 0, 0);
    }
}
