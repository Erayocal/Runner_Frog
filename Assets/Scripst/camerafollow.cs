using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camerafollow : MonoBehaviour
{
    public Transform target; // takip edilecek nesne
    public float smoothSpeed = 5f; // kamera hareketi yumuşaklığı
    public Vector3 offset; // kameranın takip ettiği konum
    void Start()
    {
        
    }
    void LateUpdate()
    {
        Vector3 desiredPosition = target.position + offset; // kameranın hedef konumu belirleniyor
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed); // kamera hareketi yumuşatılıyor
        transform.position = smoothedPosition; // kamera pozisyonu güncelleniyor
    }
}
