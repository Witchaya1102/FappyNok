using UnityEngine.Audio;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static AudioClip Firesound, Deadsound;
    static AudioSource audioSrc;
    
    // Start is called before the first frame update
    void Start()
    {
        Firesound = Resources.Load<AudioClip>("Fire");
        Deadsound = Resources.Load<AudioClip>("Dead");

        audioSrc = GetComponent<AudioSource> ();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public static void Playsound(string clip)
    {
        switch (clip)
        {
            case "Fire":
                audioSrc.PlayOneShot(Firesound);
                break;
            case "Dead":
                audioSrc.PlayOneShot(Deadsound);
                break;
        }
    }
    
}
