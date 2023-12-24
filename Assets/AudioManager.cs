using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class AudioManager : MonoBehaviour
{
    public static AudioClip jump;
    public static AudioClip hit;
    public static AudioClip point;
    public static AudioClip die;
    static AudioSource audiosrc;

    void Start()
    {
        jump = Resources.Load<AudioClip>("wing");
        hit = Resources.Load<AudioClip>("hit");
        point = Resources.Load<AudioClip>("point");
        die = Resources.Load<AudioClip>("die");
        audiosrc = GetComponent<AudioSource>();
    }



    public static void PlaySound(string _name)
    {
        switch (_name)
        {



            case "jump":
                audiosrc.PlayOneShot(jump);
                break;
            case "hit":
                audiosrc.PlayOneShot(hit);
                break;
            case "point":
                audiosrc.PlayOneShot(point);
                break;
            case "die":
                audiosrc.PlayOneShot(die);
                break;










        }
    }
}


















