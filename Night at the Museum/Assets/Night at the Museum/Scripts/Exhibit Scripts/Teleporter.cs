using UnityEngine;
using System.Collections;

public class Teleporter : MonoBehaviour {
    public void TeleportPlayerToWaypointNode() {
        Camera.main.transform.parent.transform.position = new Vector3(
            transform.position.x,
            Camera.main.transform.parent.transform.position.y,
            transform.position.z
        );
    }
}
