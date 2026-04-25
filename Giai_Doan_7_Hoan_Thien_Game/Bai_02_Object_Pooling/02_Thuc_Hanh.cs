using System.Collections.Generic;
using UnityEngine;

public class BulletPool : MonoBehaviour
{
    // Prefab vien dan.
    public GameObject bulletPrefab;

    // So luong vien dan tao san.
    public int poolSize = 10;

    // Hang doi cac vien dan ranh.
    private Queue<GameObject> availableBullets = new Queue<GameObject>();

    void Awake()
    {
        // Tao san cac vien dan.
        for (int i = 0; i < poolSize; i++)
        {
            GameObject bullet = Instantiate(bulletPrefab);
            bullet.SetActive(false);
            availableBullets.Enqueue(bullet);
        }
    }

    public GameObject GetBullet()
    {
        // Neu khong con vien dan ranh thi tra ve null.
        if (availableBullets.Count == 0)
        {
            return null;
        }

        GameObject bullet = availableBullets.Dequeue();
        bullet.SetActive(true);
        return bullet;
    }

    public void ReturnBullet(GameObject bullet)
    {
        // Tat vien dan di va dua lai vao pool.
        bullet.SetActive(false);
        availableBullets.Enqueue(bullet);
    }
}
