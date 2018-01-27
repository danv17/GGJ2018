using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Battery : MonoBehaviour {

    public SpriteRenderer[] batteries;
    public int cont;
    // Use this for initialization
    void Start() {
        batteries = GetComponentsInChildren<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update() {
        this.getEnabledBatteries();
    }

    /**
     * Retorna la cantidad y el index de baterías visibles
     **/
    public int getEnabledBatteries()
    {
        cont = 0;
        for(int i = batteries.Length-1; i > 0; i--)
        {
            if (batteries[i].isVisible)
            {
                cont++;
            }
        }
        return cont;
    }
}
