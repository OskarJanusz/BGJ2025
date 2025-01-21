using Unity.VisualScripting;
using UnityEngine;

public class PlayerAnimations : MonoBehaviour
{
    [SerializeField] private PlayerMovement PlayerMovement;
    [SerializeField] private Transform PlayerTransform;

    private void Update()
    {
        UpdateRotation();
    }

    private void UpdateRotation()
    {
        if (PlayerMovement.GetCurrentInputX() > 0)
        {
            PlayerTransform.rotation = Quaternion.Euler(0, 0, 0);
        }

        if (PlayerMovement.GetCurrentInputX() < 0)
        {
            PlayerTransform.rotation = Quaternion.Euler(0, 180, 0);
        }
    }
}
