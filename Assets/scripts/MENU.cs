using UnityEngine;
using UnityEngine.SceneManagement;

public class MENU : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
   public void startGame(){
SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
    }
}
