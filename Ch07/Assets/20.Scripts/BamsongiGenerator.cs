using UnityEngine;

public class BamsongiGenerator : MonoBehaviour
{
    public GameObject bamsongiPrefab;
    
    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            GameObject bamsongi = Instantiate(bamsongiPrefab);
            bamsongi.transform.position = transform.position;

            Vector3 dir = new Vector3(0, 200, 2000);
            bamsongi.GetComponent<BamsongiController>().Shoot(dir);
        }
    }
}
