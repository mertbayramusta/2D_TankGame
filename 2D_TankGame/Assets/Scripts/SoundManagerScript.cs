using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManagerScript : MonoBehaviour
{
    public static AudioClip tankShoot, enemyShoot, bossShoot;
    static AudioSource audioSrc;
        // Start is called before the first frame update
    void Start()
    {
        tankShoot = Resources.Load<AudioClip>("tank");
        enemyShoot = Resources.Load<AudioClip>("enemy");
        bossShoot = Resources.Load<AudioClip>("boss");

        audioSrc = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static void PlaySound(string clip)
    {
        switch (clip)
        {
            case "tank":
                audioSrc.PlayOneShot(tankShoot);
                break;
            case "enemy":
                audioSrc.PlayOneShot(enemyShoot);
                break;
            case "boss":
                audioSrc.PlayOneShot(bossShoot);
                break;
        }
    }
}
