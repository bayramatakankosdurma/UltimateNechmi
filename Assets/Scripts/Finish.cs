using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Finish : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        //yeni levele gecmek icin platforma dokunup dokunmadigini kontrol ediyor.
        if (other.gameObject.name =="Player")
        {
            //index 3 oldugunda oyun sona eriyor.
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1); 
        }
    }

}
