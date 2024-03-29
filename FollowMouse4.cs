using UnityEngine;
using System.Collections;

public class FollowMouse4 : MonoBehaviour
{	public float movementSpeed = 1.0f;
	public float distance = 1.0f;
	public bool useInitalCameraDistance = false;
	public LayerMask movementLayer = -1;
	private float actualDistance;
	private Vector3 targetPosition;
	private bool atTarget = true;

	// Use this for initialization
	void Start()
	{
		if (useInitalCameraDistance)
		{
			Vector3 toObjectVector = transform.position - Camera.main.transform.position;
			Vector3 linearDistanceVector = Vector3.Project(toObjectVector, Camera.main.transform.forward);

			actualDistance = linearDistanceVector.magnitude;
		}
		else
		{
			actualDistance = distance;
		}
	}

	// Update is called once per frame
	void Update()
	{
		RaycastHit hit;

		if(Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit, Mathf.Infinity, movementLayer))
		{
			Debug.DrawLine(transform.position, targetPosition,Color.white,1.0f);
			targetPosition = hit.point;

			StopAllCoroutines();
			atTarget = false;
		}

	
		Vector3 mousePosition = Input.mousePosition;
		transform.position = Vector3.MoveTowards(transform.position,targetPosition,movementSpeed*Time.deltaTime);
	}
}
