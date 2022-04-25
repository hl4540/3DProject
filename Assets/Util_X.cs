using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Util_X : MonoBehaviour
{
    public float amplitude;
    public float frequency;
    float initX;
    

    // Start is called before the first frame update
    void Start()
    {
        initX = transform.position.x;
    }

    // Update is called once per frame
    void Update()
    {
        float x = Mathf.Cos(Time.time * frequency) * amplitude;
        float y = transform.position.y;
        float z = transform.position.z;

        transform.position = new Vector3(initX + x,y,z);
    }
}
