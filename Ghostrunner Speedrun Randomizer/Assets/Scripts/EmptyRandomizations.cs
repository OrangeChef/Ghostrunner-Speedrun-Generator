using UnityEngine;
using UnityEngine.UI;

public class EmptyRandomizations : MonoBehaviour
{

    public float holdDuration = 1f;
    public Slider holdDisplay;
    public KeyCode emptyKey = KeyCode.Backspace;

    [Space]
    public Text levelText;
    public Text restrictionText;
    public Text killsText;
    public Text collectiblesText;
    public Text boundsText;

    private float holdTimer;

    void Update()
    {
        holdDisplay.maxValue = holdDuration;
        holdDisplay.value = holdTimer;

        if (Input.GetKey(emptyKey))
            holdTimer += Time.deltaTime;
        else
            holdTimer = 0f;

        if (holdTimer >= holdDuration)
        {
            levelText.text = string.Empty;
            restrictionText.text = string.Empty;
            killsText.text = string.Empty;
            collectiblesText.text = string.Empty;
            boundsText.text = string.Empty;
        }
    }
}