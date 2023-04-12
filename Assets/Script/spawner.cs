using UnityEngine;
using System.Collections;

public class spawner : MonoBehaviour {

    public GameObject block;
    public GameObject eatblock;
    public GameObject enemy;
    public static spawner instance;
    int magicnum;

    void Awake()
    {
        if (!instance)
        {
            instance = this;
        }
    }
    void Start()
    {
        Instantiate(block, _SetPos(), Quaternion.identity);
        StartCoroutine(RandomSpawn());
    }
    Vector3 SetPos()
    {
        float PosY = Random.Range(0.2f, 0.8f);
        float PosX = 0f;
        Vector3 Pos = Camera.main.ViewportToWorldPoint(new Vector3(PosX, PosY));
        Pos.z = 0;
        return Pos;
    }
    Vector3 _SetPos()
    {
        float PosY = Random.Range(0.2f, 0.8f);
        float PosX = 0f; 
        Vector3 Pos = Camera.main.ViewportToWorldPoint(new Vector3(PosX, PosY));
        Pos.z = 0;
        return Pos;
    }
    Vector3 SetPos_()
    {
        float PosY = 1f;
        float PosX = Random.Range(0.2f, 0.8f);
        Vector3 Pos = Camera.main.ViewportToWorldPoint(new Vector3(PosX, PosY));
        Pos.z = 0;
        return Pos;
    }
    IEnumerator RandomSpawn()
    {
        yield return new WaitForSeconds(250f*Time.deltaTime);    
        while (true)
        {
            magicnum = Random.Range(1, 13);
            if (magicnum  >= 1 && magicnum <=6 )
            {
                Souneff.instance.birdSound();
                Instantiate(enemy, SetPos_(), Quaternion.identity);
                Instantiate(block, _SetPos(), Quaternion.identity);
            }
            else if (magicnum >= 4 && magicnum <= 6)
            {
                Souneff.instance.birdSound();
                Instantiate(enemy, SetPos_(), Quaternion.identity);
                Instantiate(eatblock, SetPos(), Quaternion.identity);
            }
            else
            {
                Instantiate(eatblock, SetPos(), Quaternion.identity);
            }
            yield return new WaitForSeconds(250f*Time.deltaTime);
        }
    }
}
