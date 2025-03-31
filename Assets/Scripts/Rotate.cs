using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    // Start is called before the first frame update
    public float spd = 100f;
    

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0f, 0f, spd * Time.deltaTime);
    }
}
