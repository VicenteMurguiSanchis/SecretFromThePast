using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Interactuar : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject panel;
    public bool activado;
    private float contador_cierre = 0.05f;
    private float timer_cierre = 0;
    public Objeto_Equipado obj_equip;
    private Contenido_Texto texto_cambiante;

    private Objeto_Equipable last_object;

    void Awake()
    {
        activado = true;
        texto_cambiante = panel.GetComponent<Contenido_Texto>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!panel.activeSelf && !activado)
        {
            if(last_object != null)
            {
                Equipar_A_Mano();
            }

            timer_cierre += Time.deltaTime;
            if (timer_cierre >= contador_cierre)
            {
                activado = true;
                timer_cierre = 0;
            }
        }

        if(Input.GetButtonDown("Fire1") && activado && !panel.activeSelf)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if(Physics.Raycast(ray, out hit, Mathf.Infinity))
            {
                if (hit.collider.CompareTag("Objeto_Interactivo"))
                {
                    activado = false;
                    var obj_interact = hit.transform;
                    var obj_interac_script = obj_interact.GetComponent<Objeto_Interactivo>();
                    panel.SetActive(true);

                    if (obj_equip.objeto_equipado_name == obj_interac_script.password && obj_equip != null)
                    {
                        texto_cambiante.CargarTexto(obj_interac_script.contenido_texto_secundario);
                    }

                    else
                    {
                        texto_cambiante.CargarTexto(obj_interac_script.contenido_texto_primario);
                    }
                    
                }

                else if (hit.collider.CompareTag("Objeto_Recoger"))
                {
                    activado = false;
                    var obj = hit.transform;
                    last_object = obj.GetComponent<Objeto_Equipable>();
                    panel.SetActive(true);
                    texto_cambiante.CargarTexto(last_object.contenido_texto);
                    
                }
            }
        }
    }

    public void Equipar_A_Mano()
    {
        obj_equip.UpdateImage(last_object.img_obj);
        obj_equip.objeto_equipado_name = last_object.name;
        obj_equip.ocupada = true;

        last_object.gameObject.SetActive(false);
        last_object = null;
    }
}
