using UnityEngine;

public class movement : MonoBehaviour
{
    public float moveSpeed = 2.0f;

    void Update()
    {
        // Moves the character forward relative to its own orientation
        transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
    }
}
