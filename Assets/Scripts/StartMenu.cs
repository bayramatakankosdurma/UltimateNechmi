using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenu : MonoBehaviour
{
    public void StartGame()
    {
        //oyuna giris yapmak icin butona tiklandiginde bu fonksiyon cagirilir ve index 1 arttirilip oyuna girilir.
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1);
    }
}
