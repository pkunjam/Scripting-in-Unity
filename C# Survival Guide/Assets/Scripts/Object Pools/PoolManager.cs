using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoolManager : MonoBehaviour
{
    private static PoolManager _instance;

    public static PoolManager Instance
    {
        get
        {
            if (_instance == null)
                Debug.LogError("Null");

            return _instance;
        }
    }

    [SerializeField]
    private GameObject _bulletPrefab;

    [SerializeField]
    private GameObject _bulletContainer;

    [SerializeField]
    private List<GameObject> _bulletPool;

    private void Awake()
    {
        _instance = this;
    }

    private void Start()
    {
        _bulletPool = GenerateBullets(3);
    }

    public List<GameObject> GenerateBullets(int count)
    {
        for (int i = 0; i < count; i++)
        {
            GameObject bullet = Instantiate(_bulletPrefab);
            bullet.transform.parent = _bulletContainer.transform;
            bullet.SetActive(false);

            _bulletPool.Add(bullet);
        }

        return _bulletPool;
    }

    public GameObject RequestBullet()
    {
        foreach (var b in _bulletPool)
        {
            if (b.activeSelf == false)
            {
                b.SetActive(true);
                return b;
            }
        }

        _bulletPool = GenerateBullets(1);
        GameObject newbullet = _bulletPool[_bulletPool.Count - 1];
        newbullet.SetActive(true);
        return newbullet;
    }
}
