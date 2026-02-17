using UnityEngine;
using UnityEngine.InputSystem;

public class OnSpaceBarPress : MonoBehaviour
{
    public Animator myAnimator;       // This controls the animations
    public AudioSource myAudioSource; // This is the "speaker" on the character
    public AudioClip spawnSound;


    //ACTIVATES WHEN THE SPACE BAR IS PRESSED
    public void Action(InputAction.CallbackContext context)
    {
        Debug.Log("working");
        myAudioSource.PlayOneShot(spawnSound);
        // myAnimator.SetTrigger("ANIMATION NAME");
    }


}
