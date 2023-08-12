using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camerafollow : MonoBehaviour
{
    public Transform target; // takip edilecek nesne
    public float smoothSpeed = 5f; // kamera hareketi yumu�akl���
    public Vector3 offset; // kameran�n takip etti�i konum
    void Start()
    {
        
    }
    void LateUpdate()
    {
        Vector3 desiredPosition = target.position + offset; // kameran�n hedef konumu belirleniyor
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed); // kamera hareketi yumu�at�l�yor
        transform.position = smoothedPosition; // kamera pozisyonu g�ncelleniyor
    }
}
