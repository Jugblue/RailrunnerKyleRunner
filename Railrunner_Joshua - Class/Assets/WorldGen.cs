using UnityEngine;
using System.Collections;

public class WorldGen : MonoBehaviour
{
	public Transform[] segmentPrefabs;

	/*/private Transform previousSegment = null;
	private Transform currentSegment;
	private Transform nextSegment;
	/*/

	// Use this for initialization
	void Start ()
	{


		for (int i = 0; i< 200; ++i) {
			int whichPrefab = Random.Range (0, segmentPrefabs.Length);
			Instantiate (segmentPrefabs [whichPrefab], new Vector3 (0, 0, i * 50), Quaternion.identity);
			/*/
			whichPrefab = Random.Range (0, segmentPrefabs.Length);
			currentSegment = (Transform)Instantiate (segmentPrefabs [whichPrefab], new Vector3 (0, 0, 70), Quaternion.identity);
			/*/
		}
	
	}

}
