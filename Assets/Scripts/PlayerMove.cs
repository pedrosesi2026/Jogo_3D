using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float velocidade = 5f;
    public float forcaPulo = 7f;

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical"); // Captura W/S ou Setas

        // Movimento: 'x' move nos lados (X), mantém a gravidade (Y), 'y' move frente/trás (Z)
        rb.linearVelocity = new Vector3(x * velocidade, rb.linearVelocity.y, y * velocidade);

        // Pulo
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector3.up * forcaPulo, ForceMode.Impulse);
        }
    }
}
