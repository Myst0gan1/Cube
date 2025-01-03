using UnityEngine;
using UnityEngine.SceneManagement;

public class lvlcomplete : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
   public void loadNextLevel(){
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
   }
}
