using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.PlayerSettings;

[CreateAssetMenu(fileName = "NewRadarMission", menuName = "Mission/RadarMission")]
public class RadarMission : MissionData
{
    public GameObject CenterObject;
    public GameObject TargetObj;
    public GameObject Radar;
    public int TargetSpawnNumber = 2;
    public int RecieverSpawnNumber = 3;
    public override void MissionSetup(Transform TargetPlanet, string MissionId, out MissionScript mission)
    {
        GameObject CenterObj = Instantiate(CenterObject, TargetPlanet.position, Quaternion.identity);
        for (int cnt = 0; cnt < TargetSpawnNumber; cnt++)
        {
            GameObject obj = SpawnObj(TargetPlanet, TargetPlanet.localScale.x / 2 + TargetPlanet.localScale.x/1.5f, cnt * 360f / TargetSpawnNumber, TargetObj);
            obj.transform.SetParent(CenterObj.transform);
            if (obj.GetComponent<RadarTargetScript>()) obj.GetComponent<RadarTargetScript>().MissionId = MissionId;
        }

        for (int cnt = 0; cnt < RecieverSpawnNumber; cnt++)
        {
            GameObject obj = SpawnObj(TargetPlanet, TargetPlanet.localScale.x / 2, cnt * 360f / RecieverSpawnNumber, Radar);
            if (obj.GetComponent<RadarTargetScript>()) obj.GetComponent<RadarTargetScript>().MissionId = MissionId;
        }
        mission = new RadarMissionScript(MissionId, MissionId + "Complete");
        mission.MissionStartup(this);
    }

    GameObject SpawnObj(Transform TargetPlanet, float Range, float Ratio, GameObject Spawnobj)
    {
        float angle = Mathf.PI * Ratio / 180f;
        float x = Range * Mathf.Cos(angle);
        float y = Range * Mathf.Sin(angle);
        Vector3 Pos = new Vector3(x, y, 0) + TargetPlanet.position;
        return Instantiate(Spawnobj, Pos, Quaternion.Euler(0, 0, GetAngle((Vector2)Pos, (Vector2)TargetPlanet.position)));
    }

    float GetAngle(Vector2 from, Vector2 to)
    {
        Vector2 _dir = from - to;
        int sign = (_dir.x >= 0) ? -1 : 1;
        int offset = (sign >= 0) ? 0 : 360;
        return Vector2.Angle(_dir.normalized, Vector2.up) * sign + offset;
    }
}
