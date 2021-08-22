using UnityEngine;

public class SurfacePassthroughTile : MonoBehaviour
{
    private MeshFilter projectionMeshFilter;

    private MeshRenderer outlineMeshRenderer;

    private bool surfaceProjectionAdded = false;

    private const int CREATE_PASSTHROUGH_LAYER_NUM = 1;

    void Start()
    {
        projectionMeshFilter = GetComponentInChildren<MeshFilter>();
        outlineMeshRenderer = GetComponentInChildren<MeshRenderer>();
    }

    public void AddProjection(bool randomize = true)
    {
        // randomize projection creation
        if (Random.Range(0, 2) == CREATE_PASSTHROUGH_LAYER_NUM && randomize)
        {
            AddProjection();
        }
        else
        {
            AddProjection();
        }
    }

    private void AddProjection()
    {
        SurfaceProjectionManager.Instance.PassthroughLayer
                        .AddSurfaceGeometry(projectionMeshFilter.gameObject, true);
        outlineMeshRenderer.enabled = false;
        surfaceProjectionAdded = true;
    }

    public void RemoveProjection()
    {
        if (surfaceProjectionAdded)
        {
            SurfaceProjectionManager.Instance.PassthroughLayer
                .RemoveSurfaceGeometry(projectionMeshFilter.gameObject);
        }
        outlineMeshRenderer.enabled = true;
    }
}
