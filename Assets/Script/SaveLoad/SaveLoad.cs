using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

public class SaveLoad : MonoBehaviour
{
    public O2building o2;
    public Hpbuilding shop;

    // public Data dataScript;
    void Start()
    {
        
        string path = Application.persistentDataPath + "/save.powerpoint";
        if(!File.Exists(path))
        {
            
            o2.is_build1 = true;
            shop.is_build1 = true;
        }

    }
    public void SaveData(Data data) 
    {
        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath + "/save.powerpoint";
        FileStream stream = new FileStream(path, FileMode.Create);
        SaveLoadData sl = new SaveLoadData(data);
        formatter.Serialize(stream, sl);
        stream.Close();
        Debug.Log("Game opgeslagen in " + path);
    }

    public static SaveLoadData LoadData() 
    {
        string path = Application.persistentDataPath + "/save.powerpoint";
        if (File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);
            SaveLoadData data = formatter.Deserialize(stream) as SaveLoadData;
            stream.Close();
            Debug.Log("Data opgehaald uit " + path);
            return data;
        }
        else
        {
            Debug.LogError("SaveData niet gevonden in " + path);
            return null;
            
        }
   
    }


    
}
