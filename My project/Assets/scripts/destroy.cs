using UnityEngine;

public class destroy : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void OnTriggerEnter(Collider other)
    {
        // Check if the thing entering the trigger is one of your guys
        // (You can also use Tags like "NPC" to be safe)
        Destroy(other.gameObject);
    }
}
