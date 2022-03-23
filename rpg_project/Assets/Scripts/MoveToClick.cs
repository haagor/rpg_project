using UnityEngine;
using UnityEngine.AI;

public class MoveToClick: MonoBehaviour {
    NavMeshAgent agent;

    public Transform mouseClick;
    
    void Start() {
        agent = GetComponent<NavMeshAgent>();
    }
    
    void Update() {
        if (Input.GetMouseButtonDown(1)) {
            RaycastHit hit;
            
            if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit, 100)) {
                mouseClick.transform.position = hit.point;
                agent.destination = hit.point;
            }
        }
    }
}