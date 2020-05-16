using System.Collections;
using System.Collections.Generic;
using UnityEditorInternal;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static AudioClip ballBounce,gameStart,ballFall;
    public static AudioSource audioSrc;
    // Start is called before the first frame update
    void Start()
    {
        ballBounce = Resources.Load<AudioClip>("ballBounce");
        gameStart = Resources.Load<AudioClip>("gameStart");
        ballFall = Resources.Load<AudioClip>("ballFall");

        audioSrc = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static void PlaySound(string clip)
    {
        switch(clip)
        {
            case("ballBounce"):
                audioSrc.PlayOneShot(ballBounce);
                break;
            case ("gameStart"):
                audioSrc.PlayOneShot(gameStart);
                break;
            case ("ballFall"):
                audioSrc.PlayOneShot(ballFall);
                break;

        }

    }
}
