using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class RadarMissionScript : MissionScript
{
    public RadarMissionScript(string triggerId, string completeId): base(triggerId, completeId)
    {
    }
    private int TargetCount;
    public override void MissionStartup(MissionData missionData)
    {
        TargetCount = ((RadarMission)missionData).TargetSpawnNumber;
        if (GameEventManager.instance != null) GameEventManager.instance.MissionTrigger.AddListener(MissionTriggered);
    }

    public override void MissionTriggered(string objId)
    {
        if (objId.Equals(this.TriggerId))
        {
            TargetCount--;
            if (TargetCount <= 0)
            {
                Debug.Log("Mission Complete");
                this.IsComplete = true;
                if (GameEventManager.instance != null)
                {
                    GameEventManager.instance.MissionTrigger.RemoveListener(MissionTriggered);
                    GameEventManager.instance.MissionClear.Invoke(this.CompleteId);
                }
            }
        }
    }
}
