using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PlanetData
{
    public Transform PlanetTransform;
    public MissionData mission;
    public MissionScript missionScript;
    
}
public class GameManager : MonoBehaviour
{
    public List<MissionData> missionsPool;

    public List<PlanetData> planets;
    private void Start()
    {
        if (missionsPool.Count > 0)
        {
            int MissionCounter = 0;
            foreach (var item in planets)
            {
                string MissionId = "M_" + MissionCounter++;
                item.mission = missionsPool[Random.Range(0, missionsPool.Count)];
                item.mission.MissionSetup(item.PlanetTransform, MissionId, out item.missionScript);
            }
        }
        if (GameEventManager.instance) GameEventManager.instance.MissionClear.AddListener(MissionClear);
    }

    void MissionClear(string missionId)
    {
        bool AllClear = true;
        foreach (var item in planets)
        {
            if (!item.missionScript.IsComplete)
            {
                AllClear = false;
                break;
            }
        }
        if (AllClear) Debug.Log("Mission All Clear");
    }

}
