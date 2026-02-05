using UnityEngine;
using UnityEngine.InputSystem;

public class LightChange : MonoBehaviour
{
    private Light pointLight;
    public InputActionReference switchAction;

    void Start()
    {

        pointLight = GetComponent<Light>();

        switchAction.action.performed += ctx =>
        {
            Debug.Log("Light Switch action");
            pointLight.color = new Color(Random.value, Random.value, Random.value);
        };

        switchAction.action.Enable();
    }

    void Update()
    {

    }
}
