using UnityEngine;

public class LineMove : MonoBehaviour
{
    public float speed = 2f;  // Speed of movement
    public float leftBound = -8f; // Teleport from this position
    public float rightBound = 8f; // Teleport to this position

    void Update()
    {
        // Move the object continuously to the right
        transform.position += Vector3.right * speed * Time.deltaTime;

        // Check if the object crosses the right boundary
        if (transform.position.x > rightBound && speed > 0)
        {
            // Teleport to the left boundary
            Vector3 newPos = transform.position;
            newPos.x = leftBound;
            transform.position = newPos;
        }

        if (transform.position.x < leftBound && speed < 0)
        {
            Vector3 newPos = transform.position;
            newPos.x = rightBound;
            transform.position = newPos;
        }
    }
}
