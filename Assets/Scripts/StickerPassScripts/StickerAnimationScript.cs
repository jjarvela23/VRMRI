using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StickerAnimationScript : MonoBehaviour
{
    private Animator mAnimator;
    private ParticleSystem ParticleSystem;
    // Start is called before the first frame update
    void Awake()
    {
        mAnimator = GetComponent<Animator>();
        ParticleSystem = GetComponent<ParticleSystem>();
    }

    public void GiveSticker(string nextscene, bool changescene)
    {
        StartCoroutine(PlayAnimationAndParticles(nextscene, changescene));
    }

    //activates the sticker
    public void GetSticker()
    {
        mAnimator.SetTrigger("ReceiveSticker");
    }

    //play particle animation
    public void DoParticles()
    {
        ParticleSystem.Play();
    }

    //play sound
    public void PlaySound()
    {
        GameObject.FindGameObjectWithTag("stickerPass").GetComponent<AudioSource>().Play();
    }

    //play each function on time, and load the scene in the end.
    IEnumerator PlayAnimationAndParticles(string nextscene, bool changescene)
    {
        Debug.Log("Playing sticker animation");
        yield return new WaitForSeconds(1);
        GetSticker();
        Debug.Log("middle animation");
        yield return new WaitForSeconds(2);
        DoParticles();
        PlaySound();
        Debug.Log("End animation");
        yield return new WaitForSeconds(2);
        if (changescene)
        {
            SceneManager.LoadScene(nextscene);
        }
    }
}
