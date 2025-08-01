﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[ExecuteInEditMode]
public class DebugVertices : MonoBehaviour {

	Mesh mesh;
	Vector3[] vertices;

	void OnDrawGizmos()
	{
		if (vertices == null)
		{
			mesh = GetComponent<MeshFilter>().sharedMesh;
			vertices = mesh.vertices;
		}
		foreach (Vector3 v in vertices)
		{
			Vector3 viewVertex = SceneView.GetAllSceneCameras()[0].WorldToViewportPoint(transform.position + v);
			string viewVertexString = viewVertex.ToString();
			Handles.Label(transform.position + v, "v: " + v.ToString() + "wv: " + (transform.position + v).ToString()
				+ viewVertexString);
		}
            
	}
}
