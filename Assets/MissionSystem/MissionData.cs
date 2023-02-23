using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MissionData : ScriptableObject
{
    public string MissionName;

    public virtual void MissionSetup(Transform TargetPlanet, string MissionId, out MissionScript mission)
    {
        mission = null;
        Debug.Log("SettingMission");
    }
}
