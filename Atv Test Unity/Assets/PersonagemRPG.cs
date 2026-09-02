using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class PersonagemRPG : MonoBehaviour
{
    int Nivel;
    int Vida;
    string NomeDoJogador;
    bool EstaVivo;
    float Velocidade;

    const int VIDA_MAXIMA = 100;
    const float Gravidade = 10f;


    void Start()
    {
        int Nivel = 3;
        int Vida = 50;
        string  NomeDoJogador = "Arthas";
        bool EstaVivo = true;
        float Velocidade = 100f;

       int VIDA_MAXIMA = 100;





        Debug.Log("nome: " + NomeDoJogador);
        Debug.Log("Vida" +  Vida);
        Debug.Log("Nivel: " + Nivel);
        Debug.Log("Velocidade: " + Velocidade);
        Debug.Log("Vivo: " +  EstaVivo);

        string msg = $"Nome: {NomeDoJogador}| Nivel: {Nivel} | Vida: {Vida}/{VIDA_MAXIMA} | velocidade: {Velocidade}";
        Debug.Log(msg);

    }

    void Update()
    {
        
    }
}
