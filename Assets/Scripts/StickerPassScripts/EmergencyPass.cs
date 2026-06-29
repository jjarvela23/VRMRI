using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EmergencyPass : MonoBehaviour
{
    // Start is called before the first frame update
    public void SpawnPass()
    {
        GameObject.FindGameObjectWithTag("passReference").GetComponent<ReferencePass>().GetPass().SetActive(true);
    }
}
