using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipMotionController : MonoBehaviour
{
    public float speed;
    public float maxHeight;
    public float minHeight;
    private ShipInput input;
    // Start is called before the first frame update
    void Start()
    {
        input = GetComponent<ShipInput>();
    }

    // Update is called once per frame
    void Update()
    {
        var position = this.transform.position + (input.vertical * Time.deltaTime * speed * Vector3.up);
        position.y = Mathf.Clamp(position.y, minHeight, maxHeight);
        this.transform.position = position;
    }
}
