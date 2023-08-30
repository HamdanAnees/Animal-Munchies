using UnityEngine;

public class ConstrainedMovement : MonoBehaviour
{
    private Transform parentTransform;
    private Vector3 initialPosition;

    private void Start()
    {
        parentTransform = transform.parent;
        initialPosition = transform.localPosition;
    }

    private void Update()
    {
        // Calculate the constrained position within the parent's boundaries
        Vector3 constrainedPosition = new Vector3(
            Mathf.Clamp(transform.localPosition.x, initialPosition.x - parentTransform.localScale.x / 2, initialPosition.x + parentTransform.localScale.x / 2),
            Mathf.Clamp(transform.localPosition.y, initialPosition.y - parentTransform.localScale.y / 2, initialPosition.y + parentTransform.localScale.y / 2),
            Mathf.Clamp(transform.localPosition.z, initialPosition.z - parentTransform.localScale.z / 2, initialPosition.z + parentTransform.localScale.z / 2)
        );

        // Apply the constrained position
        transform.localPosition = constrainedPosition;
    }
}
