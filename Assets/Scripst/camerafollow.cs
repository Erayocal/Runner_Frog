using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camerafollow : MonoBehaviour
{
    public Transform target; // takip edilecek nesne
    public float smoothSpeed = 5f; // kamera hareketi yumuþaklýðý
    public Vector3 offset; // kameranýn takip ettiði konum
    void Start()
    {
        
    }
    void LateUpdate()
    {
        Vector3 desiredPosition = target.position + offset; // kameranýn hedef konumu belirleniyor
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed); // kamera hareketi yumuþatýlýyor
        transform.position = smoothedPosition; // kamera pozisyonu güncelleniyor
    }
}
