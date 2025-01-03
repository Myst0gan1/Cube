using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class managerScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    bool gameEnd=false;
    public float restartDelay=1f;
    public GameObject lvlUI;
    public void levelComplete(){
        lvlUI.SetActive(true);
    }
    public void endGame(){
        if(gameEnd==false){
            gameEnd=true;
            Debug.Log("dead");
            Invoke("restart", restartDelay);
        }
        
    }
    void restart(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
