using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Planeta : MonoBehaviour
{

    public float distancia_sol = 1;
    public float raio = 1;
    public float orbita = 1;
    public float rotacao = 1;


    private float velocidade_rotacao; 
    private float velocidade_translacao;
    public Transform base_planeta;

    public Controlador controlador;

    //A função Start é chamada apenas no inicio quando o objecto é iniciado
    void Start()
    {
        ///transform.localScale = new Vector3(raio, raio, raio);

        transform.localScale = Vector3.one * raio/1000 * controlador.multiplicador_escala;
        transform.parent.localPosition = new Vector3(distancia_sol, 0,0) * controlador.multiplicador_distancia;
        
    }

    // A função update é chamada todos os frames
    void Update()
    {
        transform.localScale = Vector3.one * raio/1000 * controlador.multiplicador_escala;
        transform.parent.localPosition = new Vector3(distancia_sol, 0,0) * controlador.multiplicador_distancia;


        //rotacao
        velocidade_rotacao = 1/rotacao * controlador.multiplicador_rotacao;
        transform.Rotate(0, velocidade_rotacao * Time.deltaTime ,  0);
        

        velocidade_translacao = 1/orbita * controlador.multiplicador_rotacao;
        if(base_planeta != null) { //verifica se existe a base_planeta
            base_planeta.Rotate(0, velocidade_translacao * Time.deltaTime, 0);
        }
        
    }

}
