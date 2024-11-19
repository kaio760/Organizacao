using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.UI;

public class Geral : MonoBehaviour
{
    internal int placarJogadorNum, recordeNum;
    public Text placarJogadorTexto, recordeTexto;
    public GameObject gameOver, personagemPrincipal, ferramenta;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        placarJogadorNum = 0;
        recordeNum = 0;
    }

    public void MarcarPonto()
    {
        placarJogadorNum += 1;

        if(recordeNum < placarJogadorNum)
        {
            recordeNum += 1;
        }
        AtualizarTextoPlacar();

        GetComponent<AudioSource>().Play();
    }
    public void AtualizarTextoPlacar()
    {
        placarJogadorTexto.text = "Itens coletados:" + placarJogadorNum;
        recordeTexto.text = "Recorde atual:" + recordeNum;
    }


    public void IniciarPartida()
    {
        placarJogadorNum = 0;
        AtualizarTextoPlacar();


        //Voltatar a velocidade para o "padão"
        //Reposicionar a luva

        //Sumir com o game-over
        gameOver.SetActive(false);

        //Reposicionar a luva
        personagemPrincipal.transform.position = new Vector3(875, 250, 0);

        //Reposicionar ferramenta
        ferramenta.GetComponent<ControladorFerramenta>().posicaoFerramenta = new Vector3(0, 0, 0);

        //voltar a velocidade padrão
        ferramenta.GetComponent<ControladorFerramenta>().deslocamentoFerramenta= ferramenta.GetComponent<ControladorFerramenta>().deslocamentoInicial;
    }
}
