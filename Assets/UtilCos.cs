using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UtilCos : MonoBehaviour
{
    public float amplitude;
    public float frequency;
    private float initY;
    

    // Start is called before the first frame update
    void Start()
    {
        initY = transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        //float x = Mathf.Cos(Time.time * frequency) * amplitude;
        float x = transform.position.x;
        float y = Mathf.Cos(Time.time * frequency) * amplitude;
        float z = transform.position.z;

        transform.position = new Vector3(x, initY + y,z);
    }
}
