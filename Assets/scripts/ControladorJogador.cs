using UnityEngine;

public class ControladorJogador : MonoBehaviour
{
    public float velocidadeMaozinha;
    public Geral juizDoJogo;



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Fazer a mão subir

        if (Input.GetKey(KeyCode.UpArrow) && transform.position.y <=465)
        {
            Vector3 novaPos = new Vector3(0, velocidadeMaozinha * Time.deltaTime,0);
            transform.position = transform.position += novaPos;
        }

        // Fazer a mão descer 

        if (Input.GetKey(KeyCode.DownArrow) && transform.position.y >=35)
        {
            Vector3 novaPos = new Vector3(0, velocidadeMaozinha * Time.deltaTime, 0);
            transform.position = transform.position -= novaPos;
        }
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name.StartsWith("Ferramenta"))
        {
            float positionY = Random.value * 465;
            collision.GetComponent<ControladorFerramenta>().posicaoFerramenta.x = 0;
            collision.GetComponent<ControladorFerramenta>().posicaoFerramenta.y = positionY;

            juizDoJogo.MarcarPonto();
        }
    }
}



