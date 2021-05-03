using UnityEngine;
using UnityEngine.UI;

public class EmptyRandomizations : MonoBehaviour
{

    public Text levelText;
    public Text restrictionText;
    public Text killsText;
    public Text collectiblesText;
    public KeyCode emptyKey = KeyCode.Backspace;

    void Update()
    {
        if (Input.GetKeyDown(emptyKey))
        {
            levelText.text = string.Empty;
            restrictionText.text = string.Empty;
            killsText.text = string.Empty;
            collectiblesText.text = string.Empty;
        }
    }
}