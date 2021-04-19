
using UnityEngine;
using UnityEditor;

public class Cube : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GenerateColor();
    }

    public void GenerateColor()
    {
        GetComponent<Renderer>().sharedMaterial.color = Random.ColorHSV();
    }

    public void reset ()
    {
        GetComponent<Renderer>().sharedMaterial.color = Color.white;
    }
} 

