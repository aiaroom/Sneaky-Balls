using UnityEngine;

public class TargetFollow : MonoBehaviour
{
    [SerializeField] Transform followObject;
    void Update()
    {
        transform.position = followObject.position;
    }
}
