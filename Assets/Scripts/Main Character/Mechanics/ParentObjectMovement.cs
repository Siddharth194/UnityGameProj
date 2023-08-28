using UnityEngine;

public class ConvertCoordinates : MonoBehaviour
{
    public GameObject child;

    void Update()
    {
        Transform childTransform = child.GetComponent<Transform>();

        if (childTransform != null)
        {
            // Convert the child's position from local space to world space
            Vector3 childPositionInWorldSpace = childTransform.position;

            // Set the parent GameObject's position to the child's position in world space
            transform.position = childPositionInWorldSpace;
        }
        else
        {
            Debug.LogError("Child Transform not found!");
        }
    }
}
