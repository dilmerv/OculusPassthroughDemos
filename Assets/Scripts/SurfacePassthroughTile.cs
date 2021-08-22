using UnityEngine;

public class SurfacePassthroughTile : MonoBehaviour
{
    private MeshFilter projectionMeshFilter;

    private MeshRenderer outlineMeshRenderer;

    private bool surfaceProjectionAdded = false;

    void Start()
    {
        projectionMeshFilter = GetComponentInChildren<MeshFilter>();
        outlineMeshRenderer = GetComponentInChildren<MeshRenderer>();
    }

    public void AddProjection()
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
