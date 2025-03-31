using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColChanger : MonoBehaviour
{
    // Start is called before the first frame update
    public SpriteRenderer sr;
    public string currColor;

    public Color pink;
    public Color cyan;
    public Color magenta;
    public Color yellow;
    void Start()
    {
        SetRandomColor();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SetRandomColor()
    {
        int index = Random.Range(0, 4);
        switch (index)
        {
            case 0:
                currColor = "Cyan";
                sr.color = cyan;
                break;
            case 1:
                currColor = "Magenta";
                sr.color = magenta;
                break;
            case 2:
                currColor = "Pink";
                sr.color = pink;
                break;
            case 3:
                currColor = "Yellow";
                sr.color = yellow;
                break;
        }
    }
}
