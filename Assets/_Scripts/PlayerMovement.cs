using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private Rigidbody2D PlayerRb;
    [SerializeField] private GroundChecker GroundChecker;
    [SerializeField] private float MoveSpeed = 5f;
    [SerializeField] private float JumpPower = 5f;

    private float inputX;
    private bool isJumpingInput = false;

    private void Update()
    {
        inputX = Input.GetAxis("Horizontal");

        if(Input.GetKeyDown(KeyCode.W) && GroundChecker.isGrounded)
        {
            isJumpingInput = true;
        }
    }

    private void FixedUpdate()
    {
        float moveInput = inputX * Time.deltaTime * MoveSpeed;
        PlayerRb.linearVelocity = new Vector2(moveInput, PlayerRb.linearVelocityY);

        if(isJumpingInput)
        {
            PlayerRb.AddForce(new Vector2(0, JumpPower), ForceMode2D.Impulse);
            isJumpingInput = false;
        }
    }
}
