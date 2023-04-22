using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JoyconInputManager : MonoBehaviour
{
    public int jc_ind = 0;
    private Joycon joycon;
    public float[] stick;

    bool InterActBtnPress;

    public PlayerController ControlTarget;
    private void Start()
    {
        if (JoyconManager.Instance)
        {
            if (JoyconManager.Instance.j.Count < jc_ind + 1)
            {
                this.enabled = false;
            }
            else
            {
                joycon = JoyconManager.Instance.j[jc_ind];
            }
        }
    }

    private void Update()
    {
        if (ControlTarget == null) return;
        if (joycon.GetButtonDown(jc_ind == 0 ? Joycon.Button.DPAD_DOWN : Joycon.Button.DPAD_UP) && !InterActBtnPress)
        {
            InterActBtnPress = true;
            ControlTarget.OnInteractionInput(true);
        }
        else if (joycon.GetButtonUp(jc_ind == 0 ? Joycon.Button.DPAD_DOWN : Joycon.Button.DPAD_UP) && InterActBtnPress)
        {
            InterActBtnPress = false;
            ControlTarget.OnInteractionInput(false);
        }

        if (joycon.GetButtonDown(jc_ind == 0 ? Joycon.Button.DPAD_LEFT : Joycon.Button.DPAD_RIGHT))
        {
            ControlTarget.OnExitInput();
        }
        float[] stickinput = joycon.GetStick();
        float X = Mathf.Abs(stickinput[1]) <= 0.5f ? 0 : (stickinput[1] > 0 ? (jc_ind == 0 ? -1 : 1) : (jc_ind == 0 ? 1f : -1f));
        float Y = Mathf.Abs(stickinput[0]) <= 0.5f ? 0 : (stickinput[0] > 0 ? (jc_ind == 0 ? 1 : -1) : (jc_ind == 0 ? -1f : 1f));
        Vector2 dir = new Vector2(X, Y);
        ControlTarget.OnMoveInput(dir);

    }
}
