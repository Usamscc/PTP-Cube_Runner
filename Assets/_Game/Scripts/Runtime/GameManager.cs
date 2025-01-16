using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
   public static GameManager instance;

   private void Awake()
   {
      instance = this;
   }

   [SerializeField] private GameObject completeLevelUI;
   
   private bool gameHasEnded = false;
   private float restartDelay = 1.5f;
   
   
   public void EndGame()
   {
      if (!gameHasEnded)
      {
         gameHasEnded = true;
         print("Game Over ");
         Invoke("RestartGame",restartDelay);
        // RestartGame();
      }
     
   }

   public void LevelCompleted()
   {
      completeLevelUI.SetActive(true);
      Invoke("CreditScene",restartDelay);
      print("Level Completed");
   }

   private void CreditScene()
   {
      SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
   }
   
   private void RestartGame()
   {
      SceneManager.LoadScene(SceneManager.GetActiveScene().name);
   }
}
