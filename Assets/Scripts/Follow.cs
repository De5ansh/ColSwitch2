using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform player;
    public Vector3 pos;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (player.position.y > transform.position.y)
        {
            transform.position = new Vector3(transform.position.x, player.position.y, transform.position.z);
        }
    }
    public void CamPosBack()
    {
        transform.position = pos;
    }
    public void CamPosFinish()
    {
        transform.position = new Vector3(transform.position.x, 80f, transform.position.z);
    }
}
