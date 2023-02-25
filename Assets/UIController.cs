using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class PointerObj
{
    public Transform TargetObj;

    public Color PointerColor;

    public RectTransform Pointer_UI;

    public bool Show;

}
public class UIController : MonoBehaviour
{
    public Camera m_Camera;

    public Canvas MainCanvas;

    public GameObject Pointer;

    private List<PointerObj> m_Pointers = new List<PointerObj>();

    private void Start()
    {
        if (GameManager.instance)
        {
            foreach (var item in GameManager.instance.planets)
            {
                PointerObj obj = new PointerObj();
                obj.TargetObj = item.PlanetTransform;
                obj.PointerColor = item.TagColor;
                obj.Pointer_UI = Instantiate(Pointer, MainCanvas.transform).GetComponent<RectTransform>();
                obj.Pointer_UI.gameObject.GetComponent<Image>().color = obj.PointerColor;
                obj.Show = true;
                m_Pointers.Add(obj);
            }
        }
    }

    private void FixedUpdate()
    {
        RectTransform CanvasRect = MainCanvas.GetComponent<RectTransform>();

        foreach (var item in m_Pointers)
        {
            if (!item.Show)
            {
                item.Pointer_UI.gameObject.SetActive(false);
                continue;
            }
            else
            {
                item.Pointer_UI.gameObject.SetActive(true);
            }
            Vector2 ViewportPosition = m_Camera.WorldToViewportPoint(item.TargetObj.transform.position);
            float Xpos = Mathf.Clamp((ViewportPosition.x * CanvasRect.sizeDelta.x) - (CanvasRect.sizeDelta.x * 0.5f), CanvasRect.rect.xMin, CanvasRect.rect.xMax);
            float YPos = Mathf.Clamp((ViewportPosition.y * CanvasRect.sizeDelta.y) - (CanvasRect.sizeDelta.y * 0.5f), CanvasRect.rect.yMin, CanvasRect.rect.yMax);
            Vector2 WorldObject_ScreenPosition = new Vector2(Xpos, YPos);

            Vector2 newDir = (Vector2)item.TargetObj.transform.position - (Vector2)MainCanvas.transform.position;
            float angle = Mathf.Atan2(newDir.y, newDir.x) * Mathf.Rad2Deg -90;
            item.Pointer_UI.rotation = Quaternion.Euler(new Vector3(0, 0, angle));
            item.Pointer_UI.anchoredPosition = WorldObject_ScreenPosition;
        }
    }
}
