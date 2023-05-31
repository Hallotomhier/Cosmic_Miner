using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class SaveLoadData 
{
    //Rm building
    public bool rm_1;
    public bool rm_2;
    public bool rm_3;

    //Arm building 
    public bool arm_1;
    public bool arm_2;
    public bool arm_3;

    //O2 building
    public bool o2_1;
    public bool o2_2;
    public bool o2_3;

    //Oil building 
    public bool oil_1;
    public bool oil_2;
    public bool oil_3;

    //hp building 
    public bool hp_1;
    public bool hp_2;
    public bool hp_3;

    //_playerpos
    public float _pos1;
    public float _pos2;
    public float _pos3;


    public SaveLoadData(Data data) 
    {
        rm_1 = data.rm_1;
        rm_2 = data.rm_2;
        rm_3 = data.rm_3;
        Debug.Log("" + data.rm_1);

        arm_1 = data.arm_1;
        arm_2 = data.arm_2;
        arm_3 = data.arm_3;

        o2_1 = data.o2_1;
        o2_2 = data.o2_2;
        o2_3 = data.o2_3;

        oil_1 = data.oil_1;
        oil_2 = data.oil_2;
        oil_3 = data.oil_3;

        hp_1 = data.hp_1;
        hp_2 = data.hp_2;
        hp_3 = data.hp_3;

        _pos1 = data._playerPos[0];
        _pos2 = data._playerPos[1];
        _pos3 = data._playerPos[2];
        
        
    
    }
}
