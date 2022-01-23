using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroy : MonoBehaviour
{

    private void Awake()
    {
        //bgmusic scriptine unity içinde GameMusic tag i verdik.
        //bu tage atanmış müzik objesini bir değişkene atadık.
        //unity'de bize sağlanan metodlardan birisi olan DontDestroyOnLoad ile sahneler arası geçiş sağlandı.
        GameObject[] musicObj = GameObject.FindGameObjectsWithTag("GameMusic");
        if(musicObj.Length>1)
        {
            Destroy(this.gameObject);
        }
        DontDestroyOnLoad(this.gameObject);
    }

}
