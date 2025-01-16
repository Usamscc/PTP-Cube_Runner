using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Welcome : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        for (int i = 0; i < 10; i++)
        {
            for (int j = 1; j < 10; j++)
            {
                if (i == j)
                {
                  
                    continue;
                }
                print("vlaue of i "+ i +" value of j "+j);
            }
        }
    }
}
