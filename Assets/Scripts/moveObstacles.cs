using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveObstacles : MonoBehaviour
{
    public Rigidbody rb;
    public float speed = 5f;
    private Manager manager;
    private bool setScore;
    void Start(){
        manager = FindObjectOfType<Manager>();
    }
    //public bool isEnabled;
    // Start is called before the first frame update
    public void OnEnable()
    {
        Debug.Log("On Enable");
        //rb.AddForce(0,0,1000*Time.deltaTime);
        setScore = false;
        rb.velocity  = Vector3.zero;
        //rb = this.GetComponent<Rigidbody>();
        //rb.AddForce(0,0,-1000*Time.deltaTime);
        //rb.velocity = new Vector3(0,0,-speed*100f);
    }
    
    // Update is called once per frame
    void Update()
    {
        
        rb.AddForce(0,0,-700*Time.deltaTime);
        if(setScore==false && transform.position.z<-7.5f){
            manager.incrementScore();
            setScore = true;
            gameObject.SetActive(false);
        }
        /*if(transform.position.z<-10.0f){
            isEnabled = false;
            //Destroy(this.gameObject);
            Debug.Log("Destroyed object");
        }*/
    }
}
