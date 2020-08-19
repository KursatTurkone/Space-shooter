using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sinirlar : MonoBehaviour
{
   void OnTriggerExit(Collider col)
    {
        Destroy(col.gameObject);

    }
}
