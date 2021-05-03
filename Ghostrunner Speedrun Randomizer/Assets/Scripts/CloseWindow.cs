using UnityEngine;

public class CloseWindow : MonoBehaviour
{

    public KeyCode[] closeKeys;

    void Update()
    {
        foreach(KeyCode key in closeKeys)
        {
            if (Input.GetKeyDown(key))
                Application.Quit();
        }
    }
}