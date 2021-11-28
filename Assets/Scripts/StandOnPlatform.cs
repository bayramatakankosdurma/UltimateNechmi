using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StandOnPlatform : MonoBehaviour
{
    //OnCollisionEnter ile platforma degip degmedigimiz kontrol edebiliriz
    private void OnCollisionEnter(Collision collision)
    {
        //Platforma degen nesne Player ise
        if(collision.gameObject.name == "Player")
        {
            //Bu scripti kullanan nesneyi Playerin parenti yap 
            collision.gameObject.transform.SetParent(transform);
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        //Platformdan cikan nesne Player ise
        if (collision.gameObject.name == "Player")
        {
            //Playerin parenti null yap 
            collision.gameObject.transform.SetParent(null);
        }
    }
}
