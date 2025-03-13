using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntityFX : MonoBehaviour
{
    private SpriteRenderer sr;

    [Header("Flash FX")]
    [SerializeField] private Material hitMat;       //vat lieu thay the hien thi hieu ung "bi danh"
    private Material originalMat;       //vat lieu ban dau cua doi tuong

    private void Start()
    {
        sr = GetComponentInChildren<SpriteRenderer>();
        originalMat = sr.material;
    }

    private IEnumerator FlashFX()
    {  
        sr.material = hitMat;
        yield return new WaitForSeconds(.2f);
        sr.material = originalMat;
    }
}
