using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RadarTargetScript : MonoBehaviour
{
    public string MissionId;
    public SpriteRenderer targetSprite;
    public Color StartColor = Color.white;
    public Color CompleteColor = Color.green;
    public float GoalCount = 5f;
    [SerializeField]
    private float StayCount = 0f;
    private bool CanActive;
    private void Start()
    {
        StayCount = 0f;
        targetSprite.color = StartColor;
        ControlSpriteShow(false);
    }

    private void Update()
    {
        StayCount = Mathf.Clamp(StayCount - (Time.deltaTime / 2f), 0, GoalCount);
        targetSprite.color = Color.Lerp(new Color(StartColor.r, StartColor.g, StartColor.b, CanActive ? 1f : 0.4f),new Color(CompleteColor.r, CompleteColor.g, CompleteColor.b, CanActive ? 1f : 0.4f), StayCount/ GoalCount);
    }

    private void ControlSpriteShow(bool i_canactive)
    {
        CanActive = i_canactive;
        targetSprite.color = new Color(targetSprite.color.r, targetSprite.color.g, targetSprite.color.b, CanActive ? 1f : 0.4f);
    }
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag.Equals("Radar"))
        {
            ControlSpriteShow(true);
        }
    }

    private void OnTriggerStay2D(Collider2D col)
    {
        if (col.tag.Equals("Ship") && CanActive)
        {
            StayCount += Time.deltaTime;
            if (StayCount >= GoalCount)
            {
                Debug.Log("Complete !");
            }
        }
    }

    private void OnTriggerExit2D(Collider2D col)
    {
        if (col.tag.Equals("Radar"))
        {
            ControlSpriteShow(false);
        }
    }
}
