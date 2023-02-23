using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class CombatMissionScript: MissionScript
{
    public CombatMissionScript(string triggerId, string completeId): base(triggerId, completeId)
    {
    }
    private int EnemyCount;
    public override void MissionStartup(MissionData missionData)
    {
        EnemyCount = ((CombatMission)missionData).SpawnNumber;
        if (GameEventManager.instance != null) GameEventManager.instance.MissionTrigger.AddListener(MissionTriggered);
    }

    public override void MissionTriggered(string objId)
    {
        if (objId.Equals(this.TriggerId))
        {
            EnemyCount--;
            if (EnemyCount <= 0)
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
