using UnityEngine;
using UnityEngine.UI;

public class Randomize : MonoBehaviour
{

    public float colorLerpTime = 3f;
    public Text levelText;
    public Text restrictionText;
    public Text killsText;
    public Text collectiblesText;
    public Text boundsText;

    [Space]
    public AudioSource[] sounds;
    public string[] levels;
    public string[] restrictions;
    public string[] kills;
    public string[] collectibles;
    public string[] bounds;

    void Update()
    {
        if (levelText.color != Color.white)
            levelText.color = Color.Lerp(levelText.color, Color.white, colorLerpTime * Time.deltaTime);

        if (restrictionText.color != Color.white)
            restrictionText.color = Color.Lerp(restrictionText.color, Color.white, colorLerpTime * Time.deltaTime);

        if (killsText.color != Color.white)
            killsText.color = Color.Lerp(killsText.color, Color.white, colorLerpTime * Time.deltaTime);

        if (collectiblesText.color != Color.white)
            collectiblesText.color = Color.Lerp(collectiblesText.color, Color.white, colorLerpTime * Time.deltaTime);

        if (boundsText.color != Color.white)
            boundsText.color = Color.Lerp(boundsText.color, Color.white, colorLerpTime * Time.deltaTime);
    }

    public void RandomizeLevel()
    {
        int level = Random.Range(0, levels.Length);
        levelText.text = levels[level];
        levelText.color = Color.yellow;

        sounds[Random.Range(0, sounds.Length)].Play();
    }

    public void RandomizeRestriction()
    {
        int restriction = Random.Range(0, restrictions.Length);
        restrictionText.text = restrictions[restriction];
        restrictionText.color = Color.yellow;

        sounds[Random.Range(0, sounds.Length)].Play();
    }

    public void RandomizeKills()
    {
        int kill = Random.Range(0, kills.Length);
        killsText.text = kills[kill];
        killsText.color = Color.yellow;

        sounds[Random.Range(0, sounds.Length)].Play();
    }

    public void RandomizeCollectibles()
    {
        int collectible = Random.Range(0, collectibles.Length);
        collectiblesText.text = collectibles[collectible];
        collectiblesText.color = Color.yellow;

        sounds[Random.Range(0, sounds.Length)].Play();
    }

    public void RandomizeBounds()
    {
        int bound = Random.Range(0, bounds.Length);
        boundsText.text = bounds[bound];
        boundsText.color = Color.yellow;

        sounds[Random.Range(0, sounds.Length)].Play();
    }
}