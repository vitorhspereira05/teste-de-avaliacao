using UnityEngine;

public class seguir_esfera : MonoBehaviour
{
    public Transform jogador;
    public Vector3 distancia;
    void Update()
    {
        transform.position = jogador.position+distancia;
    }
}
