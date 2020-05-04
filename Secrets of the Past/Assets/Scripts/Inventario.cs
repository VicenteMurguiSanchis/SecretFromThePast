using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventario : MonoBehaviour
{
    private List<Objeto_Equipable> objetos_inventario;


    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void anyadir_inventario(Objeto_Equipable obj_new)
    {
        objetos_inventario.Add(obj_new);
    }
}
