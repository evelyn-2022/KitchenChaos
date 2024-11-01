using UnityEngine;

public class LookAtCamera : MonoBehaviour {
    private enum Mode {
        lookAt, lookAtInverted, CameraForward, CameraForwardInverted
    }

    [SerializeField] private Mode mode;

    private void LateUpdate() {
        switch (mode) {
            case Mode.lookAt:
                transform.LookAt(Camera.main.transform);
                break;
            case Mode.lookAtInverted:
                transform.rotation = Quaternion.LookRotation(transform.position - Camera.main.transform.position);
                break;
            case Mode.CameraForward:
                transform.forward = Camera.main.transform.forward;
                break;
            case Mode.CameraForwardInverted:
                transform.forward = -Camera.main.transform.forward;
                break;
        }
    }
}
