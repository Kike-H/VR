using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComportamientoZombie : MonoBehaviour
{
    private int saludActual;
    public int salud = 100;
    // Start is called before the first frame update
    void Start()
    {
        saludActual = salud;
    }

    public void OnCollisionEnter(Collision colision)
    {
        if(saludActual > 0)
        {
            RegistrarDanio(UnityEngine.Random.Range(5,20));
        }
    }


    private void RegistrarDanio(int danioARegistrar)
    {
        saludActual -= danioARegistrar;
        if(saludActual <= 0)
        {
            Destroy(gameObject);
        }
    }

    
    
}
