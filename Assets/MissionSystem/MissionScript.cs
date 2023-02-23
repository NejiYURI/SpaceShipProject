using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public abstract class MissionScript
{
    public MissionScript(string triggerId, string completeId)
    {
        this.TriggerId = triggerId;
        this.CompleteId = completeId;
    }
    public string TriggerId;
    public string CompleteId;
    public bool IsComplete;

    public virtual void MissionStartup(MissionData missionData)
    {

    }

    public virtual void MissionTriggered(string objId)
    {

    }
}
