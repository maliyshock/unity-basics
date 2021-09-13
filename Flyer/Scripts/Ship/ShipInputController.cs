using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(ShipInput))]
public class ShipInputController : MonoBehaviour
{

    private ShipInput input;

    // Start is called before the first frame update
    void Start()
    {
        input = GetComponent<ShipInput>();
    }

    // Update is called once per frame
    void Update()
    {
        input.vertical = Input.GetAxis("Vertical");
    }
}
