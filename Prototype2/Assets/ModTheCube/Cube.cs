using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public MeshRenderer Renderer;
    
    void Start()
    {
        transform.position = new Vector3(0, 0, 0);
        transform.localScale = Vector3.one * 2f;
        
       
        InvokeRepeating("MynewColor", 2f, 3f);
       
    }
    
    void Update()
    {
       
        transform.Rotate(20f * Time.deltaTime, 0.0f, 0.0f);
        
        if(Input.GetKey(KeyCode.RightArrow)) 
        { 
            transform.Rotate(500f*Time.deltaTime, 0.0f, 0.0f);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(-500f * Time.deltaTime, 0.0f, 0.0f);
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Rotate(0.0f, 0.0f, 500f * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Rotate(0.0f, 0.0f, -500f * Time.deltaTime);
        }
    }
    void MynewColor()
    {
        Material material = Renderer.material;
        material.color = new Color(Random.Range(0.1f, 1f), Random.Range(0.1f, 1f), Random.Range(0.1f, 1f), 0.4f);
    }
}
