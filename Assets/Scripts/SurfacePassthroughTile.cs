using UnityEngine;

public class SurfacePassthroughTile : MonoBehaviour
{
    private MeshFilter projectionMeshFilter;

    private MeshRenderer outlineMeshRenderer;

    private const int ACTIVATE_TILE_NUM = 1;

    void Start()
    {
        projectionMeshFilter = GetComponentInChildren<MeshFilter>();
        outlineMeshRenderer = GetComponentInChildren<MeshRenderer>();
    }

    public void RandomToggle()
    {
        if(Random.Range(0,1) == ACTIVATE_TILE_NUM)
        {
            SurfaceProjectionManager.Instance.PassthroughLayer
            .AddSurfaceGeometry(projectionMeshFilter.gameObject, true);

            outlineMeshRenderer.enabled = false;
        }
        else
        {
            SurfaceProjectionManager.Instance.PassthroughLayer
           .RemoveSurfaceGeometry(projectionMeshFilter.gameObject);

            outlineMeshRenderer.enabled = true;
        }
    }
}
