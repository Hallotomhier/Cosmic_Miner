using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Data : MonoBehaviour
{
    //Player shit
    public Transform _player;
    public float[] _playerPos;

    //Rocket Building
    public bool rocket_1;
    public bool rocket_2;
    public bool rocket_3;

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
    public Drill drill_script;
    public RmBuilding rm_building;
    public ArmBuilding arm_building;
    public O2building o2_building;
    public OilRigBuilding oil_building;
    public Hpbuilding hp_building;
    public hp_O2 hpo2_script;
    public Money money_script;
    public DrillTotal drilltotal_script;
    public SoundManager soundManager_script;
    public RocketBuild rck_building;
    public SaveLoad slData;

    //Money health oxygen
    public float money;
    public float health;
    public float oxygen;

    public float iron;
    public float gold;
    public float diamond;

    //totale drills
    public int iron_drill;
    public int gold_drill;
    public int diamond_drill;
    public int oil_extractor;

    //save voor drills
    public bool[] iron_isActive;
    public bool[] gold_isActive;
    public bool[] diamond_isActive;
    public bool[] oil_isActive;

    public bool is_done;

    //Auto save
    public float timer = 10f;
    
    // void Awake()
    // {
    //     string path = Application.persistentDataPath + "/save.powerpoint";
    //     if (!File.Exists(path))
    //     {
    //         SaveLoad.SaveData();
    //     }
    // }
    
    
    void Update()
    {
        //player pos
        _playerPos[0] = _player.position.x;
        _playerPos[1] = _player.position.y;
        _playerPos[2] = _player.position.z;

        
        if (Input.GetKeyDown(KeyCode.J)) 
        {
            Debug.Log("Pressed J ");
            Save();
        }


        timer -= Time.deltaTime;
        if (timer <= 0) 
        {
            Save();
            timer += 10;
        }



    }

    public void Save()
    {

        
        iron_drill = drilltotal_script.iron_drill;
        gold_drill = drilltotal_script.gold_drill;
        diamond_drill = drilltotal_script.diamond_drill;
        oil_extractor = drilltotal_script.oil_extractor;

        health = hpo2_script.health;
        oxygen = hpo2_script.oxygen;
        money = money_script.cash;

        iron = money_script.iron;
        gold = money_script.gold;
        diamond = money_script.diamond;

        rocket_1 = rck_building.is_build[0];
        rocket_2 = rck_building.is_build[1];
        rocket_3 = rck_building.is_build[2];


        rm_1 = rm_building.is_build1;
        rm_2 = rm_building.is_build2;
        rm_3 = rm_building.is_build3;

        arm_1 = arm_building.is_build1;
        arm_2 = arm_building.is_build2;
        arm_3 = arm_building.is_build3;

        o2_1 = o2_building.is_build1;
        o2_2 = o2_building.is_build2;
        o2_3 = o2_building.is_build3;

        oil_1 = oil_building.is_build1;
        oil_2 = oil_building.is_build2;
        oil_3 = oil_building.is_build3;

        hp_1 = hp_building.is_build1;
        hp_2 = hp_building.is_build2;
        hp_3 = hp_building.is_build3;

        iron_isActive[0] = drill_script.iron_isActive[0];
        iron_isActive[1] = drill_script.iron_isActive[1];
        iron_isActive[2] = drill_script.iron_isActive[2];
        iron_isActive[3] = drill_script.iron_isActive[3];

        gold_isActive[0] = drill_script.gold_isActive[0];
        gold_isActive[1] = drill_script.gold_isActive[1];
        gold_isActive[2] = drill_script.gold_isActive[2];
        gold_isActive[3] = drill_script.gold_isActive[3];

        diamond_isActive[0] = drill_script.diamond_isActive[0];
        diamond_isActive[1] = drill_script.diamond_isActive[1];
        diamond_isActive[2] = drill_script.diamond_isActive[2];

        slData.SaveData(this);
    }

    public void Start()
    {
        SaveLoadData data = SaveLoad.LoadData();
        
        _playerPos[0] = data._pos1;
        _playerPos[1] = data._pos2;
        _playerPos[2] = data._pos3;
        Vector3 pos = new Vector3(_playerPos[0], _playerPos[1], _playerPos[2]);
        _player.position = pos;

        iron_drill = data.iron_drill;
        gold_drill = data.gold_drill;
        diamond_drill = data.diamond_drill;
        oil_extractor = data.oil_extractor;
        
        
        health = data.health;
        money = data.money;
        oxygen = data.oxygen;

        iron = data.iron;
        gold = data.gold;
        diamond = data.diamond;


        rm_1 = data.rm_1;
        rm_2 = data.rm_2;
        rm_3 = data.rm_3;
        

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

        iron_isActive[0] = data.iron_isActive0;
        iron_isActive[1] = data.iron_isActive1;
        iron_isActive[2] = data.iron_isActive2;
        iron_isActive[3] = data.iron_isActive3;

        gold_isActive[0] = data.gold_isActive0;
        gold_isActive[1] = data.gold_isActive1;
        gold_isActive[2] = data.gold_isActive2;
        gold_isActive[3] = data.gold_isActive3;

        diamond_isActive[0] = data.diamond_isActive0;
        diamond_isActive[1] = data.diamond_isActive1;
        diamond_isActive[2] = data.diamond_isActive2;
        

        drilltotal_script.iron_drill = iron_drill;
        drilltotal_script.gold_drill = gold_drill;
        drilltotal_script.diamond_drill = diamond_drill;
        drilltotal_script.oil_extractor = oil_extractor;

        hpo2_script.health = health;
        hpo2_script.oxygen = oxygen;
        money_script.cash = money;

        money_script.iron = iron;
        money_script.gold = gold;
        money_script.diamond = diamond;

        rck_building.is_build[0] = rocket_1;
        rck_building.is_build[1] = rocket_2;
        rck_building.is_build[2] = rocket_3;

        rm_building.is_build1 = rm_1;
        rm_building.is_build2 = rm_2;
        rm_building.is_build3 = rm_3;

        arm_building.is_build1 = arm_1;
        arm_building.is_build2 = arm_2;
        arm_building.is_build3 = arm_3;

        o2_building.is_build1 = o2_1;
        o2_building.is_build2 = o2_2;
        o2_building.is_build3 = o2_3;

        oil_building.is_build1 = oil_1;
        oil_building.is_build2 = oil_2;
        oil_building.is_build3 = oil_3;

        hp_building.is_build1 = hp_1;
        hp_building.is_build2 = hp_2;
        hp_building.is_build3 = hp_3;

        drill_script.iron_isActive[0] = iron_isActive[0];
        drill_script.iron_isActive[1] = iron_isActive[1];
        drill_script.iron_isActive[2] = iron_isActive[2];
        drill_script.iron_isActive[3] = iron_isActive[3];

        drill_script.gold_isActive[0] = gold_isActive[0];
        drill_script.gold_isActive[1] = gold_isActive[1];
        drill_script.gold_isActive[2] = gold_isActive[2];
        drill_script.gold_isActive[3] = gold_isActive[3];

        drill_script.diamond_isActive[0] = diamond_isActive[0];
        drill_script.diamond_isActive[1] = diamond_isActive[1];
        drill_script.diamond_isActive[2] = diamond_isActive[2];
    }

}

