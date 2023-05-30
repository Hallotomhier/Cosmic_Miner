using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Data : MonoBehaviour
{
    //Player shit
    public Transform _player;
    public float[] _playerPos;

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

    //scripts
    public RmBuilding rm_building;
    public ArmBuilding arm_building;
    public O2building o2_building;
    public OilRigBuilding oil_building;
    public Hpbuilding hp_building;





    
    
    
    
    void Update()
    {
        //player pos
        _playerPos[0] = _player.position.x;
        _playerPos[1] = _player.position.y;
        _playerPos[2] = _player.position.z;

        //rm building
        rm_1 = rm_building.is_build1;
        rm_2 = rm_building.is_build2;
        rm_3 = rm_building.is_build3;

        rm_building.is_build1 = rm_1;
        rm_building.is_build2 = rm_2;
        rm_building.is_build3 = rm_3;

        //arm building
        arm_1 = arm_building.is_build1;
        arm_2 = arm_building.is_build2;
        arm_3 = arm_building.is_build3;

        arm_building.is_build1 = arm_1;
        arm_building.is_build2 = arm_2;
        arm_building.is_build3 = arm_3;

        //O2 building 
        o2_1 = o2_building.is_build1;
        o2_2 = o2_building.is_build2;
        o2_3 = o2_building.is_build3;

        o2_building.is_build1 = o2_1;
        o2_building.is_build2 = o2_2;
        o2_building.is_build3 = o2_3;

        //Oil building
        oil_1 = oil_building.is_build1;
        oil_2 = oil_building.is_build2;
        oil_3 = oil_building.is_build3;

        oil_building.is_build1 = oil_1;
        oil_building.is_build2 = oil_2;
        oil_building.is_build3 = oil_3;


        //hp building 
        hp_1 = hp_building.is_build1;
        hp_2 = hp_building.is_build2;
        hp_3 = hp_building.is_build3;

        hp_building.is_build1 = hp_1;
        hp_building.is_build2 = hp_2;
        hp_building.is_build3 = hp_3;




    }
}
