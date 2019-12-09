using UnityEngine;

public class playerCollision : MonoBehaviour
{
    private Manager manager;
    void Start(){
        manager = FindObjectOfType<Manager>();
    }
    void OnCollisionEnter(Collision collision){
        if(collision.collider.tag == "obstacle"){
            manager.GameOver();
        }
    }
}
