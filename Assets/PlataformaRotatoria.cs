using UnityEngine;

public class PlataformaRotatoria : MonoBehaviour {

    public float RotationSpeed; 
    void Update() {
        transform.rotation = Quaternion.Euler(0, 0, transform.rotation.eulerAngles.z + Time.deltaTime * RotationSpeed);
    }
}
