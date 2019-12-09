using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movePlayer : MonoBehaviour
{
    public Rigidbody rb;
    private Manager manager;
    public bool isEnabled;
    // Start is called before the first frame update
    void Start()
    {
        manager = FindObjectOfType<Manager>();
        isEnabled = true;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(manager.isOver()){
            return;
        }
        if(Input.GetKey(KeyCode.A)){
            rb.AddForce(-1000*Time.deltaTime,0,0);
        }
        else if(Input.GetKey(KeyCode.D)){
            rb.AddForce(1000*Time.deltaTime,0,0);
        }
    }
}
