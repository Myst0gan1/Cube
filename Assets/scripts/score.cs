using TMPro;
using UnityEngine;
using UnityEngine.UI;
public class score : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public Transform playerPos;
    public TextMeshProUGUI scoreCount;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        scoreCount.text=playerPos.position.z.ToString("0");
    }
}
