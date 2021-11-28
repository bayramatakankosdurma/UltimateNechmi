using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementOfOtherObjects : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    [SerializeField] GameObject[] sinirlar;
    int currentIndex = 0;
    [SerializeField] float hiz = 1f;
    // Update is called once per frame
    void Update()   
    {
        //Sinir degerlere ne kadar yaklastigimizi kontrol ederiz
        //Hedefe gelindiyse diger sinir degerine geceriz
        if(Vector3.Distance(transform.position, sinirlar[currentIndex].transform.position)< .1f)
        {
            currentIndex++;

            if(currentIndex >= sinirlar.Length)
            {
                currentIndex = 0;
            }
        }
        //MoveTowards fonksiyonuna nesnenin o anki yerini,
        //varmasini istedigimiz yeri ve varis hizini gonderebiliriz.
        transform.position = Vector3.MoveTowards(transform.position, sinirlar[currentIndex].transform.position, hiz * Time.deltaTime);
    }
}