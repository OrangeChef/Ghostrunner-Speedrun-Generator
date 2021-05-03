using UnityEngine;

public class PlayRandomlyChosenMusic : MonoBehaviour
{

    public AudioSource[] sources;

    void Start()
    {
        int music = Random.Range(0, sources.Length + 1);
        sources[music].Play();
    }
}