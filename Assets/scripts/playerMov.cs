using UnityEngine;
using UnityEngine.Scripting.APIUpdating;

public class playerMov : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public Rigidbody rb;
    public float fowardForce= 2000f;
    public float moveSpeed=500f;
    public playerMov movement;
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(0f, 0, fowardForce * Time.deltaTime);

        if(Input.GetKey("d")){
            rb.AddForce(moveSpeed*Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if(Input.GetKey("a")){
            rb.AddForce(-moveSpeed*Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if(rb.position.y<-10f){
            Object.FindAnyObjectByType<managerScript>().endGame();
        }
    }

    void OnCollisionEnter(Collision colInfo){
        if(colInfo.collider.tag=="obs"){
            Debug.Log("obstacle");
            movement.enabled=false;
           Object.FindAnyObjectByType <managerScript>().endGame();
        }
        
    }
    
}
