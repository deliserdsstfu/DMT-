using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameramove : MonoBehaviour
{
    public GameObject camera;
    private float speed= 0.1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        camera.transform.position = new Vector3(camera.transform.position.x + speed, camera.transform.position.y, camera.transform.position.z);
    }
}
