using UnityEngine;

public class ControladorLimite : MonoBehaviour
{
    public GameObject objetoGameOver;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.name.StartsWith("Ferramenta"))

            objetoGameOver.SetActive(true);

    }






}