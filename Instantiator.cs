using UnityEngine;
using System.Collections;

public class Instantiator : MonoBehaviour
{
    public GameObject prefabtoInstantiate;
    public Vector3 maxOffset;
    public float instantiateTime;
    private float _instantiateTimer;
	private GameObject player;

    void Start()
    {
        _instantiateTimer = instantiateTime;
    }

    void Update()
    {
        _instantiateTimer -= Time.deltaTime;
		player = GameObject.FindGameObjectWithTag ("Player");
        if(player && _instantiateTimer <= 0)
        {
            Vector3 position = transform.position + new Vector3(Random.Range(-maxOffset.x, maxOffset.x), Random.Range(-maxOffset.y, maxOffset.y), Random.Range(-maxOffset.z, maxOffset.z));
			prefabtoInstantiate.transform.position = position;
            GameObject obj = (GameObject) Instantiate(prefabtoInstantiate);
            obj.transform.SetParent(this.transform);
            _instantiateTimer = instantiateTime;
        }
    }
}
