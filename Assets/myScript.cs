using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class myScript : MonoBehaviour
{
    public Rigidbody rb;
    public int health = 100;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        Debug.Log("what you want to say");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
