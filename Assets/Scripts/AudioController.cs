using UnityEngine;
using UnityEngine.Audio;

public class AudioController : MonoBehaviour
{
    public static AudioMixer audioMixer;

    void Start()
    {
        audioMixer = gameObject.GetComponent<AudioSource>().outputAudioMixerGroup.audioMixer;
        DontDestroyOnLoad(transform.gameObject);
    }

    public static void setMasterVolume(float volume)
    {
        audioMixer.SetFloat("MasterVolume", volume);
    }

    public static void setMasterPitch(float volume)
    {
        audioMixer.SetFloat("MasterPitch", volume);
    }

    public static void setMusicVolume(float volume)
    {
        audioMixer.SetFloat("MusicVolume", volume);
    }

    public static void setMusicPitch(float volume)
    {
        audioMixer.SetFloat("MusicPitch", volume);
    }

    public static void setSFXVolume(float volume)
    {
        audioMixer.SetFloat("SFXVolume", volume);
    }

    public static void setSFXPitch(float volume)
    {
        audioMixer.SetFloat("SFXPitch", volume);
    }

    public static float getMasterVolume()
    {
        float volume;
        audioMixer.GetFloat("MasterVolume", out volume);
        return volume;
    }

    public static float getMasterPitch()
    {
        float volume;
        audioMixer.GetFloat("MasterPitch", out volume);
        return volume;
    }

    public static float getMusicVolume()
    {
        float volume;
        audioMixer.GetFloat("MusicVolume", out volume);
        return volume;
    }

    public static float getMusicPitch()
    {
        float volume;
        audioMixer.GetFloat("MusicPitch", out volume);
        return volume;
    }

    public static float getSFXVolume()
    {
        float volume;
        audioMixer.GetFloat("SFXVolume", out volume);
        return volume;
    }

    public static float getSFXPitch()
    {
        float volume;
        audioMixer.GetFloat("SFXPitch", out volume);
        return volume;
    }
}
