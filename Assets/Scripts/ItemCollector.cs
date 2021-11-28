using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemCollector : MonoBehaviour
{
    //sadece coin degil herhangi bir toplanabilir ogeyi toplamak icin ayri script actik.
    //ekleyecegimiz seyin ismini buraya ekleyerek ontrigger ile tekrardan kontrol edebiliriz.
    int toplananPara = 0;

    [SerializeField] AudioSource paraSesi;

    [SerializeField] Text paraText;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Coin"))
        {
            Destroy(other.gameObject);
            toplananPara++;
            paraText.text = "Toplanan Para: " + toplananPara;
            paraSesi.Play();
        }
    }

}
