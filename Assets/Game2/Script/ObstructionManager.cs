using UnityEngine;
using System.Collections;

public class ObstructionManager : MonoBehaviour
{
    public GameObject Obstruction = null;
    public GameObject Haecho = null;
    public GameObject Bouble = null;
    public GameObject Cloud = null;
    int n;
    float x, y;
    void Start ()
    {
        StartCoroutine(CreateObstruction());
	}
	IEnumerator CreateObstruction()
    {
        while(true)
        {
            n = Random.Range(0, 10);
            x = 0;
            Instantiate(Haecho, new Vector2(10, Random.Range(-4.0f, -3.0f)), Quaternion.identity);
            if (n <= 7)
            {
                yield return new WaitForSeconds(x = Random.Range(1.0f, 1.5f));
                Instantiate(Bouble, new Vector2(10, Random.Range(-4.5f, 0)), Quaternion.identity);
            }
            if (n > 7)
            {
                Instantiate(Cloud, new Vector2(10, 2.2f), Quaternion.identity);
            }
            yield return new WaitForSeconds(Random.Range(2.0f,2.7f)-x);
        }
    }
	void Update () {
	
	}
}
