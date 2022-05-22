using UnityEngine;
using UnityEngine.AI;
using System.Collections.Generic;

public class PersonaBehavior: MonoBehaviour {
    
    NavMeshAgent agent;

    public Transform[] interestPoint;
    Transform Destination;
    
    void Start() {
        agent = GetComponent<NavMeshAgent>();
        Destination = interestPoint[0];
    }
    
    void Update() {
        if (!agent.pathPending && !agent.hasPath) {
            Debug.Log ("I have reached my destination!");
            updateDestination();
        }

        agent.destination = Destination.transform.position;
    }

    void updateDestination() {
        // change when multiple type of interestPoint
        int i = Random.Range(0, interestPoint[0].childCount);
        Debug.Log(i);
        Destination = interestPoint[0].GetChild(i);
    }
}