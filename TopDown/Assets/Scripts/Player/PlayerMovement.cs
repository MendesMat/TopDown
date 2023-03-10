using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    Rigidbody2D rb;

    #region Variaveis
    private float deltaTime;
    private float movementSpeed = 250f;
    private Vector2 movementDirection;
    #endregion

    private void Start()
    {
        deltaTime = Time.fixedDeltaTime;
    }

    public void SetMovement(InputAction.CallbackContext context)
    {
        this.movementDirection = context.ReadValue<Vector2>();
    }

    private void FixedUpdate()
    {
        rb.velocity = movementDirection * movementSpeed * deltaTime;
    }
}
