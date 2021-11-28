using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    [SerializeField] float hizX;
    [SerializeField] float hizY;
    [SerializeField] float hizZ;
 
    void Update()
    {
        //parayı döndürmek için unity icinde verdigimiz degeri alip burda carpiyor ve donduruyor.
        transform.Rotate(360 * hizX * Time.deltaTime,360 * hizY * Time.deltaTime,360 * hizZ * Time.deltaTime);
    }
}
