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
        // Atualiza a posi��o do mouse em rela��o � c�mera
        Vector2 mousePosition = mainCamera.ScreenToWorldPoint(Input.mousePosition);

        // Calcula a dire��o do mouse em rela��o ao jogador
        direction = mousePosition - (Vector2)transform.position;
    }

    private void FixedUpdate()
    {
        // Rotaciona o jogador em dire��o ao mouse usando Quaternion.LookRotation()
        Quaternion rotation = Quaternion.LookRotation(Vector3.forward, direction);
        transform.rotation = rotation;
    }
}
