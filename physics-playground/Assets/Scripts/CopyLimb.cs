using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CopyLimb : MonoBehaviour
{
    [SerializeField] private Transform _targetLimb;
    private ConfigurableJoint _configurableJoint;

    Quaternion targetInitialRotation;

    void Start()
    {
        _configurableJoint = GetComponent<ConfigurableJoint>();
        targetInitialRotation = _targetLimb.transform.localRotation;
    }

    private void FixedUpdate()
    {
        _configurableJoint.targetRotation = copyRotation();
    }

    private Quaternion copyRotation()
    {
        return Quaternion.Inverse(_targetLimb.localRotation) * targetInitialRotation;
    }
}
