using System.IO;
using UnityEngine;

public class ReadInputFile : MonoBehaviour
{

    public Randomize randomize;

    [Space]
    public string levelsFileName = "Levels.txt";
    public string restrictionsFileName = "Restrictions.txt";
    public string killsFileName = "Kills.txt";
    public string collectiblesFileName = "Collectibles.txt";
    public string boundsFileName = "Bounds.txt";

    void Update()
    {
        string levelsPath = Path.Combine(Application.streamingAssetsPath, levelsFileName);
        string restrictionsPath = Path.Combine(Application.streamingAssetsPath, restrictionsFileName);
        string killsPath = Path.Combine(Application.streamingAssetsPath, killsFileName);
        string collectiblesPath = Path.Combine(Application.streamingAssetsPath, collectiblesFileName);
        string boundsPath = Path.Combine(Application.streamingAssetsPath, boundsFileName);

        if (File.Exists(levelsPath))
        {
            string[] lines = File.ReadAllLines(levelsPath);

            randomize.levels = new string[lines.Length];
            for (int i = 0; i < randomize.levels.Length; i++)
            {
                randomize.levels[i] = lines[i];
            }
        }

        if (File.Exists(restrictionsPath))
        {
            string[] lines = File.ReadAllLines(restrictionsPath);

            randomize.restrictions = new string[lines.Length];
            for (int i = 0; i < randomize.restrictions.Length; i++)
            {
                randomize.restrictions[i] = lines[i];
            }
        }

        if (File.Exists(killsPath))
        {
            string[] lines = File.ReadAllLines(killsPath);

            randomize.kills = new string[lines.Length];
            for (int i = 0; i < randomize.kills.Length; i++)
            {
                randomize.kills[i] = lines[i];
            }
        }

        if (File.Exists(collectiblesPath))
        {
            string[] lines = File.ReadAllLines(collectiblesPath);

            randomize.collectibles = new string[lines.Length];
            for (int i = 0; i < randomize.collectibles.Length; i++)
            {
                randomize.collectibles[i] = lines[i];
            }
        }

        if (File.Exists(boundsPath))
        {
            string[] lines = File.ReadAllLines(boundsPath);

            randomize.bounds = new string[lines.Length];
            for (int i = 0; i < randomize.bounds.Length; i++)
            {
                randomize.bounds[i] = lines[i];
            }
        }
    }
}