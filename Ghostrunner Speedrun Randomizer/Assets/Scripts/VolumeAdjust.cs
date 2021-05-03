using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class VolumeAdjust : MonoBehaviour
{

    public Slider soundEffectSlider;
    public Slider musicSlider;
    public string fileName;

    [Space]
    public AudioSource[] soundEffects;
    public AudioSource[] music;

    private void Start()
    {
        string path = Path.Combine(Application.streamingAssetsPath, fileName);
        if (File.Exists(path))
        {
            string[] contents = File.ReadAllLines(path);
            soundEffectSlider.value = float.Parse(contents[0]);
            musicSlider.value = float.Parse(contents[1]);
        }
    }

    void Update()
    {
        string path = Path.Combine(Application.streamingAssetsPath, fileName);

        string[] contents = new string[2];
        contents[0] = soundEffectSlider.value.ToString();
        contents[1] = musicSlider.value.ToString();

        File.WriteAllLines(path, contents);

        foreach (AudioSource source in soundEffects)
        {
            source.volume = soundEffectSlider.value;
        }

        foreach (AudioSource source in music)
        {
            source.volume = musicSlider.value;
        }
    }
}