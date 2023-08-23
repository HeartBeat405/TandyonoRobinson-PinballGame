using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VFXManager : MonoBehaviour
{
    public GameObject vfxSource;

    public void PlayVFX(Vector3 spawnPosition)
    {
        // spawn vfx pada posisi sesuai parameter
        Instantiate(vfxSource, spawnPosition, Quaternion.identity);
    }



    public VFXManager vfxManager;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("BounceObject"))
        {
            // Jalankan VFX saat tabrakan dengan bola pada posisi tabrakannya
            vfxManager.PlayVFX(collision.contacts[0].point);

            // Panggil metode AddScore dari GameManager saat bola memantul
            GameManager.Instance.AddScore(10);
        }
    }

}
