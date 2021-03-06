using UnityEngine;
using System.Collections;

public class LookAtTarget : MonoBehaviour
{

	public GameObject target; // the target that the camera should look at

	void Start()
	{
		if (target == null)
		{
			target = this.gameObject;
			Debug.Log("LookAtTarget target not specified. Defaulting to parent GameObject");
		}
	}

	// Update is called once per frame
	void Update()
	{
		if (target)
        {
			transform.position = new Vector3(transform.position.x, target.transform.position.y, transform.position.z);
		}
			
	}
}