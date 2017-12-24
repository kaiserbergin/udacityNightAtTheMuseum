using UnityEngine;
using System.Collections;

public class ExhibitRevealer : MonoBehaviour {
    [SerializeField]
    public GameObject ExhibitInformationObject;
    [SerializeField]
    public GameObject WallDisplay;
    private void OnTriggerEnter(Collider other) {
        if (ExhibitInformationObject != null) {
            if (other.tag == "Player") {
                ExhibitInformationObject.SetActive(true);
                WallDisplay.SetActive(false);
            }
        }

    }
    private void OnTriggerExit(Collider other) {
        if (ExhibitInformationObject != null) {
            if (other.tag == "Player") {
                ExhibitInformationObject.SetActive(false);
                WallDisplay.SetActive(true);
            }
        }
    }
}
