using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewCombatMission", menuName = "Mission/CombatMission")]
public class CombatMission : MissionData
{
    public GameObject EnemyObj;
    public int SpawnNumber;
    public override void MissionSetup(Transform TargetPlanet, string MissionId, out MissionScript mission)
    {
        for (int cnt = 0; cnt < SpawnNumber; cnt++)
        {
            float Range = TargetPlanet.localScale.x / 2 + 3;
            float angle = 2 * Mathf.PI * Random.Range(0f, 1f);
            float x = Range * Mathf.Cos(angle);
            float y = Range * Mathf.Sin(angle);
            Vector3 Pos = new Vector3(x, y, 0) + TargetPlanet.position;
            GameObject obj = Instantiate(EnemyObj, Pos, Quaternion.identity);
            if (obj.GetComponent<EnemyScript>()) obj.GetComponent<EnemyScript>().MissionId = MissionId;
        }
        mission = new CombatMissionScript(MissionId, MissionId + "Complete");
        mission.MissionStartup(this);
    }
}
