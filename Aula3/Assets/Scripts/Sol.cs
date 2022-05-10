using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sol : MonoBehaviour
{
    public float raio = 696340;
    public float multiplicador_sol = 0.008f;
    public Controlador controlador;
    // Start is called before the first frame update
    void Start()
    {
        transform.localScale = Vector3.one * raio/1000 * multiplicador_sol;
    }

    // Update is called once per frame
    void Update()
    {
        transform.localScale = Vector3.one * raio/1000 * multiplicador_sol;
    }
}
