using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

[System.Serializable]
public class PlanetData
{
    public string PlanetName;
    public Transform PlanetTransform;
    public Color TagColor;
    public MissionData mission;
    public MissionScript missionScript;
}
public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public List<MissionData> missionsPool;

    public List<string> NameList;
    public List<PlanetData> planets;

    public Transform TaskList;
    public GameObject TaskLabel;

    public GameObject GameOverUI;

    private Dictionary<string, TextMeshProUGUI> TaskDatas;

    private void Awake()
    {
        instance = this;
    }
    private void Start()
    {
        List<string> EnableNameList = new List<string>();
        TaskDatas = new Dictionary<string, TextMeshProUGUI>();
        EnableNameList.AddRange(NameList);
        List<MissionData> EnableMission = new List<MissionData>(); ;
        EnableMission.AddRange(missionsPool);
        if (missionsPool.Count > 0)
        {
            int MissionCounter = 0;
            foreach (var item in planets)
            {
                string MissionId = "M_" + MissionCounter++;
                int missionInt = Random.Range(0, EnableMission.Count);
                item.mission = EnableMission[missionInt];
                EnableMission.RemoveAt(missionInt);
                item.mission.MissionSetup(item.PlanetTransform, MissionId, out item.missionScript);
                int nameIndex = Random.Range(0, EnableNameList.Count);
                string MissionDesc = item.mission.MissionDescription.Replace("-c", "#" + ColorUtility.ToHtmlStringRGB(item.TagColor));
                item.PlanetName = EnableNameList[nameIndex];
                MissionDesc = MissionDesc.Replace("#name", EnableNameList[nameIndex]);
                EnableNameList.RemoveAt(nameIndex);
                GameObject obj = Instantiate(TaskLabel, TaskList);
                obj.GetComponent<TextMeshProUGUI>().text = MissionDesc;
                TaskDatas.Add(MissionId + "Complete", obj.GetComponent<TextMeshProUGUI>());
            }
        }
        if (GameEventManager.instance) GameEventManager.instance.MissionClear.AddListener(MissionClear);
    }

    void MissionClear(string missionId)
    {
        bool AllClear = true;
        if (TaskDatas.ContainsKey(missionId))
        {
            TaskDatas[missionId].color = new Color(TaskDatas[missionId].color.r, TaskDatas[missionId].color.g, TaskDatas[missionId].color.b, 0.3f);
            TaskDatas[missionId].fontStyle = FontStyles.Strikethrough;
        }
        foreach (var item in planets)
        {
            if (!item.missionScript.IsComplete)
            {
                AllClear = false;
                break;
            }
        }
        if (AllClear)
        {
            if (GameEventManager.instance) GameEventManager.instance.GameClear.Invoke();
            if (GameOverUI != null)
            {
                GameOverUI.SetActive(true);
            }
        }
    }

    public void Btn_Retry()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void Btn_Title()
    {
        SceneManager.LoadScene("Title");
    }

}
