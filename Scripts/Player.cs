using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Player : MonoBehaviour
{
    private NavMeshAgent _nav;
    public GameObject Target_obj;
    // Start is called before the first frame update
    private void Start()
    {
        _nav = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    private void Update()
    {
        _nav.SetDestination(Target_obj.transform.position);
    }
}
