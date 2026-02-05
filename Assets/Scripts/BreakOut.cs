using UnityEngine;
using UnityEngine.InputSystem;

public class BreakOut : MonoBehaviour
{
    public InputActionReference action;
    public GameObject viewPoint;

    private Vector3 insidePosition;
    private Quaternion insideRotation;
    private bool isOutside = false;

    void Start()
    {
        insidePosition = transform.position;
        insideRotation = transform.rotation;

        action.action.performed += ctx =>
        {
            Debug.Log("Teleport action");
            if (!isOutside)
            {
                transform.position = viewPoint.transform.position;
                transform.rotation = viewPoint.transform.rotation;
            }
            else
            {
                transform.position = insidePosition;
                transform.rotation = insideRotation;
            }

            isOutside = !isOutside;
        };

        action.action.Enable();
    }
}
