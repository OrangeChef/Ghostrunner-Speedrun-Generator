using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class ResetRandomizer : MonoBehaviour
{

    public KeyCode resetKey = KeyCode.R;
    public float resetDuration = 1f;
    public Slider durationSlider;

    [Space]
    public Randomize randomizer;
    public string levelsFileName = "Levels.txt";
    public string restrictionsFileName = "Restrictions.txt";
    public string killsFileName = "Kills.txt";
    public string collectiblesFileName = "Collectibles.txt";

    [Space]
    public string[] defaultLevels;
    public string[] defaultRestrictions;
    public string[] defaultKills;
    public string[] defaultCollectibles;

    private float resetTimer;

    void Update()
    {
        if (Input.GetKey(resetKey))
            resetTimer += Time.deltaTime;
        else
            resetTimer = 0f;

        durationSlider.maxValue = resetDuration;
        durationSlider.value = resetTimer;

        if (resetTimer >= resetDuration)
        {
            string levelsPath = Path.Combine(Application.streamingAssetsPath, levelsFileName);
            if (File.Exists(levelsPath))
                File.WriteAllLines(levelsPath, defaultLevels);

            string restrictionsPath = Path.Combine(Application.streamingAssetsPath, restrictionsFileName);
            if (File.Exists(restrictionsPath))
                File.WriteAllLines(restrictionsPath, defaultRestrictions);

            string killsPath = Path.Combine(Application.streamingAssetsPath, killsFileName);
            if (File.Exists(killsPath))
                File.WriteAllLines(killsPath, defaultKills);

            string collectiblesPath = Path.Combine(Application.streamingAssetsPath, collectiblesFileName);
            if (File.Exists(collectiblesPath))
                File.WriteAllLines(collectiblesPath, defaultCollectibles);
        }
    }
}