using UnityEngine;
using UnityEngine.AI;

public class SelectObject : MonoBehaviour
{

    Color initialColor;
    bool lockSelect = false; 

    void Start()
    {
        initialColor = gameObject.GetComponent<Renderer> ().material.color;
    }

    void OnMouseOver () {
        if (Input.GetMouseButtonDown(1)) {
            gameObject.GetComponent<Renderer> ().material.color = Color.green;
            lockSelect = true;
        }
    }

    void Update() {
        if (Input.GetMouseButtonDown(1) && !lockSelect) {
            gameObject.GetComponent<Renderer> ().material.color = initialColor;
        } else {
            lockSelect = false;
        }
    }


}
