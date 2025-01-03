using UnityEngine;

public class triggerEnt : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public managerScript gameManager;
    void OnTriggerEnter(){
gameManager.levelComplete();
    }
}
