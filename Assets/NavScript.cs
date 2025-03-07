using UnityEngine;
using UnityEngine.AI;

public class nav : MonoBehaviour
{
    public NavMeshAgent agent;

    void Update()
    {
        if(Input.GetMouseButtonDown(1))
        {
            Ray movePosition = Camera.main.ScreenPointToRay(Input.mousePosition);
            if(Physics.Raycast(movePosition, out var hitInfo))
            {
                agent.SetDestination(hitInfo.point);
            }
        }
    }
}
