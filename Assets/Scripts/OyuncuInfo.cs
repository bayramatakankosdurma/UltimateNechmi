using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Bir komponent gibi davranmayacağı için MonoBehavior silinir
[System.Serializable]
public class OyuncuInfo
{
   public int level;
   public float[] position;

   public OyuncuInfo (PlayerMovement oyuncu)
   {
       //oyuncunun leveli çekilir.
       level = oyuncu.level;

       position = new float[3];
       //playermovement scriptinden oyuncunun pozisyonları çekilir.
       position[0] = oyuncu.transform.position.x;
       position[1] = oyuncu.transform.position.y;
       position[2] = oyuncu.transform.position.z;
   }
}
