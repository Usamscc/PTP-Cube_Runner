
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    [SerializeField] private GameObject player;
    [SerializeField] private Text scoreText;
    

    // Update is called once per frame
    void Update()
    {
        if (!GameManager.instance.gameHasEnded)
        {
            scoreText.text = player.transform.position.z.ToString("0");
        }
       
        
    }
}
