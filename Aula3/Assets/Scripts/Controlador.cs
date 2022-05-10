using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Controlador : MonoBehaviour
{
    public float multiplicador_escala = 0.001f;
    public float multiplicador_distancia = 1;
    public float multiplicador_rotacao = 20;

    public Slider SliderEscala;
    public Slider SliderDistancia;
    public Slider SliderRotacao;

    public GameObject Sol;

    // Start is called before the first frame update
    void Start()
    {

        
        //SliderEscala.onValueChanged.AddListener(delegate{MudaEscala();});
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CriarSol() {
        GameObject.Instantiate<GameObject>(Sol, Vector3.zero, Quaternion.identity);
    }

    public void MudaEscala() {
        multiplicador_escala = SliderEscala.value;
    }

    public void MudaDistancia() {
        multiplicador_distancia = SliderDistancia.value;
    }

    public void MudaRotacao() {
        multiplicador_rotacao = SliderRotacao.value;
    }
}
