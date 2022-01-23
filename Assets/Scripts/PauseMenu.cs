using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Scene yüklemek için
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    //Oyunun durdurulup durdurulmadığını kontrol etmek için
    public static bool OyunDurduruldu = false;

    //UI kontrolü için
    public GameObject molaMenuUI;

    //Oyunu devam ettirir
    public void Devam()
    {
        molaMenuUI.SetActive(false);
        Time.timeScale = 1f;
        OyunDurduruldu = false;
    }
    //Oyunu durdurur
    public void Durdur()
    {
        molaMenuUI.SetActive(true);
        Time.timeScale = 0f;
        OyunDurduruldu = true;
    }

    //Ana menüye dönüşü sağlar
    public void MainMenu()
    {

        SceneManager.LoadScene("Start Screen");
        PlayerMovement info = new PlayerMovement();
        info.SavePlayer();
    }

    // Update is called once per frame
    void Update()
    {
        //Esc tuşuna basılınca oyun durdurulmalı
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            //Esc tuşuna tekrar basarak oyunu devam ettirebiliriz
            if(OyunDurduruldu)
            {
                Devam();
            }
            else
            {
                Durdur();
            }
        }
    }

}
