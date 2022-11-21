using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleShipController : MonoBehaviour
{
    private Transform _transformComponent; // barra baja antes de una variable indica q es una variable privada (norma no escrita entre programadores)
    // Start is called before the first frame update
    void Start()
    {
        _transformComponent = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");
        _transformComponent.Translate(0, y * 0.1f /* speed */, 0);
        _transformComponent.Rotate(0, 0, -x);
    }
}
