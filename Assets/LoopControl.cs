using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoopControl : MonoBehaviour
{
    private Animator anim;
    public AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        audioSource.Play();
    }

    // Update is called once per frame
    void Update()
    {
        if (!audioSource.isPlaying)
        {
            //restart the audio
            audioSource.Play();
            //restart the animation
            anim.Rebind();
            anim.Update(0f);
        }
    }
}
