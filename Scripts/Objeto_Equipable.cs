using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Objeto_Interactuable : MonoBehaviour
{
    public string nombre;
    //public GameObject panel;
    public string[] contenido_texto;
    //public Objeto_Equipado obj_equip;
    public Sprite img_obj;
    // Start is called before the first frame update
    void Start()
    {
        nombre = "llave";
    }

    // Update is called once per frame
    void Update()
    {
            //panel.SetActive(true);
            //Text texto = panel.GetComponentInChildren<Text>();
            //texto.text = contenido_texto[num_text];
                //Se deja un texto más para que si el jugador pulsa click sobre otro objeto no aparezca directamente el texto asociado a este
                    //panel.SetActive(false);
                    //obj_equip.UpdateImage(img_obj);
                    //obj_equip.objeto_equipado_name = nombre;
                    //obj_equip.ocupada = true;
    }
}
