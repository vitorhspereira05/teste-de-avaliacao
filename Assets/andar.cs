using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;

public class coiso : MonoBehaviour
{
    public Rigidbody jogador;
    public TMP_Text contar;

    void Update()
    {
        
        jogador.AddForce(4, 0, 0);

        if (Keyboard.current.leftArrowKey.isPressed)
            jogador.AddForce(0, 0, 4);

        if (Keyboard.current.rightArrowKey.isPressed)
            jogador.AddForce(0, 0, -4);
    }

    private void OnCollisionEnter(Collision quem)
    {
        string tagTocada = quem.gameObject.tag;

        
        if (tagTocada == "Alcatifa")
            contar.text = "Alcatifa";
        else if (tagTocada == "gelo")
            contar.text = "Gelo";
        else if (tagTocada == "saltitante")
            contar.text = "Saltitante";
    }

    private void OnCollisionExit(Collision quem)
    {
    }
}
