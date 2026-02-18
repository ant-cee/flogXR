using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Rendering;

public class OnSpaceBarPress : MonoBehaviour
{
    public SkinnedMeshRenderer GiveMeFrog;
    public AudioSource myAudioSource; 
    public AudioClip spawnSound;

    private float spawnInterval = int.MaxValue; 
    private float timer;
    private float progres = 100;
    private bool done = true;
    private bool returnning = false;


    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= spawnInterval)
        {

            if(returnning)
            {
                returnToNormal();
                timer = 0;
            }
            else
            {
                PlayAnimation();
                timer = 0;
            }


        }
    }


    //ACTIVATES WHEN THE SPACE BAR IS PRESSED
    public void Action(InputAction.CallbackContext context)
    {
        if(done)
        {
            spawnInterval = .01f;
            myAudioSource.PlayOneShot(spawnSound);
            done = false;
        }

    }



    public void PlayAnimation()
    {

        GiveMeFrog.SetBlendShapeWeight(0, progres);
        progres -= 3;

        if(progres <= 0)
        {
            returnning = true;
        }
        
    }



    public void returnToNormal()
    {
        GiveMeFrog.SetBlendShapeWeight(0, progres);
        progres += 2;

        if (progres >= 100)
        {
            progres = 100f;
            spawnInterval = int.MaxValue;
            returnning = false;
            done = true;
        }

    }



}
