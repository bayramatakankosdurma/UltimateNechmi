using System.IO;
using UnityEngine;
using System.Runtime.Serialization.Formatters.Binary;

public static class SaveGame
{
    //Kayıtlı oyuna devam etmemizi sağlar
    public static void SavePlayer(PlayerMovement oyuncu)
    {
        //save dosyalarını daha güvenli yapmak için binary halinde saklayacağız.
        BinaryFormatter formatter = new BinaryFormatter();
        //veri yolları mac, windows, linux için farklı olduğu için değişmeyecek bir path oluşturulur.
        string dizin = Application.persistentDataPath+ "/oyuncu.zort";

        FileStream stream = new FileStream(dizin, FileMode.Create);

        //constructor ile oyuncunun verileri çekilir.
        OyuncuInfo info = new OyuncuInfo(oyuncu);

        formatter.Serialize(stream, info);
        stream.Close();
    }

    public static OyuncuInfo LoadPlayer ()
    {
        string dizin = Application.persistentDataPath+ "/oyuncu.zort";
        if(File.Exists(dizin))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(dizin, FileMode.Open);

            OyuncuInfo info = formatter.Deserialize(stream) as OyuncuInfo;
            stream.Close();

            return info;
        } else
        {
            //save dosyası yoksa hata vermesini sağlar ve null döndürür
            Debug.LogError("Şu dizinde kayıt dosyası bulunamadı"+ dizin);
            return null;
        }
    }

}
