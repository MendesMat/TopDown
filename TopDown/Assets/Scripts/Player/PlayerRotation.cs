using UnityEngine;

public class PlayerRotation : MonoBehaviour
{
    private Camera mainCamera;
    private Vector2 direction;

    private void Start()
    {
        mainCamera = Camera.main;
    }

    private void Update()
    {
        // Atualiza a posição do mouse em relação à câmera
        Vector2 mousePosition = mainCamera.ScreenToWorldPoint(Input.mousePosition);

        // Calcula a direção do mouse em relação ao jogador
        direction = mousePosition - (Vector2)transform.position;
    }

    private void FixedUpdate()
    {
        // Rotaciona o jogador em direção ao mouse usando Quaternion.LookRotation()
        Quaternion rotation = Quaternion.LookRotation(Vector3.forward, direction);
        transform.rotation = rotation;
    }
}
