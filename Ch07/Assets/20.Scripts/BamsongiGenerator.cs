using UnityEngine;

public class BamsongiGenerator : MonoBehaviour
{
    public GameObject bamsongiPrefab;
    public float throwForce = 10f;

    float startY;
    
    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            startY = Input.mousePosition.y;
        }

        else if(Input.GetMouseButtonUp(0))
        {
            GameObject bamsongi = Instantiate(bamsongiPrefab);
            bamsongi.transform.position = transform.position;

            float power = Input.mousePosition.y - startY;

            Vector3 dir = transform.forward + transform.up; 
            bamsongi.GetComponent<BamsongiController>().Shoot(dir * power * throwForce);

            //Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            //bamsongi.GetComponent<BamsongiController>().Shoot(ray.direction * 2000);
        }
    }
}
