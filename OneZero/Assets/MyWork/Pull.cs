using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pull : MonoBehaviour
{
    public GameObject note = null;

    public List<GameObject> MobPool = new List<GameObject>();
    public GameObject[] Mobs;
    public int objCnt = 1;

    GameObject CreateObj(GameObject obj, Transform parent)
    {
        GameObject copy = Instantiate(obj);
        copy.transform.SetParent(parent);
        copy.SetActive(false);
        return copy;
    }
    // Start is called before the first frame update
    void Start()
    {
        //StartCoroutine(SpawnNoteOne());
        StartCoroutine(CreateMob());
    }

    void Awake()
    {
        for (int i = 0; i < Mobs.Length; i++)
        {
            for (int q = 0; q < objCnt; q++)
            {
                MobPool.Add(CreateObj(Mobs[i], transform));
            }
        }
    }
    //private IEnumerator SpawnNoteOne()
    //{
    //    while(true)
    //    {
    //        float randomX = Random.Range(-10, 10);
    //        Instantiate(note, new Vector2(randomX, 2), Quaternion.identity);
    //        yield return new WaitForSeconds(0.2f);
    //        float delay = 2;
    //        yield return new WaitForSeconds(delay);
    //    }

    //}

    IEnumerator CreateMob()
    {
        while (true)
        {
            MobPool[Random.Range(0, MobPool.Count)].SetActive(true);
            yield return new WaitForSeconds(Random.Range(1.3f, 4f));
        }
    }
}
